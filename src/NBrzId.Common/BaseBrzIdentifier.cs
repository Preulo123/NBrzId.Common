using System.Linq;

namespace NBrzId.Common
{
    public abstract class BaseBrzIdentifier : IBrzIdentifier
    {
        public virtual char[] FormattingCharacters => Mask?.Where(c => c != 'N' && c != 'A')?.ToArray();
        
        public abstract char   PaddingCharacter { get; }
        public abstract int    Length           { get; }
        public abstract string Mask             { get; }
    }
}
