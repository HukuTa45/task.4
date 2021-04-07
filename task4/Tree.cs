using System;
using System.Collections.Generic;
using System.Text;

namespace task4
{
    public class Tree
    {
        private TreeElement _firsTreeElement;
        private bool _isFirstElement;

        public Tree()
        {
            _isFirstElement = true;
        }

        

        public void AddTreeElement(int value)
        {

            if (_isFirstElement)
            {
                _firsTreeElement = new TreeElement
                {
                    Value = value,
                    Count = 1,
                    ParentElement = null,
                };
                _isFirstElement = false;
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
        public bool FindElement(int value, out int outCount)
		{
            return SearchElement(_firsTreeElement ,value, out outCount);
		}
        public bool SearchElement(TreeElement current,int value, out int outCount)
        {
            if (current.Value == value)
            {
                outCount = current.Count;
                return true;
            }

            if (value > current.Value)
            {
                if (current.RightElement != null)
                {                  
                    return SearchElement(current.RightElement, value,out outCount);
                }             
            }
            else
            {
                if (current.LeftElement != null)
                {                    
                    return SearchElement(current.LeftElement, value,out outCount);
                }
            }
            outCount = 0;
           return false;
        }
    }
}

