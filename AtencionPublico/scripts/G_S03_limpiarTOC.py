import sys
reload(sys)
sys.setdefaultencoding("utf-8")
import arcpy
import os
import json
import settings_atpub as st
import traceback

response = dict()
response['status'] = 1
response['message'] = 'success'

param = arcpy.GetParameterAsText(0)

def clearToc(capaname=""):
    """
    Limpiamos la tabla de contenidos del mxd actual
    """
    mxd = arcpy.mapping.MapDocument("CURRENT")
    dataframe = arcpy.mapping.ListDataFrames(mxd)[0]
    layers = arcpy.mapping.ListLayers(mxd)
    for lyr in layers:
        if lyr.name != capaname:
            arcpy.mapping.RemoveLayer(dataframe, lyr)
    return 1

    


try:
    respuesta = clearToc(param)
    response["response"] = respuesta
    # arcpy.AddMessage("Hello World!")
except Exception as e:
    response['status'] = 0
    response['message'] = e.message
    # response['message'] =traceback.format_exc()
finally:
    response = json.dumps(response, encoding='windows-1252', ensure_ascii=False)
    arcpy.SetParameterAsText(1, response)
