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
    public int MajorVersion { get; private set; }
    public int MinorVersion { get; private set; }
    public int Revision { get; private set; }

    public string VersionString => MajorVersion + "." + MinorVersion + "." + Revision;

    public InstructionDefinition[] Instructions;
    public OperandKindDefinition[] OperandKinds;

    public void LoadFrom(string directory)
    {
      JObject grammarJson;
      using (StreamReader fs = File.OpenText(Path.Combine(directory, "spirv.core.grammar.json")))
      using (JsonTextReader jr = new JsonTextReader(fs))
      {
        grammarJson = JObject.Load(jr);
      }

      MajorVersion = grammarJson["major_version"].ToObject<int>();
      MinorVersion = grammarJson["minor_version"].ToObject<int>();
      Revision = grammarJson["revision"].ToObject<int>();

      Instructions = grammarJson["instructions"].Select(jt =>
      {
        // Operands can be optional
        Operand[] operands = jt["operands"]?.Select(op =>
        {
          // Name can be optional
          return new Operand(op["kind"].ToString(), op["name"]?.ToString());
        }).ToArray();

        string[] capabilities = jt["capabilities"]?.Select(x => x.ToString()).ToArray();

        return new InstructionDefinition(jt["opname"].ToString(), jt["opcode"].ToObject<int>(), operands, capabilities);
      }).ToArray();

      OperandKinds = grammarJson["operand_kinds"].Select(jt =>
      {
        var category = jt["category"].ToObject<OperandCategory>();
        Enumerant[] enumerables = null;

        switch (category)
        {
          case OperandCategory.BitEnum:
          case OperandCategory.ValueEnum:
            enumerables = jt["enumerants"].Select(e =>
            {
              return new Enumerant(e["enumerant"].ToString(), e["value"].ToString(), null);
            }).ToArray();
            break;
        }

        return new OperandKindDefinition(category, jt["kind"].ToString(), jt["doc"]?.ToString(), enumerables);
      }).ToArray();
    }
  }

  enum Quantifier
  {
    ONCE,
    OPTIONAL,
    ZERO_OR_MORE
  }

  enum OperandCategory
  {
    BitEnum,
    ValueEnum,
    Id,
    Literal,
    Composite
  }

  class Enumerant
  {
    public string Name { get; }
    public string Value { get; }
    public string[] Capabilties { get; }

    public Enumerant(string name, string value, string[] capabilities)
    {
      Name = name;
      Value = value;
      Capabilties = capabilities;
    }
  }

  class OperandKindDefinition
  {
    public OperandCategory Category { get; }
    public string Kind { get; }
    public string Doc { get; }
    public Enumerant[] Enumerables { get; }

    public OperandKindDefinition(OperandCategory category, string kind, string doc, Enumerant[] enumerables)
    {
      Category = category;
      Kind = kind;
      Doc = doc;
      Enumerables = enumerables;
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

    public string[] Capabilties { get; }

    public InstructionDefinition(string name, int opcode, Operand[] operands, string[] capabilities)
    {
      Name = name;
      Operands = operands;
      OpCode = opcode;
      Capabilties = capabilities;
    }
  }
}