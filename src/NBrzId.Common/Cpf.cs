namespace NBrzId.Common
{
    /// <summary>
    /// Represents a Brazilian CPF (Cadastro de Pessoas Físicas) identifier, used for individual taxpayer registration and other purposes.
    /// </summary>
    /// <remarks>
    /// The <see cref="Cpf"/> class implements the <see cref="IBrzIdentifier"/> interface, providing validation, formatting, and 
    /// access to specific properties related to CPF identifiers. 
    /// <list type="bullet">
    ///     <item><description><see cref="Length"/> indicates the standard number of digits in a CPF (11 digits).</description></item>
    ///     <item><description><see cref="Mask"/> defines the CPF format, e.g., "NNN.NNN.NNN-NN".</description></item>
    ///     <item><description><see cref="FormattingCharacters"/> specifies CPF formatting symbols (periods and hyphen).</description></item>
    ///     <item><description><see cref="PaddingCharacter"/> specifies a character used for left padding the identifier if the provided value is shorter than <see cref="Length"/>.</description></item>
    /// </list>
    /// </remarks>
    public sealed class Cpf : BaseBrzIdentifier
    {
        internal static readonly Cpf _instance;
        internal static Cpf Instance => _instance;

        public override int    Length           => 11;
        public override string Mask             => "NNN.NNN.NNN-NN";
        public override char   PaddingCharacter => '0';

        static Cpf()
        {
            _instance = new Cpf();
        }

        internal Cpf()
        { }
    }
}
