using System.Collections.Generic;

namespace Observer
{
    abstract class AbstractProduct
    {
        List<IUser> users = new List<IUser>();
        string _name;
        int _price;
        public AbstractProduct(string name, int price)
        {
            _name = name;
            _price = price;
        }
        public void AddObserver(IUser user)
        {
            users.Add(user);
        }

        public void SetPrice(int newPrice)
        {
            if (_price > newPrice)
            {
                _price = newPrice;
                Notify();
            }
        }
        public void Notify()
        {
            foreach (var user in users)
            {
                user.Notify(_price,_name);
            }
        }
    }
}
