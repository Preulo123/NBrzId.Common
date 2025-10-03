namespace NBrzId.Common
{
    /// <summary>
    /// Represents a Brazilian CNPJ (Cadastro Nacional da Pessoa Jurídica) identifier used to register legal entities.
    /// </summary>
    /// <remarks>
    /// Key characteristics of the CNPJ:
    /// <list type="bullet">
    ///     <item><description><see cref="Length"/> indicates the standard number of characters in a CNPJ (always 14).</description></item>
    ///     <item><description><see cref="Mask"/> is the standard display format: "XX.XXX.XXX/XXXX-NN".</description></item>
    ///     <item><description><see cref="PaddingCharacter"/>: '0' used for left-padding shorter values.</description></item>
    /// </list>
    /// </remarks>
    public sealed class Cnpj : BaseBrzIdentifier
    {
        internal static readonly Cnpj _instance;
        internal static Cnpj Instance => _instance;

        /// <summary>
        /// Total number of characters in a CNPJ, excluding formatting symbols.
        /// </summary>
        public override int Length => 14;
        /// <summary>
        /// Display mask for a CNPJ: "XX.XXX.XXX/XXXX-NN".
        /// </summary>
        public override string Mask => "XX.XXX.XXX/XXXX-NN";
        /// <summary>
        /// Character used to pad a CNPJ on the left when the input has fewer than <see cref="Length"/> digits.
        /// </summary>
        public override char PaddingCharacter => '0';

        static Cnpj()
        {
            _instance = new Cnpj();
        }

        internal Cnpj()
        { }
    }
}
