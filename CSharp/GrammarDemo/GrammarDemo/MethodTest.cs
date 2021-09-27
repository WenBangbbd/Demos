using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrammarDemo
{
  
    public class ParentWithVir
    {
        public virtual void VirtualMethod()
        {
            Console.WriteLine("我是父类，virtual方法");
        }
        public void NormalMethod()
        {
            Console.WriteLine("我是父类，normal方法");
        }
    }
    public class Children:ParentWithVir
    {
        public override void VirtualMethod()
        {
            Console.WriteLine("我是子类，override方法");
            Console.WriteLine("我是子类，我使用base调用父类方法");
            base.VirtualMethod();
        }

        public new void NormalMethod()
        {
            Console.WriteLine("我是子类，Normal方法,new方法");
        }
    }

    public static class MethodTest
    {
        public static void Run()
        {
            Console.WriteLine("我是父类引用调用结果----------------");
            ParentWithVir vir = new Children();
            vir.NormalMethod();
            vir.VirtualMethod();
            Console.WriteLine("我是子类引用调用结果--------------");
            var chi = new Children();
            chi.NormalMethod();
            chi.VirtualMethod();
        }
    }
}
