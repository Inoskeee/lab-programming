using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_14
{
    public class MyCollection<T>
    {
        public List<Test> list;
        public List<Test> list2;
        public MyCollection()
        {
            list = new List<Test>();
            list2 = new List<Test>();
        }
        public MyCollection(int size)
        {
            list = new List<Test>();
            list2 = new List<Test>();

            for(int i = 0; i < size; i++)
            {
                Test temp = new Test();
                list.Add(temp);
            }
            for (int i = 0; i < size; i++)
            {
                Test temp = new Test();
                list2.Add(temp);
            }
        }
    }
}
