namespace NBrzId.Common
{
    /// <summary>
    /// Represents a Brazilian CPF (Cadastro de Pessoas Físicas) identifie used for individual taxpayer registration.
    /// </summary>
    /// <remarks>
    /// Key characteristics of the CPF:
    /// <list type="bullet">
    ///     <item><description><see cref="Length"/> indicates the standard number of characters in a CPF (always 11).</description></item>
    ///     <item><description><see cref="Mask"/> is the standard display format: "NNN.NNN.NNN-NN".</description></item>
    ///     <item><description><see cref="PaddingCharacter"/>: '0' used for left-padding shorter values.</description></item>
    /// </list>
    /// </remarks>
    public sealed class Cpf : BaseBrzIdentifier
    {
        internal static readonly Cpf _instance;
        internal static Cpf Instance => _instance;

        /// <summary>
        /// Total number of characters in a CPF, excluding formatting symbols.
        /// </summary>
        public override int Length => 11;
        /// <summary>
        /// Display mask for a CPF: "NNN.NNN.NNN-NN".
        /// </summary>
        public override string Mask => "NNN.NNN.NNN-NN";
        /// <summary>
        /// Character used to pad a CPF on the left when the input has fewer than <see cref="Length"/> digits.
        /// </summary>
        public override char PaddingCharacter => '0';

        static Cpf()
        {
            _instance = new Cpf();
        }

        internal Cpf()
        { }
    }
}
