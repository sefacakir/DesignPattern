using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir bilgisayar almak isteyen müşterinin istekleri doğrultusunda Ssd ram ve monitör seçeneklerinden hangisini isterse verilecek bir program
            TechnicalService technicalService = new TechnicalService();

            IComputer computer1 = new GoldPc();
            IComputer computer2 = new SilverPc();

            technicalService.CreateComputer(computer1);
            technicalService.CreateComputer(computer2);

            computer1.Show();
            computer2.Show();
        }
    }
}
