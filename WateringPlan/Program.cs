using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WateringPlan
{
    class Program
    {
        public enum MenuItems
        {
            ID_ADD_COUNTRY,
            ID_ADD_FIELD,
            ID_ADD_CROP,
            ID_CHANGE_COUNTRY,
            ID_CHANGE_FIELD,
            ID_CHANGE_CROP,
            ID_DELETE_COUNTRY,
            ID_DELETE_FIELD,
            ID_DELETE_CROP,
            ID_FIND_CROPS
        }
        static void Main (string[] args)
        {
            var userInput = "";
            var country = new Country();
            var field = new Field();
            var culture = new Culture();
            Console.WriteLine("1 - Создать страну");
            Console.WriteLine("2 - Создать поле");
            Console.WriteLine("3 - Создать культуру");
            Console.WriteLine("4 - Изменить страну");
            Console.WriteLine("5 - Изменить поле");
            Console.WriteLine("6 - Изменить культуру");
            Console.WriteLine("7 - Удалить страну");
            Console.WriteLine("8 - Удалить поле");
            Console.WriteLine("9 - Удалить культуру");
            Console.WriteLine("10 - Найти культуры");

            var userChoice = Convert.ToInt32(Console.ReadLine());

            switch ((MenuItems) userChoice)
            {
                case MenuItems.ID_ADD_COUNTRY:
                    {
                        Console.WriteLine("Введите имя страны:");
                        userInput = Console.ReadLine();
                        country.Name = userInput;
                        break;
                    }
                case MenuItems.ID_ADD_FIELD:
                    {
                        Console.WriteLine("Введите площадь поля:");
                        userInput = Console.ReadLine();
                        field.Area = Convert.ToDouble(userInput);

                        country.fields.Add(field);
                        break;
                    }
                case MenuItems.ID_ADD_CROP:
                    {
                        Console.WriteLine("Введите имя культуры:");
                        userInput = Console.ReadLine();
                        culture.Name = userInput;
                        Console.WriteLine("Введите дату начала полива:");
                        userInput = Console.ReadLine();
                        culture.StartWateringDate = Convert.ToDateTime(userInput);
                        Console.WriteLine("Введите дату окончания полива:");
                        userInput = Console.ReadLine();
                        culture.EndWateringDate = Convert.ToDateTime(userInput);
                        Console.WriteLine("Введите сколько нужно в день поливать:");
                        userInput = Console.ReadLine();
                        culture.FrequencyWateringInDay = Convert.ToInt32(userInput);
                        Console.WriteLine("Введите сколько воды нужно в литрах:");
                        userInput = Console.ReadLine();
                        culture.WaterNeededInLitres = Convert.ToInt32(userInput);
                        Console.WriteLine("Введите глубину полива в сантиметрах:");
                        userInput = Console.ReadLine();
                        culture.RootingDepthInCm = Convert.ToInt32(userInput);

                        field.cultures.Add(culture);
                        break;
                    }
                case MenuItems.ID_CHANGE_COUNTRY:
                    {

                        break;
                    }
                case MenuItems.ID_CHANGE_FIELD:
                    {
                        break;
                    }
                case MenuItems.ID_CHANGE_CROP:
                    {
                        break;
                    }
                case MenuItems.ID_DELETE_COUNTRY:
                    {
                        Console.WriteLine("Удалить страну?(y - да, n - нет)");
                        userInput = Console.ReadLine();
                        if(userInput == "y")
                        {
                            country.Delete();
                            Console.WriteLine("Страна удалена.");
                        }
                        else
                        {
                            Console.WriteLine("Страна не удалена.");
                        }
                        break;
                    }
                case MenuItems.ID_DELETE_FIELD:
                    {
                        Console.WriteLine("Введите название поля:");
                        userInput = Console.ReadLine();
                        Field result = country.fields.Find(value => value.Name == userInput);
                        result.Delete();
                        break;
                    }
                case MenuItems.ID_DELETE_CROP:
                    {
                        Console.WriteLine("Введите название культуры:");
                        userInput = Console.ReadLine();
                        Culture result = field.cultures.Find(value => value.Name == userInput);
                        result.Delete();
                        break;
                    }
                case MenuItems.ID_FIND_CROPS:
                    {
                        Console.WriteLine("Введите название культуры:");
                        userInput = Console.ReadLine();

                        Culture result = field.cultures.Find(value => value.Name == userInput);
                        Console.WriteLine("Результат:");
                        result.ShowAll();
                        break;
                    }
            }

        }
    }
}
