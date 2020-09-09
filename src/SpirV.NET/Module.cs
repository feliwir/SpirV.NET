using System;

namespace SpirVNET
{
    public class Module
    {
        public uint Version { get; }

        public Module(uint version)
        {
            Version = version;
        }
    }
}
