using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongVat
{
    class Program
    {
        static void Main(string[] args)
        {
            AnCo.Bo bo = new AnCo.Bo();
            bo.ID1 = 1;
            bo.Name = "bò";
            bo.Weight = 150;
            AnCo.de de = new AnCo.de();
            de.ID1 = 2;
            de.Name = "dê";
            de.Weight = 50;
            AnCo.trau trau = new AnCo.trau();
            trau.ID1 = 3;
            trau.Name = "trâu";
            trau.Weight = 200;
            Anthit.CaSau caSau = new Anthit.CaSau();
            caSau.ID1 = 4;
            caSau.Name = "cá sấu";
            caSau.Weight = 150;
            Anthit.Ho ho = new Anthit.Ho();
            ho.ID1 = 5;
            ho.Name = "hổ";
            ho.Weight = 200;
            Anthit.SuTu sutu = new Anthit.SuTu();
            sutu.ID1 = 6;
            sutu.Name = "sư tử";
            sutu.Weight = 300;
            Console.WriteLine($"Bò in4 :{bo.ID1},{bo.Name},{bo.Weight}");
            Console.ReadKey();
        }
    }
    namespace AnCo
    {
        class Bo
        {
            private int ID;
            private string name;
            private int weight;

            public int ID1 { get => ID; set => ID = value; }
            public string Name { get => name; set => name = value; }
            public int Weight { get => weight; set => weight = value; }
        }
        class trau
        {
            private int ID;
            private string name;
            private int weight;

            public int ID1 { get => ID; set => ID = value; }
            public string Name { get => name; set => name = value; }
            public int Weight { get => weight; set => weight = value; }
        }
        class de
        {
            private int ID;
            private string name;
            private int weight;

            public int ID1 { get => ID; set => ID = value; }
            public string Name { get => name; set => name = value; }
            public int Weight { get => weight; set => weight = value; }
        }
    }
    namespace Anthit
    {
        class CaSau
        {
            private int ID;
            private string name;
            private int weight;

            public int ID1 { get => ID; set => ID = value; }
            public string Name { get => name; set => name = value; }
            public int Weight { get => weight; set => weight = value; }
        }
        class Ho
        {
            private int ID;
            private string name;
            private int weight;

            public int ID1 { get => ID; set => ID = value; }
            public string Name { get => name; set => name = value; }
            public int Weight { get => weight; set => weight = value; }
        }
        class SuTu
        {
            private int ID;
            private string name;
            private int weight;
            public int ID1 { get => ID; set => ID = value; }
            public string Name { get => name; set => name = value; }
            public int Weight { get => weight; set => weight = value; }
        }
    }
    namespace AnTap
    {

    }
}