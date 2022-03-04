#!/usr/bin/env python
# -*- coding: utf-8 -*-
import os

__author__ = 'Jorge Luis Yupanqui Herrera'
__copyright__ = 'INGEMMET 2022'
__credits__ = ['Jorge Yupanqui H.']
__version__ = '1.0.1'
__maintainer__ = 'Jorge Yupanqui H.'
__mail__ = 'jyupanqui@ingemmet.gob.pe'
__title__ = 'Atencion al Publico'
__status__ = 'Production'

_BASE_DIR = os.path.dirname(__file__)
_REQUIREMENTS_DIR = os.path.join(_BASE_DIR, 'require')

_IMG_DIR = os.path.join(_BASE_DIR, 'img')
_IMG_LOGO_INGEMMET = os.path.join(_IMG_DIR, 'logo_ingemmet.png')

_BDGEOCAT_NAME = 'bdgeocat_dev.sde' if __status__ == 'Development' else 'bdgeocat.sde'
_BDGEOCAT_SDE = os.path.join(_BASE_DIR, _BDGEOCAT_NAME)
# _BDGEOCAT_SDE_DEV = os.path.join(_BASE_DIR, 'bdgeocat_dev.sde')
#Capas de BDGEOCAT
_CARTA_NACIONAL_GEOWGS84 = os.path.join(_BDGEOCAT_SDE, 'DATA_GIS.DS_IGN_CARTA_NACIONAL_GEOWGS84')

_ZONAS_GEOGRAFICAS = [17, 18, 19]
_EPSG_W17S = 32717
_EPSG_W18S = 32718
_EPSG_W19S = 32719

_LAYERS_DIR = os.path.join(_BASE_DIR, 'layers')
_EXT_LAYER = '.lyr'     # Extension de archivos Layer