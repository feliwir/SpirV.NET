using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CodeGenerator
{
  class SpirVDefinition
  {
    public InstructionDefinition[] Instructions;

    public void LoadFrom(string directory)
    {
      JObject grammarJson;
      using (StreamReader fs = File.OpenText(Path.Combine(directory, "spirv.core.grammar.json")))
      using (JsonTextReader jr = new JsonTextReader(fs))
      {
        grammarJson = JObject.Load(jr);
      }

      Instructions = grammarJson["instructions"].Select(jt =>
      {
        // Operands can be optional
        Operand[] operands = jt["operands"]?.Select(op =>
        {
          // Name can be optional
          return new Operand(op["kind"].ToString(), op["name"]?.ToString());
        }).ToArray();

        return new InstructionDefinition(jt["opname"].ToString(), jt["opcode"].ToObject<int>(), operands);
      }).ToArray();

      foreach (var instr in Instructions)
      {
        Console.WriteLine(instr.Name);
      }
    }
  }

  class Operand
  {
    public string Kind { get; }
    public string Name { get; }

    public Operand(string kind, string name)
    {
      Kind = kind;
      Name = name;
    }
  }

  class InstructionDefinition
  {
    public string Name { get; }
    public Operand[] Operands { get; }
    public int OpCode { get; }

    public InstructionDefinition(string name, int opcode, Operand[] operands)
    {
      Name = name;
      Operands = operands;
      OpCode = opcode;
    }
  }
}