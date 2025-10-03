namespace NBrzId.Common
{
    /// <summary>
    /// Defines a Brazilian identifier used to represent individuals or legal entities for various purposes.
    /// </summary>
    /// <remarks>
    /// The <see cref="IBrzIdentifier"/> interface standardizes the representation of various types of Brazilian identifiers.
    /// </remarks>
    public interface IBrzIdentifier
    {
        /// <summary>
        /// Characters that are part of the identifier mask but are not actual data symbols.
        /// For example, in a mask like "NN.NNN.N/NN-NN", the formatting characters are '.', '/', and '-'.
        /// </summary>
        char[] FormattingCharacters { get; }
        /// <summary>
        /// Character used to left-pad an identifier when the input length is shorter than <see cref="Length"/>.
        /// </summary>
        char PaddingCharacter { get; }
        /// <summary>
        /// Total number of characters (excluding formatting symbols) in the identifier.
        /// </summary>
        int Length { get; }
        /// <summary>
        /// Mask that defines the identifier format.
        /// Supported placeholders:
        /// <list type="bullet">
        ///   <item><description><c>N</c>: numeric digit (0–9)</description></item>
        ///   <item><description><c>A</c>: alphabetic character (A–Z)</description></item>
        ///   <item><description><c>X</c>: alphanumeric character (0–9, A–Z)</description></item>
        /// </list>
        /// </summary>
        string Mask { get; }
    }
}
