using System;
using System.Collections.Generic;

using R5T.Magyar;

using R5T.T0049;
using R5T.T0051;


namespace System
{
    public static partial class ITypeCodeLocationIndexOperatorExtensions
    {
        public static void AddEntryNonIdempotent(this ITypeCodeLocationIndexOperator _,
            TypeCodeLocationIndex index,
            TypeCodeLocationCollectionEntry entry)
        {
            index.EntriesByNamespacedTypeName.Add(entry.NamespacedTypeName, entry);
        }

        /// <summary>
        /// Quality-of-life overload for <see cref="AddEntryNonIdempotent(ITypeCodeLocationIndexOperator, TypeCodeLocationIndex, TypeCodeLocationCollectionEntry)"/>.
        /// </summary>
        public static void AddEntry(this ITypeCodeLocationIndexOperator _,
            TypeCodeLocationIndex index,
            TypeCodeLocationCollectionEntry entry)
        {
            _.AddEntryNonIdempotent(index, entry);
        }

        public static void AddEntriesNonIdempotent(this ITypeCodeLocationIndexOperator _,
            TypeCodeLocationIndex index,
            IEnumerable<TypeCodeLocationCollectionEntry> entries)
        {
            foreach (var entry in entries)
            {
                _.AddEntryNonIdempotent(index, entry);
            }
        }

        /// <summary>
        /// Quality-of-life overload for <see cref="AddEntriesNonIdempotent(ITypeCodeLocationIndexOperator, TypeCodeLocationIndex, IEnumerable{TypeCodeLocationCollectionEntry})"/>.
        /// </summary>
        public static void AddEntries(this ITypeCodeLocationIndexOperator _,
            TypeCodeLocationIndex index,
            IEnumerable<TypeCodeLocationCollectionEntry> entries)
        {
            _.AddEntriesNonIdempotent(index, entries);
        }

        public static bool HasEntryByNamespacedTypeName(this ITypeCodeLocationIndexOperator _,
            TypeCodeLocationIndex index,
            string namespacedTypeName)
        {
            var output = index.EntriesByNamespacedTypeName.ContainsKey(namespacedTypeName);
            return output;
        }

        public static bool HasEntryByNamespacedTypeName(this ITypeCodeLocationIndexOperator _,
            TypeCodeLocationIndex index,
            NamespacedTypeName namespacedTypeName)
        {
            var output = _.HasEntryByNamespacedTypeName(index, namespacedTypeName.Value);
            return output;
        }

        public static bool HasEntry(this ITypeCodeLocationIndexOperator _,
            TypeCodeLocationIndex index,
            NamespacedTypeName namespacedTypeName)
        {
            var output = _.HasEntryByNamespacedTypeName(index, namespacedTypeName);
            return output;
        }
    }
}
