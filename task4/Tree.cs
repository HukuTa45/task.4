using System.Data;

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
            else _AddTreeElement(_firstTreeElement, value);
        }

        private void _AddTreeElement(TreeElement current, int value)
        {
            if (current.Value == value)
            {
                current.Count++;
                return;
            }

            if (value > current.Value)
            {
                if (current.RightElement != null)
                    _AddTreeElement(current.RightElement, value);
                else
                    current.RightElement = _AddNewElement(value);
            }
            else
            {
                if (current.LeftElement != null)
                    _AddTreeElement(current.LeftElement, value);
                else
                    current.LeftElement = _AddNewElement(value);
            }
        }

        public bool FindElement(int value, out int outCount) 
            => _FindElement(_firstTreeElement, value, out outCount);
        
        private bool _FindElement(TreeElement current, int value, out int outCount)
        {
            if (current.Value == value)
            {
                outCount = current.Count;
                return true;
            }

            if (value > current.Value)
            {
                if (current.RightElement != null) return _FindElement(current.RightElement, value, out outCount);
            }
            else
            {
                if (current.LeftElement != null) return _FindElement(current.LeftElement, value, out outCount);
            }

            outCount = 0;
            return false;
        }

        private TreeElement _AddNewElement(int value)
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