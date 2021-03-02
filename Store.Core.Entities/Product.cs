using System;
using System.Text.RegularExpressions;

namespace Store.Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public static bool IsName(string s)
        {
            if (s == null)
            {
                return false;
            }

            s = s.Replace("-", "")
                .Replace(" ", "")
                .ToUpper();

            return Regex.IsMatch(s, @"^[a-zA-Z0-9]+$");
        }
    }
}
