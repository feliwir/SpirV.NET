using System;
using System.Collections.Generic;
using SpirVNET.Instructions;

namespace SpirVNET
{
    public class Module
    {
        public uint Version { get; }
        public List<IInstruction> Instructions { get; }

        public Module(uint version)
        {
            Version = version;
            Instructions = new List<IInstruction>();
        }
    }
}
