using System;


namespace R5T.T0051
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class TypeCodeLocationCollectionEntryOperator : ITypeCodeLocationCollectionEntryOperator
    {
        #region Static
        
        public static TypeCodeLocationCollectionEntryOperator Instance { get; } = new();

        #endregion
    }
}