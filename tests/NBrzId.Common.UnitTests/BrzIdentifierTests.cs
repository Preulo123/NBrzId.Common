using Xunit;

namespace NBrzId.Common.Tests
{
    public sealed class BrzIdentifierTests
    {
        [Fact]
        public void ShouldReturnCnpjInstance()
        {
            var expected = Cnpj.Instance;

            var actual = BrzIdentifier.Cnpj;

            Assert.Same(expected, actual);
        }

        [Fact]
        public void ShouldReturnCpfInstance()
        {
            var expected = Cpf.Instance;

            var actual = BrzIdentifier.Cpf;

            Assert.Same(expected, actual);
        }
    }
}
