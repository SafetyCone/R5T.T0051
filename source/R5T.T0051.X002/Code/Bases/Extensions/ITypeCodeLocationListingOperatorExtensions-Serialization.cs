using System;
using System.IO;

using R5T.T0051;

using Instances = R5T.T0051.X002.Instances;


namespace System
{
    public static partial class ITypeCodeLocationListingOperatorExtensions
    {
        public static TypeCodeLocationListing LoadFromJsonFile(this ITypeCodeLocationListingOperator _,
            string jsonFilePath)
        {
            var entries = Instances.TypeCodeLocationCollectionEntryOperator.LoadFromJsonFile(jsonFilePath);

            var output = _.From(entries);
            return output;
        }

        public static void WriteToJsonFile(this ITypeCodeLocationListingOperator _,
            string jsonFilePath,
            TypeCodeLocationListing listing,
            bool overwrite = IOHelper.DefaultOverwriteValue)
        {
            Instances.TypeCodeLocationCollectionEntryOperator.WriteToJsonFile(jsonFilePath, listing.Entries, overwrite: overwrite);
        }

        public static void WriteToJsonFileWithoutAlphabetization(this ITypeCodeLocationListingOperator _,
            string jsonFilePath,
            TypeCodeLocationListing listing,
            bool overwrite = IOHelper.DefaultOverwriteValue)
        {
            Instances.TypeCodeLocationCollectionEntryOperator.WriteToJsonFileWithoutAlphabetization(jsonFilePath, listing.Entries, overwrite: overwrite);
        }
    }
}