using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3____
{
    class Derived : Found
    {
        public Derived() { }
        public Derived(string name, int cred, int deb) : base(name, cred) { debet = deb; }
        protected int debet;
        public void DerivedMethod() { Console.WriteLine("Это метод класса Derived"); }
        new public void Analysis() { base.Analysis(); Console.WriteLine("Сложный анализ"); }
        public void Analysis(int level)
        { base.Analysis(); Console.WriteLine("Анализ глубины {0}", level); }
        public override void VirtMethod() { Console.WriteLine("Сын: " + this.ToString()); }
        public override string ToString() { return (String.Format("поля: name = {0}, credit = {1},debet ={2}", name, credit, debet)); }
        public void Work()
        {
            VirtMethod();
            NonVirtMethod();
            Analysis();
        }
    }
}
