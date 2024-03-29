﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionPublico
{
    public class exceptions
    {
    }
    public class AtencionPublicoExceptions: Exception
    {
        public string nl = System.Environment.NewLine;
        public AtencionPublicoExceptions()
        {
        }

        public AtencionPublicoExceptions(string message) : base(message)
    {
        }

        public AtencionPublicoExceptions(string message, Exception inner) : base(message, inner)
    {
        }

        private string strExtracrInfo;

        public string PythonError
        {
            get
            {
                return strExtracrInfo;
            }
            set
            {
                strExtracrInfo = "PythonError:" + nl + value;
            }
        }
        public string VisualError
        {
            get
            {
                return strExtracrInfo;
            }
            set
            {
                strExtracrInfo = "VisualError:" + nl + value;
            }
        }
        public string ValidationError
        {
            get
            {
                return strExtracrInfo;
            }
            set
            {
                strExtracrInfo = "ValidationError:" + nl + value;
            }
        }
        public string SigcatminError
        {
            get
            {
                return strExtracrInfo;
            }
        }

    }
}


