﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VH.RepoTesting.Interfaces;

namespace VH.RepoTesting
{
    public class ConsoleReadWrite : IConsole
    {
        public string ReadInput()
        {
            return Console.ReadLine();
        }

        public void WriteOutput(string output)
        {
            Console.Write(output);
        }

        public void WriteOutputOnNewLine(string output)
        {
            Console.WriteLine(output);
        }
    }
}