using System;
using System.Collections.Generic;
using System.Text;

namespace task4
{
    public class TreeElement
    {
        public TreeElement LeftElement { get; set; }
        public TreeElement RightElement { get; set; }
        public TreeElement ParentElement { get; set; }
        public int Value { get; set; }
        public int Count { get; set; }
    }
}
