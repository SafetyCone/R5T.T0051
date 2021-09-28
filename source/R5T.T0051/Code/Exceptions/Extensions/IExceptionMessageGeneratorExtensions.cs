using System;

using R5T.Magyar.T002;

using R5T.T0051;


namespace System
{
    public static class IExceptionMessageGeneratorExtensions
    {
        public static string TypeCodeLocationCollectionEntryAlreadyExists(this IExceptionMessageGenerator _,
            TypeCodeLocationCollectionEntry entry)
        {
            var entryDescription = Instances.TypeCodeLocationListingEntryOperator.Describe(entry);

            var output = $"Type code location index entry already exists:\n{entryDescription}";
            return output;
        }
    }
}
