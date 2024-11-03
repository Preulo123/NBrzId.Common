using Xunit;

namespace NBrzId.Common.Tests
{
    public sealed class CnpjTests
    {
        [Fact]
        public void ShouldCreateStaticInstanceAfterInstantiation()
        {
            new Cnpj();

            Assert.NotNull(Cnpj._instance);
        }
        
        [Fact]
        public void ShouldCreateStaticInstanceBeforeGetInstance()
        {
            var _ = Cnpj.Instance;

            Assert.NotNull(Cnpj._instance);
        }

        [Fact]
        public void ShouldGetExpectedLength()
        {
            var actual = Cnpj.Instance.Length;

            Assert.Equal(14, actual);
        }

        [Fact]
        public void ShouldGetMask()
        {
            var actual = Cnpj.Instance.Mask;

            Assert.Equal("NN.NNN.NNN/NNNN-NN", actual);
        }

        [Fact]
        public void ShouldGetPaddingCharacter()
        {
            var actual = Cnpj.Instance.PaddingCharacter;

            Assert.Equal('0', actual);
        }
    }
}