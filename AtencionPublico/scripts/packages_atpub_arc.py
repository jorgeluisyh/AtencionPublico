#!/usr/bin/env python
# -*- coding: utf-8 -*-
import sys
reload(sys)
sys.setdefaultencoding("utf-8")
import settings_atpub as st
import arcpy

arcpy.env.workspace = st._BASE_DIR
connarc = arcpy.ArcSDESQLExecute(st._BDGEOCAT_NAME)

def arcPackageDecore(func):
    def decorator(*args, **kwargs):
        global connarc    
        package = func(*args, **kwargs)
        cursor = connarc.execute(package)
        return cursor

    return decorator

@arcPackageDecore
def get_all_regions():
    return "SELECT CD_DEPA, CAST(CD_DEPA || ' - ' || NM_DEPA as varchar(100)) FROM DATA_GIS.GPO_DEP_DEPARTAMENTO WHERE CD_DEPA <> '99' order by CD_DEPA"

@arcPackageDecore
def get_cartas():
    return "SELECT CD_HOJA,REPLACE(CD_HOJA,'-1','-Ñ') ||' : '||NM_HOJA NMHOJA FROM DATA_GIS.GPO_HOJ_HOJAS_18"

@arcPackageDecore
def get_distritos():
    return "select cd_dist, cd_dist ||' : '|| nm_dist ||', '||nm_prov||', '||nm_depa from data_gis.gpo_dis_distrito_wgs_18 where CD_DEPA <> '99' order by cd_dist"

@arcPackageDecore
def get_derechominero(value):
    return "select codigou, concesion, tit_conces, carta, zona, hectagis from DATA_GIS.GPO_CMI_CATASTRO_MINERO_WGS_18 where codigou = '{}'".format(value)

@arcPackageDecore
def get_cartas_by_carta(carta,distance):
    return """select a.cd_hoja from data_gis.gpo_hoj_hojas_18 a, (select * from data_gis.gpo_hoj_hojas_18 where cd_hoja = '{0}' ) b
    where sde.st_intersects(a.shape, sde.st_buffer(sde.st_centroid(b.shape),{1}))=1""".format(carta,distance)

@arcPackageDecore
def get_cartas_by_distrito(distrito,distance):
    return """select a.cd_hoja from data_gis.gpo_hoj_hojas_18 a, (select * from data_gis.gpo_dis_distrito_wgs_18 where cd_dist = '{0}' ) b
    where sde.st_intersects(a.shape, sde.st_buffer(sde.st_centroid(b.shape),{1}))=1""".format(distrito,distance)

@arcPackageDecore
def get_cartas_by_dm(dm,distance):
    return """select a.cd_hoja from data_gis.gpo_hoj_hojas_18 a, (select * from DATA_GIS.GPO_CMI_CATASTRO_MINERO_WGS_18 where codigou = '{0}' ) b
    where sde.st_intersects(a.shape, sde.st_buffer(sde.st_centroid(b.shape),{1}))=1""".format(dm,distance)

@arcPackageDecore
def get_cartas_by_coord(x,y,wkid,distance):
    return """select a.cd_hoja from data_gis.gpo_hoj_hojas_18 a 
    where sde.st_intersects(a.shape, sde.st_buffer(sde.st_geometry({x},{y},null,null,327{w}),{d}))=1""".format(x=x,y=y,w=wkid,d=distance)