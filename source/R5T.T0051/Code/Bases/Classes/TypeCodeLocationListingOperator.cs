using System;


namespace R5T.T0051
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class TypeCodeLocationListingOperator : ITypeCodeLocationListingOperator
    {
        #region Static
        
        public static TypeCodeLocationListingOperator Instance { get; } = new();

        #endregion
    }
}