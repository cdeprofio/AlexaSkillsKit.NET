﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexaSkillsKit.UI.EchoShowUI
{
    public class Directive
    {
        public virtual string Type { get; set; }
        public virtual Template Template { get; set; }
    }
}
