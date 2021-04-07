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
            else AddValue(_firsTreeElement, value);

        }

        public void AddValue(TreeElement current, int value)
        {
            if (current.Value == value)
            {
                current.Count++;
                return;
            }

            if (value> current.Value)
            {
                if (current.RightElement != null)
                {
                    AddValue(current.RightElement, value);
                }
                else
                {
                    current.RightElement = new TreeElement
                    {
                        Value = value,
                        Count = 1,
                        ParentElement = current
                    };
                }
            }
            else
            {
                if (current.LeftElement != null)
                {
                    AddValue(current.LeftElement, value);
                }
                else
                {
                    current.LeftElement = new TreeElement
                    {
                        Value = value,
                        Count = 1,
                        ParentElement = current
                    };
                }
            }

           
        }
        public string FindElement(int value)
		{
            return SearchElement(_firsTreeElement ,value);
		}
        public string SearchElement(TreeElement current,int value)
        {
            if (current.Value == value)
            {
                return current.Count.ToString();
            }

            if (value > current.Value)
            {
                if (current.RightElement != null)
                {
                   return SearchElement(current.RightElement, value);
                }             
            }
            else
            {
                if (current.LeftElement != null)
                {
                   return SearchElement(current.LeftElement, value);
                }
            }
           return "Элемент не найден!";
        }
    }
}

