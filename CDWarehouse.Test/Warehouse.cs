using System.Collections.Generic;

namespace CDWarehouse.Test
{
    internal class Warehouse
    {
        public List<Title> Titles { get; set; }

        public Warehouse()
        {
            Titles = new List<Title>();
        }

        public void Stock(Title title)
        {
            Titles.Add(title);
        }
    }
}