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
        public const int CNTGENERATE = 100000;

        public const int RANDOMSELECT = 1;

        public const int SEQUENCESELECT = 2;
    }

public class InternerOperatorList: IList<InternetOperator>
    {
        private List<InternetOperator> _localList;

        public InternerOperatorList() 
        {
            _localList = new List<InternetOperator>();
        }

        public int Count => _localList.Count;

        public bool IsReadOnly => false;

        public InternetOperator this[int index]
        {
            get => _localList[index];
            set => _localList[index] = value;
        }


        public void Add(InternetOperator item)
        {
            _localList.Add(item);
        }

        public void Clear()
        {
            _localList.Clear();
        }

        public bool Contains(InternetOperator item)
        {
            return _localList.Contains(item);
        }

        public void CopyTo(InternetOperator[] array, int arrayIndex)
        {
            _localList.CopyTo(array, arrayIndex);
        }

        public bool Remove(InternetOperator item)
        {
            return _localList.Remove(item);
        }

        public int IndexOf(InternetOperator item)
        {
            return _localList.IndexOf(item);
        }


        public void Insert(int index, InternetOperator item)
        {
            _localList.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _localList.RemoveAt(index);
        }

        public IEnumerator<InternetOperator> GetEnumerator()
        {
            return _localList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void del(String nameOperator)
        {
            InternetOperator localInternetOperator = getByName(nameOperator);
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

        public InternetOperator getByName(String nameOperator)
        {
            InternetOperator localOperator = null;
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

        private void generate()
        {
            String name;
            Random random = new Random();
            InternetOperator localOperator;
            do
            {
                name = "";
                name += IntOperConsts.UPKEYS[random.Next(0, IntOperConsts.UPKEYS.Length - 1)];
                name += IntOperConsts.DOWNKEYS[random.Next(0, IntOperConsts.UPKEYS.Length - 1)];
                name += IntOperConsts.DOWNKEYS[random.Next(0, IntOperConsts.UPKEYS.Length - 1)];
                name += IntOperConsts.DOWNKEYS[random.Next(0, IntOperConsts.UPKEYS.Length - 1)];
            }
            while (_localList.Contains(new InternetOperator(name)));
            _localList.Add(new InternetOperator(name));
        }

        public void generateOneHundThous()
        {
            for (int i = 0; i < IntOperLstConsts.CNTGENERATE; i++) 
            {
                generate();
            }   
        }

        public int[] test(int select)
        {
            List<InternetOperator> local = _localList.ToList();
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
                        _localList.RemoveAt(0);
                    }
                    EndList =Environment.TickCount - StartList;
                    StartArr = Environment.TickCount;
                    for (int i = 0; i < IntOperLstConsts.CNTGENERATE; i++)
                    {
                        array.SetValue(null, i);
                    }
                    EndArr =Environment.TickCount - StartArr;
                    result = new int[] { EndList, EndList };
                    break;

                case IntOperLstConsts.RANDOMSELECT:
                    Random random = new Random();
                    StartList = Environment.TickCount;
                    for (int i = 0; i < IntOperLstConsts.CNTGENERATE; i++)
                    {
                        _localList.RemoveAt(random.Next(0, _localList.Count));
                    }
                    EndList = Environment.TickCount - StartList;
                    int ind;
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
                    result = new int[] { EndList, EndList };
                    break;
                default:
                    break;
            }
            _localList = local;
            return result;
        }
    }
}
