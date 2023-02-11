using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using R5T.Magyar;
using R5T.Newport;

using R5T.T0051;

using SerializationType = R5T.T0051.X002.TypeCodeLocationCollectionEntry;


namespace System
{
    public static class ITypeCodeLocationCollectionEntryOperatorExtensions
    {
        public static TypeCodeLocationCollectionEntry[] LoadFromJsonFile(this ITypeCodeLocationCollectionEntryOperator _,
            string jsonFilePath)
        {
            var serializationEntries = JsonFileHelper.LoadFromFile<SerializationType[]>(jsonFilePath);

            var output = serializationEntries
                .Select(xSerializationEntry => xSerializationEntry.ToApplicationType())
                .ToArray();

            return output;
        }

        public static void WriteToJsonFile(this ITypeCodeLocationCollectionEntryOperator _,
            string jsonFilePath,
            IEnumerable<TypeCodeLocationCollectionEntry> entries,
            bool overwrite = IOHelper.DefaultOverwriteValue)
        {
            var alphabetizedEntries = entries
                .OrderAlphabetically(xEntry => xEntry.NamespacedTypeName.Value)
                ;

            _.WriteToJsonFileWithoutAlphabetization(jsonFilePath, alphabetizedEntries, overwrite);
        }

        public static void WriteToJsonFileWithoutAlphabetization(this ITypeCodeLocationCollectionEntryOperator _,
            string jsonFilePath,
            IEnumerable<TypeCodeLocationCollectionEntry> entries,
            bool overwrite = IOHelper.DefaultOverwriteValue)
        {
            var serializationEntries = entries
                .Select(xEntry => xEntry.ToSerializationType())
                ;

            JsonFileHelper.WriteToFile(jsonFilePath, serializationEntries, overwrite: overwrite);
        }
    }
}
