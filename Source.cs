﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22_Reflection
{
    public class Source
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }

    }
}
