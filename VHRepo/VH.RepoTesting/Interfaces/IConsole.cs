﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VH.RepoTesting.Interfaces
{
    public interface IConsole
    {
        string ReadInput();
        void WriteOutputOnNewLine(string output);
        void WriteOutput(string output);
    }
}
