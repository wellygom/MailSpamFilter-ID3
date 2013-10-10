﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApplication1
{
    public class OutcomeTreeAttribute : TreeAttribute
    {
        public OutcomeTreeAttribute(object Label)
            : base(String.Empty, null)
        {
            _label = Label;
            _name = string.Empty;
            _possibleValues = null;
        }
    }
}
