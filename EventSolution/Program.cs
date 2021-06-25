using System;

namespace EventSolution
{
    public class A
    {
        public B b;

        public void Run()
        {
            Console.WriteLine("Operation ran.");

            b = new B();
            b.WaterBoiledEvent += WaterBoiledEventHandler;
            b.MakeCoffee();
        }

        public void CallFriends()
        {
            Console.WriteLine("Friends called.");
        }

        public void WaterBoiledEventHandler(object sender, EventArgs e)
        {
            CallFriends();
        }
    }

    public class B
    {
        public event EventHandler WaterBoiledEvent;

        protected virtual void OnWaterBoiled(EventArgs e)
        {
            WaterBoiledEvent?.Invoke(this, e);
        }

        public void MakeCoffee()
        {
            WaterBoiled();
        }

        protected void WaterBoiled()
        {
            Console.WriteLine("Water boiled.");
            OnWaterBoiled(EventArgs.Empty);
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
