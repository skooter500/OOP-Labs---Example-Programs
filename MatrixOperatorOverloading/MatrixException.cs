﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixOperatorOverloading
{
    public class MatrixException:Exception
    {
        public MatrixException(string message)
            : base(message)
        {
        }
    }
}
