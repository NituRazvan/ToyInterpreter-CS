﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterpretorC.View.Menu
{
    public abstract class Command
    {
        public string key, description;
        public Command(string key, string description) { this.key = key; this.description = description; }
        public abstract void Execute();
        public string GetKey() { return key; }
        public string GetDescription() { return description; }
    }
}
