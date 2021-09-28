using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0051;


namespace System
{
    public static partial class ITypeCodeLocationListingOperatorExtensions
    {
        public static void AddEntryUnconstrained(this ITypeCodeLocationListingOperator _,
            TypeCodeLocationListing listing,
            TypeCodeLocationCollectionEntry entry)
        {
            listing.Entries.Add(entry);
        }

        public static void AddEntryIdempotent(this ITypeCodeLocationListingOperator _,
            TypeCodeLocationListing listing,
            TypeCodeLocationCollectionEntry entry)
        {
            var hasEntry = _.HasEntry(listing, entry);
            if(!hasEntry)
            {
                _.AddEntryUnconstrained(listing, entry);
            }
        }

        public static void AddEntryNonIdempotent(this ITypeCodeLocationListingOperator _,
            TypeCodeLocationListing listing,
            TypeCodeLocationCollectionEntry entry)
        {
            var hasEntry = _.HasEntry(listing, entry);
            if (hasEntry)
            {
                throw Instances.ExceptionGenerator.TypeCodeLocationCollectionEntryAlreadyExists(entry);
            }

            _.AddEntryUnconstrained(listing, entry);
        }

        /// <summary>
        /// Chooses <see cref="AddEntryIdempotent(ITypeCodeLocationListingOperator, TypeCodeLocationListing, TypeCodeLocationCollectionEntry)"/> as the default.
        /// </summary>
        public static void AddEntry(this ITypeCodeLocationListingOperator _,
            TypeCodeLocationListing listing,
            TypeCodeLocationCollectionEntry entry)
        {
            _.AddEntryIdempotent(listing, entry);
        }

        public static void AddEntriesUnconstrained(this ITypeCodeLocationListingOperator _,
            TypeCodeLocationListing listing,
            IEnumerable<TypeCodeLocationCollectionEntry> entries)
        {
            listing.Entries.AddRange(entries);
        }

        public static void AddEntriesIdempotent(this ITypeCodeLocationListingOperator _,
            TypeCodeLocationListing listing,
            IEnumerable<TypeCodeLocationCollectionEntry> entries)
        {
            var entriesToAdd = entries
                .Where(xEntry => _.HasNotEntry(listing, xEntry))
                ;

            _.AddEntriesUnconstrained(listing, entriesToAdd);
        }

        /// <summary>
        /// Chooses <see cref="AddEntriesIdempotent(ITypeCodeLocationListingOperator, TypeCodeLocationListing, IEnumerable{TypeCodeLocationCollectionEntry})"/> as the default.
        /// </summary>
        public static void AddEntries(this ITypeCodeLocationListingOperator _,
            TypeCodeLocationListing listing,
            IEnumerable<TypeCodeLocationCollectionEntry> entries)
        {
            _.AddEntriesIdempotent(listing, entries);
        }

        public static void ClearEntries(this ITypeCodeLocationListingOperator _,
            TypeCodeLocationListing listing)
        {
            listing.Entries.Clear();
        }

        public static bool HasEntry(this ITypeCodeLocationListingOperator _,
            TypeCodeLocationListing listing,
            TypeCodeLocationCollectionEntry entry)
        {
            var output = listing.Entries
                .Where(xEntry => Instances.TypeCodeLocationListingEntryOperator.Equal(xEntry, entry))
                .Any();

            return output;
        }

        public static bool HasNotEntry(this ITypeCodeLocationListingOperator _,
            TypeCodeLocationListing listing,
            TypeCodeLocationCollectionEntry entry)
        {
            var hasEntry = _.HasEntry(listing, entry);

            var output = !hasEntry;
            return output;
        }
    }
}
