using System;
using InspectorLib;

namespace TestInspectorLib
{
    class Program
    {
        static void Main(string[] args)
        {
            FunctionInsp inspector = new FunctionInsp();

            Console.WriteLine($"Главный инспектор: {inspector.GetInspector()}");
            Console.WriteLine($"Название автоинспекции: {inspector.GetCarInspection()}");

            bool success = inspector.SetInspector("Миронов А.В.");
            Console.WriteLine($"\nИзменение главного инспектора на Миронов А.В.: {(success ? "Успешно" : "Ошибка")}");
            Console.WriteLine($"Новый главный инспектор: {inspector.GetInspector()}");

            string numberPlate = inspector.GenerateNumber('А');
            Console.WriteLine($"\nСгенерированный госномер: {numberPlate}");

            Console.WriteLine($"\nСписок сотрудников:");
            foreach (string worker in inspector.GetWorker())
            {
                Console.WriteLine(worker);
            }

            bool added = inspector.AddWorker("Петров П.П.");
            Console.WriteLine($"\nДобавление Петров П.П.: {(added ? "Успешно" : "Ошибка")}");

            Console.WriteLine("\nСписок сотрудников после добавления:");
            foreach (string worker in inspector.GetWorker())
            {
                Console.WriteLine(worker);
            }

            Console.ReadKey();
        }
    }
}

