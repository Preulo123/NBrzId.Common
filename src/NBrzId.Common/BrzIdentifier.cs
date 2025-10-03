namespace NBrzId.Common
{
    /// <summary>
    /// Provides access to instances of Brazilian identifier types.
    /// </summary>
    /// <remarks>
    /// The <see cref="BrzIdentifier"/> static class serves as a central access point for 
    /// Brazilian identifier types, exposing instances of <see cref="Cpf"/> and <see cref="Cnpj"/>.
    /// </remarks>
    public static class BrzIdentifier
    {
        /// <summary>
        /// Exposes an instance of the CNPJ identifier.
        /// </summary>
        public static Cnpj Cnpj => Cnpj.Instance;
        /// <summary>
        /// Exposes an instance of the CPF identifier.
        /// </summary>
        public static Cpf  Cpf  => Cpf.Instance;
    }
}
