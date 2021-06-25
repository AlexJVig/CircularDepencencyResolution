using System;

namespace InterfaceSolution
{
    interface IConsumer
    {
        public void CallFriends();
    }

    class A
    {
        public void MakeCoffee(IConsumer me)
        {
            me.CallFriends();
        }
    }

    class B : IConsumer
    {
        public void CallFriends()
        {
            Console.WriteLine("Friends called.");
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
