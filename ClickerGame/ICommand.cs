﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame
{
    internal interface ICommand
    {
        void Run();
        char Char { get; }
    }
}
