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

# param = arcpy.GetParameterAsText(0)

def getcartas():
    """
    Obtener cartas geográficas a partir de la base de datos bdeocat
    """
    # _DATASET_CARTA = 'DATA_GIS.DS_BASE_CATASTRAL_WGS84_18S'
    # _FEATURE_CARTA = 'DATA_GIS.GPO_HOJ_HOJAS_18'
    # _CD_HOJA = "CD_HOJA"
    # _NM_HOJA = "NM_HOJA"
    # campos = [_CD_HOJA, _NM_HOJA]
    # order_clause = "ORDER BY {} ASC , {} ASC".format(_CD_HOJA, _NM_HOJA)
    # fc_cartas = os.path.join(st._BDGEOCAT_SDE, _DATASET_CARTA, _FEATURE_CARTA)
    # query= "NM_HOJA = 'CURARAY' OR CD_HOJA='29-U'"

    # lista = [[i[0],i[1]] for i in arcpy.da.SearchCursor(fc_cartas, campos, where_clause = query, sql_clause = (None, order_clause))]
    # respuesta =[[i[0],u"{} : {}".format(cambiarcarta(i[0]),i[1])] for i in lista]
    respuesta = pa.get_cartas()
    respuesta.insert(0, ['', 'Seleccione una carta'])
    return respuesta

    


try:
    listado_cartas = getcartas()
    response["response"] = listado_cartas
    arcpy.AddMessage("Hello World!")
except Exception as e:
    response['status'] = 0
    # response['message'] = e.message
    response['message'] =traceback.format_exc()
finally:
    response = json.dumps(response, encoding='windows-1252', ensure_ascii=False)
    arcpy.SetParameterAsText(0, response)
