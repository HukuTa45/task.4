namespace task4
{
    public class Tree
    {
        private TreeElement _firstTreeElement;

        public void AddTreeElement(int value)
        {
            if (_firstTreeElement == null)
                _firstTreeElement = new TreeElement
                {
                    Value = value,
                    Count = 1
                };
            else AddTreeElement(_firstTreeElement, value);
        }

        private void AddTreeElement(TreeElement current, int value)
        {
            if (current.Value == value)
            {
                current.Count++;
                return;
            }

            if (value > current.Value)
            {
                if (current.RightElement != null)
                    AddTreeElement(current.RightElement, value);
                else
                    current.RightElement = AddNewElement(value);
            }
            else
            {
                if (current.LeftElement != null)
                    AddTreeElement(current.LeftElement, value);
                else
                    current.LeftElement = AddNewElement(value);
            }
        }

        public bool FindElement(int value, out int outCount)
        {
            if (_firstTreeElement == null)
            {
                outCount = 0;
                return false;
            }
            return FindElement(_firstTreeElement, value, out outCount);
        }

        private bool FindElement(TreeElement current, int value, out int outCount)
        {
            
            if (current.Value == value)
            {
                outCount = current.Count;
                return true;
            }

            if (value > current.Value)
            {
                if (current.RightElement != null) return FindElement(current.RightElement, value, out outCount);
            }
            else
            {
                if (current.LeftElement != null) return FindElement(current.LeftElement, value, out outCount);
            }

            outCount = 0;
            return false;
        }

        private TreeElement AddNewElement(int value)
        {
            var element = new TreeElement
            {
                Value = value,
                Count = 1
            };
            return element;
        }
    }
}