using System;

using R5T.T0049;
using R5T.T0050;
using R5T.T0051;

using Instances = R5T.T0051.Instances;


namespace System
{
    public static partial class ITypeCodeLocationCollectionEntryOperatorExtensions
    {
        public static string Describe(this ITypeCodeLocationCollectionEntryOperator _,
            TypeCodeLocationCollectionEntry entry)
        {
            var typeName = Instances.NamespacedTypeName.GetTypeName(entry.NamespacedTypeName);
            var namespaceName = Instances.NamespacedTypeName.GetNamespaceName(entry.NamespacedTypeName);

            var description = $"{typeName}: {namespaceName}\n{entry.CodeFilePath}";
            return description;
        }

        public static bool Equal(this ITypeCodeLocationCollectionEntryOperator _,
            TypeCodeLocationCollectionEntry a,
            TypeCodeLocationCollectionEntry b)
        {
            var output = EqualityHelper.NullHandling(a, b,
                _.EqualPropertyValues);

            return output;
        }

        public static bool EqualPropertyValues(this ITypeCodeLocationCollectionEntryOperator _,
            TypeCodeLocationCollectionEntry a,
            TypeCodeLocationCollectionEntry b)
        {
            var output = true
                && a.CodeFilePath == b.CodeFilePath
                && a.NamespacedTypeName == b.NamespacedTypeName
                ;

            return output;
        }
    }
}
