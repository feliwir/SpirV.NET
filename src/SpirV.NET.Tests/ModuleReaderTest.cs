using System;
using Xunit;
using Xunit.Abstractions;

namespace SpirVNET.Tests
{
    public class ModuleReaderTests
    {
        private readonly ITestOutputHelper output;

        public ModuleReaderTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void CanReadModule()
        {
            output.WriteLine("This is output from");
            var spirvStream = typeof(ModuleReaderTests).Assembly.GetManifestResourceStream("SpirVNET.Tests.Assets.frag.spv");
            var module = ModuleReader.Parse(spirvStream);
        }
    }
}
