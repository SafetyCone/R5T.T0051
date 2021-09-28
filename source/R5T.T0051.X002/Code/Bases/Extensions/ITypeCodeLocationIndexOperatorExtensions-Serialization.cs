using System;

using R5T.Magyar.IO;

using R5T.T0051;

using Instances = R5T.T0051.X002.Instances;


namespace System
{
    public static class ITypeCodeLocationIndexOperatorExtensions
    {
        public static TypeCodeLocationIndex LoadFromJsonFile(this ITypeCodeLocationIndexOperator _,
            string jsonFilePath)
        {
            var entries = Instances.TypeCodeLocationCollectionEntryOperator.LoadFromJsonFile(jsonFilePath);

            var output = _.From(entries);
            return output;
        }

        public static void WriteToJsonFile(this ITypeCodeLocationIndexOperator _,
            string jsonFilePath,
            TypeCodeLocationIndex index,
            bool overwrite = IOHelper.DefaultOverwriteValue)
        {
            Instances.TypeCodeLocationCollectionEntryOperator.WriteToJsonFile(jsonFilePath, index.EntriesByNamespacedTypeName.Values, overwrite: overwrite);
        }

        public static void WriteToJsonFileWithoutAlphabetization(this ITypeCodeLocationIndexOperator _,
            string jsonFilePath,
            TypeCodeLocationIndex index,
            bool overwrite = IOHelper.DefaultOverwriteValue)
        {
            Instances.TypeCodeLocationCollectionEntryOperator.WriteToJsonFileWithoutAlphabetization(jsonFilePath, index.EntriesByNamespacedTypeName.Values, overwrite: overwrite);
        }
    }
}
