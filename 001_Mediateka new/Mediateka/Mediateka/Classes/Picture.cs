﻿using Mediateka.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Classes
{
    public class Picture: IDisk, IMedia, IEvent, ISerial, ICompilation

    {
        public string Url { get; private set; }
        public string Name { get; protected set; }

        public Picture(string name, string url)
        {
            Name = name;
            Url = url;
        }

        public IMediaStream GetStream()
        {
            throw new NotImplementedException();
        }

        public void Play()
        {
            throw new NotImplementedException();
        }
    }
}
