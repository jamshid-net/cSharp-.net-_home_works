﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6.Task_7.Interface
{
    internal interface IElektronika
    {
        string model { get; set; }
        double volt { get; set; }
    }
}
