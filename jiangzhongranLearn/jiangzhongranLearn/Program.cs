using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jiangzhongranLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoEleven te = new TwoEleven();
            TwoEleven te2 = new TwoEleven();
            //te.te();
            te2.de();
        }
    }

    public class test
    {
        int a = 0;
        string b = "asdf";

        public int A
        {
            set;
            get;
        }

        public string B
        {
            set;
            get;
        }

    }

    public partial class Partialclass
    {
        public void test2() 
        {
            this.test();
            
        }
    }

    public interface IFace
    {
        void test();
    }

    public class Face : IFace
    {
        public void test()
        { }
    }
}

