using System;
using System.IO;

namespace CodeGenerator
{
  class Program
  {
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

      using (CSharpCodeWriter writer = new CSharpCodeWriter(Path.Combine(outputPath, "Instructions.gen.cs")))
      {
        writer.PushBlock("namespace SpirVEmit.Instructions");
        // Base interface
        writer.PushBlock("public interface IInstruction");
        writer.WriteLine("int OpCode {get; private set;}");
        writer.PopBlock();

        foreach (InstructionDefinition id in def.Instructions)
        {
          writer.PushBlock($"public class {id.Name} : IInstruction");
          writer.WriteLine($"public int OpCode => {id.OpCode};");
          writer.PopBlock();
        }
        writer.PopBlock();
      }

      using (CSharpCodeWriter writer = new CSharpCodeWriter(Path.Combine(outputPath, "OperandKinds.gen.cs")))
      {
        writer.WriteLine("using System;");
        writer.PushBlock("namespace SpirVEmit");

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
                writer.WriteLine($"{enumerant.Name} = {enumerant.Value},");
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
