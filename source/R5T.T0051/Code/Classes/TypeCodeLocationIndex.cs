using System;
using System.Collections.Generic;


namespace R5T.T0051
{
    public class TypeCodeLocationIndex
    {
        public Dictionary<string, TypeCodeLocationCollectionEntry> EntriesByNamespacedTypeName { get; } = new Dictionary<string, TypeCodeLocationCollectionEntry>();
    }
}
