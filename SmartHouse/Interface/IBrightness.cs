﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
    public interface IBrightness
    {
        void SetLow();
        void SetMedium();
        void SetHigh();
    }
}
