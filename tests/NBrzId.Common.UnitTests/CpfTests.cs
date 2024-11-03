using Xunit;

namespace NBrzId.Common.Tests
{
    public sealed class CpfTests
    {
        [Fact]
        public void ShouldCreateStaticInstanceAfterInstantiation()
        {
            new Cpf();

            Assert.NotNull(Cpf._instance);
        }
        
        [Fact]
        public void ShouldCreateStaticInstanceBeforeGetInstance()
        {
            var _ = Cpf.Instance;

            Assert.NotNull(Cpf._instance);
        }

        [Fact]
        public void ShouldGetExpectedLength()
        {
            var actual = Cpf.Instance.Length;

            Assert.Equal(11, actual);
        }

        [Fact]
        public void ShouldGetMask()
        {
            var actual = Cpf.Instance.Mask;

            Assert.Equal("NNN.NNN.NNN-NN", actual);
        }

        [Fact]
        public void ShouldGetPaddingCharacter()
        {
            var actual = Cpf.Instance.PaddingCharacter;

            Assert.Equal('0', actual);
        }
    }
}