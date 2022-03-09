#!/usr/bin/env python
# -*- coding: utf-8 -*-
import sys
reload(sys)
sys.setdefaultencoding("utf-8")
import arcpy
import os
import json
import settings_atpub as st
import packages_atpub_arc as pa
import traceback
import uuid

response = dict()
response['status'] = 1
response['message'] = 'success'

coordx = arcpy.GetParameterAsText(0)
coordy = arcpy.GetParameterAsText(1)
wkid = arcpy.GetParameterAsText(2)
radiokm = arcpy.GetParameterAsText(3)

uuid_sufix = uuid.uuid4().hex
scratch = arcpy.env.scratchGDB

fc_arese = os.path.join(st._BDGEOCAT_SDE,)

_fc_areaconsulta = "atpub_areaconsulta"
_fc_atpub_arese = "atpub_arese"
_fc_atpub_catastro= "atpub_catastro"
_fc_atpub_distrito = "atpub_distrito"
_fc_atpub_zur= "atpub_zur"
listacapas = [_fc_areaconsulta,_fc_atpub_arese,_fc_atpub_catastro,_fc_atpub_distrito,_fc_atpub_zur]
zonas = [17, 18, 19]

capa_fin_rese = ""
capa_fin_catastro = ""
capa_fin_distrito = ""
capa_fin_zur = ""

def borrar_capas_temp():
    """
    Borra las capas temporales de la base de datos"""

    try:
        arcpy.env.workspace = scratch
        listafcs = arcpy.ListFeatureClasses()
        for capa in listafcs:
            if capa.startswith("atpub_"):
                arcpy.Delete_management(capa)
    except Exception as e:
        pass

def copiar_capas_temp():
    """
    Copia las capas de la base de datos bdeocat a la capa temporal de la base de datos de escritorio"""

    for zona in zonas:
        for capa in listacapas:
            capa_temp = capa + "_" + str(zona)
            capain = os.path.join(st._BASE_GDB, capa_temp)
            capaout = os.path.join(scratch, "{}_{}".format(capa_temp, uuid_sufix))
            arcpy.Select_analysis(capain, capaout,"1=0")        

def get_proyected_coords(coordx, coordy, wkid, zona):
    """
    Obtiene las coordenadas proyectadas a la zona"""

    point = arcpy.Point(float(coordx), float(coordy))
    pointGeometry = arcpy.PointGeometry(point, arcpy.SpatialReference(int(wkid)))
    proyGeometry = pointGeometry.projectAs(arcpy.SpatialReference(int('327{}'.format(zona))))
    return proyGeometry.firstPoint.X, proyGeometry.firstPoint.Y


def crear_rect(x,y,radio,capa):
    """
    Crea un rectangulo en la capa de salida a partir de las coordenadas x,y y el radio"""
    x = float(x)
    y = float(y)
    radio = float(radio)
    icursor = arcpy.da.InsertCursor(capa,["SHAPE@"])
    verts = [
	(x-radio, y+radio),
	(x+radio, y+radio),
	(x+radio, y-radio),
	(x-radio, y-radio)]
    
    icursor.insertRow([verts])
    del icursor

def cargar_registros_a_capas(zona, capa_influencia):
    """
    Carga los registros de las capas a las capas temporales de escritorio"""

    global capa_fin_rese, capa_fin_catastro, capa_fin_distrito, capa_fin_zur

    dataset = "DATA_GIS.DS_CATASTRO_MINERO_WGS84_{}".format(zona)
    fc_arese = os.path.join(st._BDGEOCAT_SDE, dataset, "DATA_GIS.GPO_ARE_AREA_RESERVADA_WGS_{}".format(zona))
    fc_catastro = os.path.join(st._BDGEOCAT_SDE, dataset, "DATA_GIS.GPO_CMI_CATASTRO_MINERO_WGS_{}".format(zona))
    fc_distrito = os.path.join(st._BDGEOCAT_SDE, dataset, "DATA_GIS.GPO_DIS_DISTRITO_WGS_{}".format(zona))
    fc_zur = os.path.join(st._BDGEOCAT_SDE, dataset, "DATA_GIS.GPO_ZUR_ZONA_URBANA_WGS_{}".format(zona))

    #definimos lyrs 
    fc_arese_lyr = arcpy.MakeFeatureLayer_management(fc_arese)
    fc_catastro_lyr = arcpy.MakeFeatureLayer_management(fc_catastro)
    fc_distrito_lyr = arcpy.MakeFeatureLayer_management(fc_distrito)
    fc_zur_lyr = arcpy.MakeFeatureLayer_management(fc_zur)
    capa_influencia_lyr = arcpy.MakeFeatureLayer_management(capa_influencia)

    arcpy.SelectLayerByLocation_management(fc_arese_lyr, "INTERSECT", capa_influencia_lyr)
    arcpy.SelectLayerByLocation_management(fc_catastro_lyr, "INTERSECT", capa_influencia_lyr)
    arcpy.SelectLayerByLocation_management(fc_distrito_lyr, "INTERSECT", capa_influencia_lyr)
    arcpy.SelectLayerByLocation_management(fc_zur_lyr, "INTERSECT", capa_influencia_lyr)

    capa_fin_rese = os.path.join(scratch, "atpub_arese_{}_{}".format(zona, uuid_sufix))
    capa_fin_catastro = os.path.join(scratch, "atpub_catastro_{}_{}".format(zona, uuid_sufix))
    capa_fin_distrito = os.path.join(scratch, "atpub_distrito_{}_{}".format(zona, uuid_sufix))
    capa_fin_zur = os.path.join(scratch, "atpub_zur_{}_{}".format(zona, uuid_sufix))

    arcpy.Append_management(fc_arese_lyr, capa_fin_rese, "NO_TEST")
    arcpy.Append_management(fc_catastro_lyr, capa_fin_catastro, "NO_TEST")
    arcpy.Append_management(fc_distrito_lyr, capa_fin_distrito, "NO_TEST")
    arcpy.Append_management(fc_zur_lyr, capa_fin_zur, "NO_TEST")

    arcpy.CalculateField_management(in_table=capa_fin_catastro, field="CONTADOR", expression="[OBJECTID]", expression_type="VB", code_block="")

    arcpy.SelectLayerByAttribute_management(fc_arese_lyr, "CLEAR_SELECTION")
    arcpy.SelectLayerByAttribute_management(fc_catastro_lyr, "CLEAR_SELECTION")
    arcpy.SelectLayerByAttribute_management(fc_distrito_lyr, "CLEAR_SELECTION")
    arcpy.SelectLayerByAttribute_management(fc_zur_lyr, "CLEAR_SELECTION")

def agregar_layers_a_mapa(zona):
    mxd = arcpy.mapping.MapDocument("CURRENT")
    df = arcpy.mapping.ListDataFrames(mxd, "Layers")[0]
    lyr_area_consulta = arcpy.mapping.Layer(os.path.join(st._LAYERS_DIR, "Area_consulta.lyr"))
    lyr_Distrito = arcpy.mapping.Layer(os.path.join(st._LAYERS_DIR, "Distrito.lyr"))
    lyr_Zona_Urbana = arcpy.mapping.Layer(os.path.join(st._LAYERS_DIR, "Zona_Urbana.lyr"))
    lyr_Area_Reserva = arcpy.mapping.Layer(os.path.join(st._LAYERS_DIR, "Area_Reserva.lyr"))
    lyr_Catastro = arcpy.mapping.Layer(os.path.join(st._LAYERS_DIR, "atpub_catastro_{}.lyr".format(zona)))

    arcpy.mapping.AddLayer(df,lyr_area_consulta,"TOP")
    arcpy.mapping.AddLayer(df,lyr_Distrito,"TOP")
    arcpy.mapping.AddLayer(df,lyr_Zona_Urbana,"TOP")
    arcpy.mapping.AddLayer(df,lyr_Area_Reserva,"TOP")
    arcpy.mapping.AddLayer(df,lyr_Catastro,"TOP")

    mxd_lyr_catastro = arcpy.mapping.ListLayers(mxd, "Catastro Minero*", df)[0]
    mxd_lyr_Area_Reserva = arcpy.mapping.ListLayers(mxd, "Area Reservada*", df)[0]
    mxd_lyr_Zona_Urbana = arcpy.mapping.ListLayers(mxd, "Zona Urbana*", df)[0]
    mxd_lyr_Distrito = arcpy.mapping.ListLayers(mxd, "Distrito*", df)[0]
    mxd_lyr_Area_consulta = arcpy.mapping.ListLayers(mxd, "Area consulta*", df)[0]

    mxd_lyr_catastro.replaceDataSource(scratch, "FILEGDB_WORKSPACE", "{}_{}_{}".format(_fc_atpub_catastro, zona, uuid_sufix))
    mxd_lyr_Area_Reserva.replaceDataSource(scratch, "FILEGDB_WORKSPACE", "{}_{}_{}".format(_fc_atpub_arese, zona, uuid_sufix))
    mxd_lyr_Zona_Urbana.replaceDataSource(scratch, "FILEGDB_WORKSPACE", "{}_{}_{}".format(_fc_atpub_zur, zona, uuid_sufix))
    mxd_lyr_Distrito.replaceDataSource(scratch, "FILEGDB_WORKSPACE", "{}_{}_{}".format(_fc_atpub_distrito, zona, uuid_sufix))
    mxd_lyr_Area_consulta.replaceDataSource(scratch, "FILEGDB_WORKSPACE", "{}_{}_{}".format(_fc_areaconsulta, zona, uuid_sufix))

    df.extent = mxd_lyr_Area_consulta.getSelectedExtent()
    df.scale = int(df.scale/10000)*10000*1.1
    arcpy.RefreshActiveView()



def main():
    zona = pa.get_zona_by_coord(coordx, coordy, wkid)
    borrar_capas_temp()
    copiar_capas_temp()
    capa_influencia = os.path.join(scratch, "atpub_areaconsulta_{}_{}".format(zona, uuid_sufix))
    x_proy, y_proy = get_proyected_coords(coordx, coordy, wkid, zona)
    crear_rect(x_proy, y_proy, radiokm, capa_influencia)
    cargar_registros_a_capas(zona, capa_influencia)
    agregar_layers_a_mapa(zona)


try:
    # Insertar procesos 
    response["response"]="response"
    arcpy.AddMessage("Hello World!")
    main()
except Exception as e:
    response['status'] = 0
    # response['message'] = e.message
    response['message'] = traceback.format_exc()
finally:
    response = json.dumps(response, encoding='windows-1252', ensure_ascii=False)
    arcpy.SetParameterAsText(4, response)
