namespace ConsoleApp1
{
    using System;

    class Program
    {
        static void Main()
        {
            int tutum, gulle;
            bool mod;

            while (true)
            {
                try
                {
                    Console.Write("Daraq tutumunu daxil et: ");
                    tutum = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Daraqdaki gulle sayini daxil et: ");
                    gulle = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Atis modu (1 - avtomatik, 0 - tekli): ");
                    mod = Console.ReadLine() == "1";
                    break;
                }
                catch
                {
                    Console.WriteLine("Yanlis daxil etdiniz, yeniden cehd edin.");
                }
            }

            Weapon weapon = new Weapon(tutum, gulle, mod);

            while (true)
            {
                Console.Write("\n0-Info, 1-Shoot, 2-GetRemainBulletCount, 3-Reload, 4-ChangeFireMode, 5-Exit: ");
                string secim = Console.ReadLine();

                if (secim == "0")
                {
                    Console.WriteLine("0 - İnformasiya almaq üçün\n1 - Shoot metodu üçün\n2 - GetRemainBulletCount metodu üçün\n3 - Reload metodu üçün\n4 - ChangeFireMode metodu üçün\n5 - Proqramdan çıxmaq üçün");
                }
                else if (secim == "1")
                {
                    weapon.Shoot();
                }
                else if (secim == "2")
                {
                    Console.WriteLine("Tam dolmasi ucun lazim olan gulle: " + weapon.GetRemainBulletCount());
                }
                else if (secim == "3")
                {
                    weapon.Reload();
                }
                else if (secim == "4")
                {
                    weapon.ChangeFireMode();
                }
                else if (secim == "5")
                {
                    Console.WriteLine("Proqram dayandirildi.");
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlis secim, yeniden cehd edin.");
                }
            }
        }
    }


}