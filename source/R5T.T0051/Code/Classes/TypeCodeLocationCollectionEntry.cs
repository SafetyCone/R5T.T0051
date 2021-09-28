using System;

using R5T.T0049;
using R5T.T0050;


namespace R5T.T0051
{
    public class TypeCodeLocationCollectionEntry
    {
        public NamespacedTypeName NamespacedTypeName { get; set; }
        public CSharpCodeFilePath CodeFilePath { get; set; }


        public override string ToString()
        {
            var representation = $"{this.NamespacedTypeName}: {this.CodeFilePath}";
            return representation;
        }
    }
}
