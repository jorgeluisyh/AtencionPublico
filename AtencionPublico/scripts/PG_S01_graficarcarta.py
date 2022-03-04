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

response = dict()
response['status'] = 1
response['message'] = 'success'

parameter = arcpy.GetParameterAsText(0)
value = arcpy.GetParameterAsText(1)
distance = arcpy.GetParameterAsText(2)

def graficar(listacartas):
    """
    Limpiamos la tabla de contenidos del mxd actual
    """
    lista_cartas = list(map(lambda x: x[0].lower()+".ecw", listacartas))
    query = "Name IN ('{}')".format("','".join(lista_cartas))
    lyr =arcpy.MakeRasterCatalogLayer_management(st._CARTA_NACIONAL_GEOWGS84,'cartita',query).getOutput(0)

    mxd = arcpy.mapping.MapDocument('current') # using current map, can also use a path to a mxd here
    df = arcpy.mapping.ListDataFrames(mxd)[0]
    arcpy.mapping.AddLayer(df, lyr, "TOP")
    ext = lyr.getExtent()
    df.extent = ext
    arcpy.RefreshActiveView()

    return 1

def getcartasbyparameter(param, value,distance):
    """
    Obtener listado de cartas según el parámetro de ingreso
    """
    listado_cartas = []
    if param=='carta' :
        cartas = pa.get_cartas_by_carta(value,distance)
    elif param=='distrito':
        cartas = pa.get_cartas_by_distrito(value,distance)
    elif param=='dm':
        cartas = pa.get_cartas_by_dm(value,distance)
    elif param=='coordenada':
        x,y,zona = value.split(";")
        cartas = pa.get_cartas_by_coord(x,y,zona,distance)
    else:
        cartas = ["error"]
    
    if cartas == True:
        raise Exception('Error al obtener las cartas por {}'.format(param))


    if type(cartas)==list:
        return cartas
    else:
        listado_cartas.append([cartas])
        return listado_cartas


try:
    listacartas = getcartasbyparameter(parameter, value,distance)
    arcpy.AddMessage(listacartas)

    respuesta = graficar(listacartas)
    response["response"] = respuesta
    # arcpy.AddMessage("Hello World!")
except Exception as e:
    response['status'] = 0
    # response['message'] = e.message
    response['message'] =traceback.format_exc()
finally:
    response = json.dumps(response, encoding='windows-1252', ensure_ascii=False)
    arcpy.SetParameterAsText(3, response)
