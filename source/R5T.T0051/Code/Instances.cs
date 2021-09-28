using System;

using R5T.Magyar.T002;

using R5T.T0034;


namespace R5T.T0051
{
    public static class Instances
    {
        public static IExceptionGenerator ExceptionGenerator { get; } = Magyar.T002.ExceptionGenerator.Instance;
        public static IExceptionMessageGenerator ExceptionMessageGenerator { get; } = Magyar.T002.ExceptionMessageGenerator.Instance;
        public static INamespacedTypeName NamespacedTypeName { get; } = T0034.NamespacedTypeName.Instance;
        public static ITypeCodeLocationCollectionEntryOperator TypeCodeLocationListingEntryOperator { get; } = T0051.TypeCodeLocationCollectionEntryOperator.Instance;
    }
}
