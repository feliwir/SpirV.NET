using System;

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
            
            Console.WriteLine($"Outputting generated code files to {outputPath}.");
        }
    }
}
