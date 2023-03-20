using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PR5
{
    //Интерфейс с методом Voice
    interface IHuman
    {
        void Voice();
    }

    //Классы с интерфейсом IHuman
    class Toha : IHuman
    {
        public void Voice()
        {
            Console.WriteLine("Тебе правда это нравится?");
        }
    }

    class Borya : IHuman
    {
        public void Voice()
        {
            Console.WriteLine("Может ты уберёшь свою руку и мы забудем об этом?!");
        }
    }

    class Sasha : IHuman
    {
        public void Voice()
        {
            Console.WriteLine("Это можно считать за домогательство!");
        }
    }
    class Dimon : IHuman
    {
        public void Voice()
        {
            Console.WriteLine("Не останавливайся! О.о");
        }
    }

    class Owl : IHuman
    {
        //Чтение времени(Часа) из файла
        private int GetCurrentTime()
        {
            return Convert.ToInt32(File.ReadAllText("current_time.txt"));
        }

        //Проверка времени и воспроизведение звука совы
        public void Voice()
        {
            int currentTime = GetCurrentTime();

            if ((currentTime >= 8) && (currentTime <= 21))
            {
                Console.WriteLine("Тише, я сплю!");
            }
            else
            {
                Console.WriteLine("Ух! Ух! Ух!");
            }
        }
    }

    class Program
    {
        //Статический метод
        static void PetAnimal(IHuman human)
        {
            Console.WriteLine("Мы гладим зверушку, а она нам говорит: ");
            human.Voice();
        }

        static void Main(string[] args)
        {

            //Инициализация объектов с интерфейсом и дочерним классом
            Toha Anton = new Toha();
            PetAnimal(Anton);

            Borya boris = new Borya();
            PetAnimal(boris);

            Sasha Alexandra = new Sasha();
            PetAnimal(Alexandra);

            Dimon Dmitriy = new Dimon();
            PetAnimal(Dmitriy);

            IHuman Owl = new Owl();
            PetAnimal(Owl);

            Console.ReadKey(true);
        }
    }
}