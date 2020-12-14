using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Linq;
using System.IO;
using System.Reflection;

namespace classmates.ObjectClasses
{
    [Serializable]
    class Classmates
    {
        private string name;
        private int age;
        private int length;
        private string city;
        private string hobbie;
        private string favouriteFood;
        private string favouriteBeverage;
        private string favouriteBand;
        private int noOfChildren;
        private string programingMotivation;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Length { get => length; set => length = value; }
        public string City { get => city; set => city = value; }
        public string Hobbie { get => hobbie; set => hobbie = value; }
        public string FavouriteFood { get => favouriteFood; set => favouriteFood = value; }
        public string FavouriteBeverage { get => favouriteBeverage; set => favouriteBeverage = value; }
        public string FavouriteBand { get => favouriteBand; set => favouriteBand = value; }
        public int NoOfChildren { get => noOfChildren; set => noOfChildren = value; }
        public string ProgramingMotivation { get => programingMotivation; set => programingMotivation = value; }

        public Classmates(
            string name, 
            int age, 
            int length, 
            string city, 
            string hobbie, 
            string favouriteFood, 
            string favouriteBeverage,
            string favouriteBand,
            int noOfChildren,
            string programingMotivation)
        {

            this.Name = name;
            this.Age = age;
            this.Length = length;
            this.City = city;
            this.Hobbie = hobbie;
            this.FavouriteFood = favouriteFood;
            this.FavouriteBeverage = favouriteBeverage;
            this.FavouriteBand = favouriteBand;
            this.NoOfChildren = noOfChildren;
            this.ProgramingMotivation = programingMotivation;

        }

        public static void Populate(List<Classmates> myClassmates)
        {

            Console.Clear();
            myClassmates.Add(new Classmates("Tobias Binett",
                31,
                192,
                "Hudiksvall",
                "Träning, Musik, Spel, Familjen",
                "Kött",
                "Öl",
                "The Black Dahlia Murder",
                2,
                "Att kunna skapa något användbart för mig själv och andra och att ha möjligheten att arbeta med det."));

            myClassmates.Add(new Classmates("Benny Christensen",
                38,
                194,
                "Brunflo",
                "Datorspel, Fiske, Programmering, Landsvägscykling",
                "Älgkebab",
                "Coca Cola",
                "Foo Fighters",
                2,
                "Att kunna skapa något från grunden och lösa problem med det jag skapat. Att sedan kunna använda detta till att tjäna hutlösa summor pengar är ju i sig ytterligare en morot."));

            myClassmates.Add(new Classmates("Håkan Eriksson",
                44,
                187,
                "Uppsala",
                "Moto-X, Sporthojar, Online gaming",
                "Shish kebab",
                "Loka Citron",
                "Disturbed",
                0,
                "Social engineering, datasäkerhet, pentesting."));
            myClassmates.Add(new Classmates("Nicklas Eriksson",
                26,
                175,
                "Umeå",
                "Skidor, cykel, simma, springa, fjällvandring, klättring och dataspel",
                "Gröt med jordnötssmör",
                "Whisky",
                "Falling in Reverse och Self Deception",
                0,
                "Drivet kommer från att man får vara kreativ och en problemlösare på samma gång. Sen så drivs man såklart av att få testa på en annan karriär än den man har haft tidigare."));

            myClassmates.Add(new Classmates("Tina Eriksson",
                30,
                165,
                "Brunflo/Östersund",
                "Spela TV-spel.",
                "Potatis & Purjolöksoppa",
                "Kaffe",
                "Avicii",
                2,
                "Få ett bra jobb."));

            myClassmates.Add(new Classmates("Fredrik Hoffmann",
                28,
                192,
                "Östersund, Odensala",
                "musik, socialisera, film,serier, automation och skriptning, programmering, testa nytt, äta ute, whiskykväll och öl",
                "Entrecote med rotfrukter och vitlökssmör",
                "Trocadero Zero, Ardbeg och Budvar",
                "Armin Van Buuren (annars progressive trance, house, trance, electronic, progressive house, rock, metal, heavy metal)",
                0,
                "Möjlighet till karriärutveckling."));
            myClassmates.Add(new Classmates("Dennis Lindquist",
                32,
                182,
                "Älvdalen",
                "Gitarr/Musik",
                "Friterad kyckling",
                "Öl",
                "Metallica",
                1,
                "Att få skapa och kunna vara kreativ. Men även att få göra ett byte av karriär."));

            myClassmates.Add(new Classmates("Josefine Rönnqvist",
                34,
                164,
                "Gideå",
                "Sy, pussla, umgås",
                "Frukt",
                "Vatten",
                "Halsbandet",
                2,
                "Personlig utveckling och karriärbyte."));

            myClassmates.Add(new Classmates("Mattias Vikström",
                33,
                187,
                "Umeå",
                "Fiske, matlagning",
                "Cowboysoppa",
                "Gin och Tonic",
                "Infected Mushroom",
                0,
                "Personlig utveckling och kreativitet."));

            myClassmates.Add(new Classmates("Emil Örjes",
                26,
                184,
                "Falun",
                "Snowboard, Gitarr, Musik, Hunden, Tv-spel",
                "Feta hamburgare",
                "Öl",
                "System Of a Down",
                0,
                "Att lära sig ett nytt yrke helt från grunden som känns givande."));







        }



    }
}
