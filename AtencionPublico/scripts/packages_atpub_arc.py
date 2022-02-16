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

