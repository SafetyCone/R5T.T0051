using System;

using R5T.Magyar.T002;

using R5T.T0051;

using Instances = R5T.T0051.Instances;


namespace System
{
    public static class IExceptionGeneratorExtensions
    {
        public static InvalidOperationException TypeCodeLocationCollectionEntryAlreadyExists(this IExceptionGenerator _,
            TypeCodeLocationCollectionEntry entry)
        {
            var message = Instances.ExceptionMessageGenerator.TypeCodeLocationCollectionEntryAlreadyExists(entry);

            var output = new InvalidOperationException(message);
            return output;
        }
    }
}
