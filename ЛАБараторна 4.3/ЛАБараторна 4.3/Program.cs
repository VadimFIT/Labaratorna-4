using System;

namespace ЛАБараторна_4._3
{
    class VadymInfo
    {
        public string name; 
        public int age;
        public string car;
        public VadymInfo() { name = "Vadym"; age = 19; car = "Nissan"; }
        public void Infomation()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age} Авто: {car}");
        }
    }

    class ArtemInfo
    {
        public string name;
        public int age;
        public string moto;
        public ArtemInfo() { name = "Artem"; age = 21; moto = "BMW"; }
        public void Infomation()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age} Мотоцикл: {moto}");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            VadymInfo vadyainf = new VadymInfo();
            ArtemInfo arteminf = new ArtemInfo();
           

            vadyainf.Infomation();
            arteminf.Infomation();
            Console.ReadKey();
        }
    }
}
