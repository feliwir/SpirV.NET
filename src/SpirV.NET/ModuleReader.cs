using System;
using System.IO;
using SpirVNET.Instructions;

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

        private static IInstruction ReadInstruction(Span<UInt32> words, ref int currentWord)
        {
            uint wordCount = words[currentWord] >> 16;
            Instructions.OpCode opCode = (Instructions.OpCode)(words[currentWord] & 0xFFFF);

            Span<UInt32> operands = null;
            uint numOperands = wordCount - 1;
            if(numOperands > 0)
            {
                operands = words.Slice(currentWord + 1, (int)numOperands);
            }

            currentWord += (int)wordCount;

            return InstructionCreator.CreateInstruction(opCode);
        }

        private static void ReadInstructions(BinaryReader br, ref Module module)
        {
            long remainingBytes = br.BaseStream.Length - br.BaseStream.Position;
            UInt32[] wordArray = new UInt32[remainingBytes / 4];
            long wordCount = 0;

            while(br.BaseStream.Position < br.BaseStream.Length)
            {
                wordArray[wordCount++] = br.ReadUInt32();
            }

            for(int currentWord = 0; currentWord < wordCount;)
            {
                module.Instructions.Add(ReadInstruction(wordArray, ref currentWord));
            }
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
                ReadInstructions(br, ref module);

                return module;
            }
        }

    }
}
