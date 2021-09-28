using System;

using R5T.T0049;
using R5T.T0050;
using R5T.T0051;


namespace System
{
    public static partial class ITypeCodeLocationCollectionEntryOperatorExtensions
    {
        public static TypeCodeLocationCollectionEntry From(this ITypeCodeLocationCollectionEntryOperator _,
            string namespacedTypeName,
            string cSharpCodeFilePath)
        {
            var output = _.From(
                NamespacedTypeName.From(namespacedTypeName),
                CSharpCodeFilePath.From(cSharpCodeFilePath));

            return output;
        }

        public static TypeCodeLocationCollectionEntry From(this ITypeCodeLocationCollectionEntryOperator _,
            NamespacedTypeName namespacedTypeName,
            CSharpCodeFilePath cSharpCodeFilePath)
        {
            var output = new TypeCodeLocationCollectionEntry
            {
                CodeFilePath = cSharpCodeFilePath,
                NamespacedTypeName = namespacedTypeName,
            };

            return output;
        }

        public static TypeCodeLocationCollectionEntry New(this ITypeCodeLocationCollectionEntryOperator _)
        {
            var output = new TypeCodeLocationCollectionEntry();
            return output;
        }
    }
}
