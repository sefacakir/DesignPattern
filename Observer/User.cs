using System;

namespace Observer
{
    class User : IUser
    {
        string _userName;
        public User(string userName)
        {
            _userName = userName;
        }

        public void Notify(int price,string name)
        {
            Console.WriteLine("Dear " + _userName + " The price of the "+name+" has dropped. New Price: " + price);
        }
    }
}
