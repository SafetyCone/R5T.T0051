using System;


namespace R5T.T0051
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class TypeCodeLocationIndexOperator : ITypeCodeLocationIndexOperator
    {
        #region Static
        
        public static TypeCodeLocationIndexOperator Instance { get; } = new();

        #endregion
    }
}