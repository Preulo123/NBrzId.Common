using System.Linq;

namespace NBrzId.Common
{
    /// <summary>
    /// Base class for Brazilian identifier types, providing common properties 
    /// such as mask, length, padding, and formatting characters.
    /// </summary>
    public abstract class BaseBrzIdentifier : IBrzIdentifier
    {
        /// <summary>
        /// Characters that are part of the identifier mask but are not actual data symbols.
        /// </summary>
        public virtual char[] FormattingCharacters => Mask?.Where(c => c != 'N' && c != 'A' && c != 'X')?.ToArray();
        /// <summary>
        /// Character used to left-pad an identifier when the input length is shorter than <see cref="Length"/>.
        /// </summary>
        public abstract char PaddingCharacter { get; }
        /// <summary>
        /// Total number of characters (excluding formatting symbols) in the identifier.
        /// </summary>
        public abstract int Length { get; }
        /// <summary>
        /// Mask that defines the identifier format.
        /// </summary>
        public abstract string Mask { get; }
    }
}
