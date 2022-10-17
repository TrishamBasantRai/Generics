﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsheetItems
{
    public interface ICustomStack <T>
    {
        void Push(T a);
        int Count();
        T Pop();
    }
}
