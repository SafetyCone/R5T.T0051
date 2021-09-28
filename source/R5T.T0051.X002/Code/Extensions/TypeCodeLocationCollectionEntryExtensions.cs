using System;

using Instances = R5T.T0051.X002.Instances;

using ApplicationType = R5T.T0051.TypeCodeLocationCollectionEntry;
using SerializationType = R5T.T0051.X002.TypeCodeLocationCollectionEntry;


namespace System
{
    public static class TypeCodeLocationCollectionEntryExtensions
    {
        public static ApplicationType ToApplicationType(this SerializationType serializationType)
        {
            var output = Instances.TypeCodeLocationCollectionEntryOperator.From(
                serializationType.NamespacedTypeName,
                serializationType.CodeFilePath);

            return output;
        }

        public static SerializationType ToSerializationType(this ApplicationType applicationType)
        {
            var output = new SerializationType
            {
                CodeFilePath = applicationType.CodeFilePath,
                NamespacedTypeName = applicationType.NamespacedTypeName,
            };

            return output;
        }
    }
}
