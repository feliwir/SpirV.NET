using System;
using System.IO;
using System.Collections.Generic;

namespace CodeGenerator
{
    class Program
    {
        static string Sanitize(string name)
        {
            if (char.IsDigit(name[0]))
            {
                return "_" + name;
            }

            return name;
        }

        static void Main(string[] args)
        {
            string outputPath;
            if (args.Length > 0)
            {
                outputPath = args[0];
            }
            else
            {
                outputPath = AppContext.BaseDirectory;
            }

            var def = new SpirVDefinition();
            def.LoadFrom(AppContext.BaseDirectory);

            Console.WriteLine($"SpirV specification version: {def.VersionString}");
            Console.WriteLine($"Outputting generated code files to {outputPath}.");

            using (CSharpCodeWriter writer = new CSharpCodeWriter(Path.Combine(outputPath, "Grammar.gen.cs")))
            {
                writer.PushBlock("namespace SpirVNET");
                writer.PushBlock($"public static class Grammar");
                writer.WriteLine($"public static uint MagicNumber => {def.MagicNumber};");
                writer.WriteLine($"public static uint MajorVersion => {def.MajorVersion};");
                writer.WriteLine($"public static uint MinorVersion => {def.MinorVersion};");
                writer.WriteLine($"public static uint Revision => {def.Revision};");
                writer.PopBlock();
                writer.PopBlock();
            }

            using (CSharpCodeWriter writer = new CSharpCodeWriter(Path.Combine(outputPath, "Instructions.gen.cs")))
            {
                writer.WriteLine("using System.IO;");
                writer.PushBlock("namespace SpirVNET.Instructions");

                writer.PushBlock("public enum OpCode");
                foreach (InstructionDefinition id in def.Instructions)
                {
                    writer.WriteLine($"{id.Name} = {id.OpCode},");
                }
                writer.PopBlock();

                writer.PushBlock("public static class InstructionCreator");
                writer.PushBlock("public static IInstruction CreateInstruction(OpCode opcode)");
                writer.PushBlock("switch(opcode)");
                HashSet<int> handledCases = new HashSet<int>();
                foreach (InstructionDefinition id in def.Instructions)
                {
                    // Skip aliases
                    if(handledCases.Contains(id.OpCode))
                        continue;

                    writer.WriteLine($"case OpCode.{id.Name}: return new {id.Name}();");
                    handledCases.Add(id.OpCode);
                }
                writer.WriteLine("default: throw new InvalidDataException($\"Opcode ({opcode}) does not exist!\");");
                writer.PopBlock();
                writer.PopBlock();         
                writer.PopBlock();

                // Base interface
                writer.PushBlock("public interface IInstruction");
                writer.WriteLine("OpCode Opcode { get; }");
                writer.PopBlock();

                foreach (InstructionDefinition id in def.Instructions)
                {
                    writer.PushBlock($"public class {id.Name} : IInstruction");
                    writer.WriteLine($"public OpCode Opcode => OpCode.{id.Name};");
                    writer.PopBlock();
                }
                writer.PopBlock();
            }

            using (CSharpCodeWriter writer = new CSharpCodeWriter(Path.Combine(outputPath, "OperandKinds.gen.cs")))
            {
                writer.WriteLine("using System;");
                writer.PushBlock("namespace SpirVNET");

                foreach (OperandKindDefinition okd in def.OperandKinds)
                {
                    switch (okd.Category)
                    {
                        case OperandCategory.BitEnum:
                            writer.WriteLine("[Flags]");
                            writer.PushBlock($"enum {okd.Kind}");
                            break;
                        case OperandCategory.ValueEnum:
                            writer.PushBlock($"enum {okd.Kind}");
                            break;
                    }

                    switch (okd.Category)
                    {
                        case OperandCategory.BitEnum:
                        case OperandCategory.ValueEnum:
                            foreach (var enumerant in okd.Enumerables)
                            {
                                var name = Sanitize(enumerant.Name);
                                writer.WriteLine($"{name} = {enumerant.Value},");
                            }

                            writer.PopBlock();
                            break;
                    }
                }

                writer.PopBlock();
            }
        }
    }
}
