﻿using Mediateka.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Classes
{
    public class Picture: IDisk

    {
        public string Url { get; private set; }
        public new string Name { get; protected set; }

        public string Pictures
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Picture(string name, string url)
        {
            this.Name = name;
            Url = url;
        }
    }
}
