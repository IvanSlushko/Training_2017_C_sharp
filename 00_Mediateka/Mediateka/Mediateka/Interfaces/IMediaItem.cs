﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Interfaces
{
    public interface IMediaItem
    {
        string Name { get; }
        string Url { get; }
    }
}
