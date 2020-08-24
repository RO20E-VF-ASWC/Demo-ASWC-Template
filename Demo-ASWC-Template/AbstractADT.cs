using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_ASWC_Template
{
    public abstract class AbstractADT
    {
        private ICollection<String> _myList;

        public AbstractADT()
        {
            _myList = CreateList();
        }

        // Template metode
        protected abstract ICollection<string> CreateList();

        public void Add(string item)
        {
            _myList.Add(item);
        }

        public void Clear()
        {
            _myList.Clear();
        }

        public bool Remove(string item)
        {
            return _myList.Remove(item);
        }

        public int Count => _myList.Count;

        public override string ToString()
        {
            string str = "[" + String.Join(",", _myList) + "]";
            return $"{nameof(_myList)}: {str}";
        }
    }
}
