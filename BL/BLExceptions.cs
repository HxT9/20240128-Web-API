﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLException : Exception
    {
        public BLException(string message) : base(message)
        {
        }
    }

    public class AlreadyExistsException : BLException
    {
        public AlreadyExistsException(string message) : base(message)
        {
        }
    }
}
