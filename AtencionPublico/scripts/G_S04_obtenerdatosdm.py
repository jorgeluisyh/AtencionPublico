import sys
reload(sys)
sys.setdefaultencoding("utf-8")
import arcpy
import os
import json
import settings_atpub as st
import traceback
import packages_atpub_arc as pa

response = dict()
response['status'] = 1
response['message'] = 'success'

param = arcpy.GetParameterAsText(0)

def getdmvalues(coddm):
    """
    Obtener datos del derecho minero a partir de la base de datos bdeocat
    """

    respuesta = pa.get_derechominero(coddm)
    if respuesta == True:
        raise Exception('Error al obtener codigo de derecho minero')
    return respuesta

   
try:
    valores_dm = getdmvalues(param)
    response["response"] = valores_dm
    # arcpy.AddMessage("Hello World!")
except Exception as e:
    response['status'] = 0
    response['message'] = e.message
    # response['message'] =traceback.format_exc()
finally:
    response = json.dumps(response, encoding='windows-1252', ensure_ascii=False)
    arcpy.SetParameterAsText(1, response)
