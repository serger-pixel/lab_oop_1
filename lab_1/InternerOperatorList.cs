using System;
using System.Collections.Generic;
using System.Collections;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1
{
public static class IntOperLstConsts
    {
        public const int CNTGENERATE  = 10000000;
        
        public const String RANDOMSELECT = "Случайный";

        public const String SEQUENCESELECT = "Последовательный";
    }

public class InternerOperatorList: IList<IInternetOperator>
    {
        private List<IInternetOperator> _localList;

        public InternerOperatorList() 
        {
            _localList = new List<IInternetOperator>();
        }

        public int Count => _localList.Count;

        public bool IsReadOnly => false;

        public IInternetOperator this[int index]
        {
            get => _localList[index];
            set => _localList[index] = value;
        }


        public void Add(IInternetOperator item)
        {
            _localList.Add(item);
        }

        public void Clear()
        {
            _localList.Clear();
        }

        public bool Contains(IInternetOperator item)
        {
            return _localList.Contains(item);
        }

        public void CopyTo(IInternetOperator[] array, int arrayIndex)
        {
            _localList.CopyTo(array, arrayIndex);
        }

        public bool Remove(IInternetOperator item)
        {
            return _localList.Remove(item);
        }

        public int IndexOf(IInternetOperator item)
        {
            return _localList.IndexOf(item);
        }


        public void Insert(int index, IInternetOperator item)
        {
            _localList.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _localList.RemoveAt(index);
        }

        public IEnumerator<IInternetOperator> GetEnumerator()
        {
            return _localList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void del(String nameOperator)
        {
            IInternetOperator localInternetOperator = getByName(nameOperator);
            _localList.Remove(localInternetOperator);
        }

        public bool find(String nameOperator)
        {
            foreach(var i in _localList)
            {
                if (i.NameOperator.Equals(nameOperator))
                {
                    return true;
                }
            }
            return false;
        }

        public IInternetOperator getByName(String nameOperator)
        {
            IInternetOperator localOperator = null;
            for (int i = 0; i < _localList.Count; i++)
            {
                if (_localList[i].NameOperator.Equals(nameOperator))
                {
                    localOperator = _localList[i];
                    break;
                }
            }
            return localOperator;

        }

        private void generate(int ind)
        {
            String name;
            _localList.Add(new InternetOperator(InternetOperator.NAME + ind.ToString()));
        }

        public void generateOneHundThous()
        {
            for (int i = 0; i < IntOperLstConsts.CNTGENERATE; i++) 
            {
                generate(i);
            }   
        }

        public int[] test(String select)
        {
            List<IInternetOperator> local = _localList.ToList();
            _localList.Clear();
            generateOneHundThous();
            Array array = _localList.ToArray();
            int StartList;
            int EndList;
            int StartArr;
            int EndArr;
            int[] result = null;
            switch (select)
            {
                case IntOperLstConsts.SEQUENCESELECT:
                    StartList = Environment.TickCount;
                    for (int i = 0; i < IntOperLstConsts.CNTGENERATE; i++)
                    {
                        _localList[i] = null;
                    }
                    EndList =Environment.TickCount - StartList;
                    StartArr = Environment.TickCount;
                    for (int i = 0; i < IntOperLstConsts.CNTGENERATE; i++)
                    {
                        array.SetValue(null, i);
                    }
                    EndArr =Environment.TickCount - StartArr;
                    result = new int[] { EndList,  EndArr};
                    break;

                case IntOperLstConsts.RANDOMSELECT:
                    Random random = new Random();
                    StartList = Environment.TickCount;
                    int ind;
                    for (int i = 0; i < IntOperLstConsts.CNTGENERATE; i++)
                    {
                        ind = random.Next(0, array.Length);
                        while (_localList[ind] == null)
                        {
                            ind = random.Next(0, array.Length);
                        }
                        _localList[ind] = null;
                    }
                    EndList = Environment.TickCount - StartList;
                    StartArr = Environment.TickCount;
                    for (int i = 0; i < IntOperLstConsts.CNTGENERATE; i++)
                    {
                        ind = random.Next(0, array.Length);
                        while (array.GetValue(ind) == null)
                        {
                            ind = random.Next(0, array.Length);
                        }
                        array.SetValue(null, ind);
                    }
                    EndArr = Environment.TickCount - StartArr;
                    result = new int[] { EndList, EndArr };
                    break;
                default:
                    break;
            }
            _localList = local;
            return result;
        }
    }
}
