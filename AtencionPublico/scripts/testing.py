#!/usr/bin/env python
# -*- coding: utf-8 -*-

# import packages_aut as pkg
# import settings_aut as st

# calc = st._IONES["cation"][0]

# # m =pkg.get_dic_dominio('DOM_FAC_HIDRO')
# # for row in m:
# #     if calc in row[2]:
# #         print row[0] + ":"+ row[1]+ " :"+ row[2]

# n = pkg.get_campo_type_dom()
# print len(n)

import arcobjects as arc

mxd_path = r"C:\Users\jyupanqui\AppData\Local\Temp\response_22d6bbc50c8d49d79331a94c51a7c367_new.mxd"
arc.select_grid_by_name(mxd_path, u'32718_200k', exclude_grids=['4326'])

