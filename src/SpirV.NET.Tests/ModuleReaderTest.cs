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
            var spirvStream = typeof(ModuleReaderTests).Assembly.GetManifestResourceStream("SpirV.NET.Tests.Assets.frag.spv");
            var module = ModuleReader.Parse(spirvStream);
        }
    }
}
