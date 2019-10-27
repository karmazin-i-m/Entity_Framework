using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DB db = new DB();

            MyClass1 myClass11 = new MyClass1("MyClass11");
            MyClass1 myClass12 = new MyClass1("MyClass12");
            MyClass1 myClass13 = new MyClass1("MyClass13");

            MyClass2 myClass21 = new MyClass2("MyClass21");
            MyClass2 myClass22 = new MyClass2("MyClass22");
            MyClass2 myClass23 = new MyClass2("MyClass23");

            MyClass3 myClass31 = new MyClass3("MyClass31");
            MyClass3 myClass32 = new MyClass3("MyClass32");
            MyClass3 myClass33 = new MyClass3("MyClass33");

            myClass11.myClass2s.Add(myClass22);
            myClass11.myClass2s.Add(myClass23);
            myClass11.myClass3s.Add(myClass31);
            myClass11.myClass3s.Add(myClass32);

            myClass22.myClass1s.Add(myClass11);
            myClass22.myClass1s.Add(myClass13);
            myClass22.myClass3s.Add(myClass31);
            myClass22.myClass3s.Add(myClass33);

            myClass33.myClass1s.Add(myClass11);
            myClass33.myClass1s.Add(myClass13);
            myClass33.myClass2s.Add(myClass22);
            myClass33.myClass2s.Add(myClass23);

            db.MyClass1s.AddRange(new List<MyClass1>() { myClass11, myClass12, myClass13 });
            db.MyClass2s.AddRange(new List<MyClass2>() { myClass21, myClass22, myClass23 });
            db.MyClass3s.AddRange(new List<MyClass3>() { myClass31, myClass32, myClass33 });

            db.SaveChanges();
        }
    }

    public class MyClass1
    {
        public int ID { get; set; }
        public String Name { get; set; }

        public ICollection<MyClass2> myClass2s { get; set; }
        public ICollection<MyClass3> myClass3s { get; set; }

        public MyClass1()
        {
            myClass2s = new List<MyClass2>();
            myClass3s = new List<MyClass3>();
        }

        public MyClass1(String name)
            :this()
        {
            this.Name = name;
        }
    }

    public class MyClass2
    {
        public int ID { get; set; }
        public String Name { get; set; }

        public ICollection<MyClass1> myClass1s { get; set; }
        public ICollection<MyClass3> myClass3s { get; set; }

        public MyClass2()
        {
            myClass1s = new List<MyClass1>();
            myClass3s = new List<MyClass3>();
        }

        public MyClass2(String name)
            :this()
        {
            this.Name = name;
        }
    }

    public class MyClass3
    {
        public int ID { get; set; }
        public String Name { get; set; }

        public ICollection<MyClass1> myClass1s { get; set; }
        public ICollection<MyClass2> myClass2s { get; set; }

        public MyClass3()
        {
            myClass1s = new List<MyClass1>();
            myClass2s = new List<MyClass2>();
        }

        public MyClass3(String name)
            :this()
        {
            this.Name = name;
        }
    }
}
