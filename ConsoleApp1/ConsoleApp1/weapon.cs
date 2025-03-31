using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Weapon
    {
        int daraqTutumu;
        int gulleSayi;
        bool avtomatikAtis;

        public Weapon(int tutum, int gulle, bool mod)
        {
            if (tutum <= 0)
            {
                tutum = 10;
                Console.WriteLine("Daraq tutumu sehv daxil edildi, 10 olaraq teyin edildi.");
            }

            if (gulle < 0 || gulle > tutum)
            {
                gulle = tutum;
                Console.WriteLine("Gulle sayi sehv daxil edildi, daraq tam dolduruldu.");
            }

            daraqTutumu = tutum;
            gulleSayi = gulle;
            avtomatikAtis = mod;
        }

        public void Shoot()
        {
            if (gulleSayi == 0)
            {
                Console.WriteLine("Daraq bosdur!");
                return;
            }

            if (avtomatikAtis)
            {
                Console.WriteLine(gulleSayi + " gulle atildi!");
                gulleSayi = 0;
            }
            else
            {
                Console.WriteLine("1 gulle atildi!");
                gulleSayi--;
            }
        }

        public int GetRemainBulletCount()
        {
            return daraqTutumu - gulleSayi;
        }

        public void Reload()
        {
            gulleSayi = daraqTutumu;
            Console.WriteLine("Daraq tam dolduruldu! Gulle sayi: " + gulleSayi);
        }

        public void ChangeFireMode()
        {
            avtomatikAtis = !avtomatikAtis;
            Console.WriteLine(avtomatikAtis ? "Atis modu: Avtomatik" : "Atis modu: Tekli");
        }
    }

}
