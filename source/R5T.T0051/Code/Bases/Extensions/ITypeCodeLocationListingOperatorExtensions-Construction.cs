using System;
using System.Collections.Generic;

using R5T.T0051;


namespace System
{
    public static partial class ITypeCodeLocationListingOperatorExtensions
    {
        public static TypeCodeLocationListing From(this ITypeCodeLocationListingOperator _,
            IEnumerable<TypeCodeLocationCollectionEntry> entries)
        {
            var output = _.New();

            output.Entries.AddRange(entries);

            return output;
        }

        public static TypeCodeLocationListing New(this ITypeCodeLocationListingOperator _)
        {
            var output = new TypeCodeLocationListing();
            return output;
        }
    }
}
