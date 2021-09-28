using System;
using System.Collections.Generic;

using R5T.T0051;


namespace System
{
    public static partial class ITypeCodeLocationIndexOperatorExtensions
    {
        public static TypeCodeLocationIndex From(this ITypeCodeLocationIndexOperator _,
            IEnumerable<TypeCodeLocationCollectionEntry> entries)
        {
            var output = _.New();

            _.AddEntries(output, entries);

            return output;
        }

        public static TypeCodeLocationIndex New(this ITypeCodeLocationIndexOperator _)
        {
            var output = new TypeCodeLocationIndex();
            return output;
        }
    }
}
