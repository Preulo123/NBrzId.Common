namespace NBrzId.Common
{
    /// <summary>
    /// Defines a Brazilian identifier used to represent individuals or legal entities for various purposes.
    /// </summary>
    /// <remarks>
    /// The <see cref="IBrzIdentifier"/> interface standardizes the representation of various types of Brazilian identifiers.
    /// Implementing types must provide the length, the mask, a list of formatting characters and a padding character.
    /// </remarks>
    public interface IBrzIdentifier
    {
        char[]  FormattingCharacters { get; }
        char    PaddingCharacter     { get; }
        int     Length               { get; }
        string  Mask                 { get; }
    }
}
