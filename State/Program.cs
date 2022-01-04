using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.Buy("Apple");

            // output:
            //  InitializeState: Ön hazırlıklar yapılıyor.
            //  WaitingState: Otomata herhangi bir aksiyon bekliyor.
            //  PreparingState: İstenilen ürün hazırlanıyor.Lütfen bekleyiniz
            //  DeliveryState: Ürün teslim ediliyor.
            //  WaitingState: Otomata herhangi bir aksiyon bekliyor.
        }
    }

    abstract class OrderState
    {
        public abstract void Handle(Order context);
    }
    class Order
    {
        OrderState _state;
        public Order()
        {
            SetState(new InitializeState());
        }
        public void Buy(string product)
        {
            SetState(new PreparingState());
        }
        public void SetState(OrderState state)
        {
            _state = state;
            _state.Handle(this);
        }

    }
    class InitializeState : OrderState
    {
        public override void Handle(Order context)
        {
            Console.WriteLine("Initialize State: Preliminary preparations are completed.");
            context.SetState(new WaitingState());
        }
    }
    class WaitingState : OrderState
    {
        public override void Handle(Order context)
        {
            Console.WriteLine("Waiting State : Pending");
        }
    }
    class PreparingState : OrderState
    {
        public override void Handle(Order context)
        {
            Console.WriteLine("Preparing State: Your order is preparing");
            context.SetState(new DeliveryState());
        }
    }
    class DeliveryState : OrderState
    {
        public override void Handle(Order context)
        {
            Console.WriteLine("Delivery State: Order delivered");
            context.SetState(new WaitingState());
        }
    }
}
