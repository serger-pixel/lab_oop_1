using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_oop_1
{
    internal class InternerOperatorList
    {
        private List<InternetOperator> _localList;

        public InternerOperatorList() 
        {
            _localList = new List<InternetOperator>();
        }

        public void add(InternetOperator internetOperator)
        {
            _localList.Add(internetOperator);
        }

        public bool find(String nameOperator)
        {
            foreach(var i in _localList)
            {
                if (i.getNameOperator().Equals(nameOperator))
                {
                    return true;
                }
            }
            return false;
        }

        public InternetOperator getByName(String nameOperator)
        {
            InternetOperator localOperator = null;
            for (int i = 0; i < _localList.Count; i++)
            {
                if (_localList[i].getNameOperator().Equals(nameOperator))
                {
                    localOperator = _localList[i];
                    break;
                }
            }
            return localOperator;

        }
    }
}
