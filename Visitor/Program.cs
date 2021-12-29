using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Tablet appleTablet = new AppleTablet("IPad","Apple");
            Tablet androidTablet = new SamsungTablet("NotePad", "Samsung");

            ITabletFeatureVisitor wifi = new WifiVisitor();
            ITabletFeatureVisitor nfc = new NFCVisitor();

            appleTablet.Accept(wifi);
            androidTablet.Accept(nfc);
        }
    }

    abstract class Tablet
    {
        public string _name;
        public string _brand;
        public Tablet(string name, string brand)
        {
            _name = name;
            _brand = brand;
        }
        public abstract void Accept(ITabletFeatureVisitor visitor);
    }

    class SamsungTablet : Tablet
    {
        public SamsungTablet(string name, string brand):base(name,brand)
        {

        }
        public override void Accept(ITabletFeatureVisitor visitor)
        {
            visitor.FeautureVisit(this);
        }
    }

    class AppleTablet : Tablet
    {
        public AppleTablet(string name, string brand):base(name,brand)
        {

        }
        public override void Accept(ITabletFeatureVisitor visitor)
        {
            visitor.FeatureVisit(this);
        }
    }

    interface ITabletFeatureVisitor
    {
        void FeautureVisit(SamsungTablet tablet);
        void FeatureVisit(AppleTablet tablet);
    }

    class WifiVisitor : ITabletFeatureVisitor
    {
        public void FeatureVisit(AppleTablet tablet)
        {
            Console.WriteLine("{0}: Wifi feature has been activated.",tablet._name);
        }

        public void FeautureVisit(SamsungTablet tablet)
        {
            Console.WriteLine("{0}: Wifi feature has been activated.",tablet._name);
        }
    }

    class NFCVisitor : ITabletFeatureVisitor
    {
        public void FeatureVisit(AppleTablet tablet)
        {
            Console.WriteLine("{0}: NFC feature has been activated.",tablet._name);
        }

        public void FeautureVisit(SamsungTablet tablet)
        {
            Console.WriteLine("{0}: NFC feature has been activated.", tablet._name);
        }
    }
}
