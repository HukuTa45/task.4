namespace task4
{
    public class Tree
    {
        private TreeElement _firsTreeElement;

        public void AddTreeElement(int value)
        {
            if (_firsTreeElement == null)
                _firsTreeElement = new TreeElement
                {
                    Value = value,
                    Count = 1
                };
            else _AddTreeElement(_firsTreeElement, value);
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
                    current.RightElement = new TreeElement
                    {
                        Value = value,
                        Count = 1
                    };
            }
            else
            {
                if (current.LeftElement != null)
                    _AddTreeElement(current.LeftElement, value);
                else
                    current.LeftElement = new TreeElement
                    {
                        Value = value,
                        Count = 1
                    };
            }
        }

        public bool FindElement(int value, out int outCount) 
            => _FindElement(_firsTreeElement, value, out outCount);
        


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
    }
}