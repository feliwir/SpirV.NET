using System;
using System.IO;


namespace SpirVNET
{
    public static class ModuleReader
    {
        private static void ReadHeader(BinaryReader br, out Module module)
        {
            var magic = br.ReadUInt32();
            var version = br.ReadUInt32();
            var generator = br.ReadUInt32();
            var bound = br.ReadUInt32();
            var reserved = br.ReadUInt32();

            if (magic != SpirVNET.Grammar.MagicNumber)
                throw new InvalidDataException("Magic number is incorrect");

            module = new Module(version);
        }

        public static Module Parse(Stream stream)
        {
            if (stream.Length < 20)
            {
                throw new InvalidDataException("Stream is too small to contain a SpirV Module");
            }

            using (BinaryReader br = new BinaryReader(stream))
            {
                ReadHeader(br, out var module);

                return module;
            }
        }

    }
}
