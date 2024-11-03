namespace NBrzId.Common
{
    /// <summary>
    /// Represents a Brazilian CNPJ (Cadastro Nacional da Pessoa Jurídica) identifier, used for legal entities (companies, 
    /// institutions, organizations) registration.
    /// </summary>
    /// <remarks>
    /// The <see cref="Cnpj"/> class implements the <see cref="IBrzIdentifier"/> interface, offering validation, formatting, 
    /// and access to properties specific to CNPJ identifiers. 
    /// <list type="bullet">
    ///     <item><description><see cref="Length"/> indicates the standard number of digits in a CNPJ (14 digits).</description></item>
    ///     <item><description><see cref="Mask"/> defines the CNPJ format, e.g., "NN.NNN.NNN/NNNN-NN".</description></item>
    ///     <item><description><see cref="FormattingCharacters"/> specifies CNPJ formatting symbols (periods, slashes, and hyphen).</description></item>
    ///     <item><description><see cref="PaddingCharacter"/> specifies a character used for left padding the identifier if the provided value is shorter than <see cref="Length"/>.</description></item>
    /// </list>
    /// </remarks>
    public sealed class Cnpj : BaseBrzIdentifier
    {
        internal static readonly Cnpj _instance;
        internal static Cnpj Instance => _instance;

        public override int    Length           => 14;
        public override string Mask             => "NN.NNN.NNN/NNNN-NN";
        public override char   PaddingCharacter => '0';

        static Cnpj()
        {
            _instance = new Cnpj();
        }

        internal Cnpj()
        { }
    }
}
