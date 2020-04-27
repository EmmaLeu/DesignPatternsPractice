using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class ComplexObject
    {
        private const char PartsSeparator = ',';

        private readonly ICollection<IProduct> _children = new List<IProduct>();

        public void Add(IProduct child)
        {
            _children.Add(child);
        }

        public string GetParts()
        {
            var parts = new StringBuilder();

            foreach(var item in _children)
            {
                if(parts.Length != 0)
                {
                    parts.Append(PartsSeparator);
                }

                parts.Append(item.GetName());
            }

            return parts.ToString();
        }
    }
}
