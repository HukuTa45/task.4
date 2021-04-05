using System;
using System.Collections.Generic;
using System.Text;

namespace task4
{
    public class Tree
    {
        private TreeElement _firsTreeElement;
        

        public Tree()
        { 
            firstElement = true;
        }

        public bool firstElement { get; set; }

        public void AddTreeElement(int value)
        {
            if (!CheckValue(_firsTreeElement, value))
            {
                if (firstElement)
                {
                    _firsTreeElement = new TreeElement
                    {
                        Value = value,
                        Count = 1,
                        ParentElement = null,
                    };
                    firstElement = false;
                }

                var newElement = new TreeElement
                {
                    Value = value,
                    Count = 1,
                    ParentElement = AddValue(_firsTreeElement, value).ParentElement
                };
            }

        }

        public bool CheckValue(TreeElement currentElement,int value)
        {
            if (currentElement.Value == value)
            {
               currentElement.Count++;
               return true;
            } 
            
            if (currentElement != null)
            {
                CheckValue(currentElement.LeftElement,value);
                CheckValue(currentElement.RightElement,value);
            }

            return false;

        }

        public TreeElement AddValue(TreeElement current,int value)
        {
            
            if (current != null)
            {
                if (current.Value > value)
                    AddValue(current = current.RightElement, value);
                else
                    AddValue(current = current.LeftElement, value);
            }

            return current;

        }

        public int GetCount(TreeElement element)
        {
            return element.Count;
        }
    }
}
