﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_library
{
    public class BLL_class
    {
        private int _studid;

        public int StudentID
        {
            get { return _studid; }
            set { _studid = value; }
        }

        private string _studname;

        public string StudName
        {
            //20
            get { return _studname; }
            set { _studname = value; }
        }

        private int _studclass;
        public int StudentClass
        {
            get { return _studclass; }
            set { _studclass = value; }
        }

        private int _classno;

        public int classno
        {
            get { return _classno; }
            set { _classno = value; }
        }
        private string  _section;

        public string  classsection
        {
            get { return _section; }
            set { _section = value; }
        }

    }

}