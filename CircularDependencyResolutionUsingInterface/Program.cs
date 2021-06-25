using System;

namespace InterfaceSolution
{
    public interface IConsumer
    {
        void CallFriends();
    }

    public class A : IConsumer
    {
        public B b;

        public void Run()
        {
            Console.WriteLine("Operation ran.");

            b = new B();
            b.MakeCoffee(this);
        }

        public void CallFriends()
        {
            Console.WriteLine("Friends called.");
        }
    }

    public class B
    {
        public void MakeCoffee(IConsumer me)
        {
            me.CallFriends();
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            A a = new A();
            B b = new B();

            a.Run();
        }
    }
}
