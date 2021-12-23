namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            IUser sefa = new User("İdris Sefa Çakır");
            IUser ahmet = new User("Ahmet Kartal");
            AbstractProduct car = new Product("Car", 100000);
            AbstractProduct phone = new Product("Phone", 5000);

            car.AddObserver(ahmet);
            car.AddObserver(sefa);
            car.SetPrice(90000);

            phone.AddObserver(sefa);
            phone.SetPrice(4500);

        }
    }
}
