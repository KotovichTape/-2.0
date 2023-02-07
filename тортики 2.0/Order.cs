using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace тортики_2._0
{
    public class Order
    {
            public Cake cake = new Cake();
        public Order()
        {
            this.cake = new Cake();
        }
        private void Save()
        {
            cake.SendToFile("../../../ordersHistory.txt");
        }
        public void EndOrder()
        {
            Save();

            Console.Clear();
            Console.WriteLine("Спасибо за заказ! Если хотите сделать ещё один," +
                "нажмите на клавишу escape");

            ConsoleKeyInfo InputKey = Console.ReadKey();  

            switch (InputKey.Key)
            {
                case ConsoleKey.Escape:
                    this.cake = new Cake();
                    return;
                    break;
                default:
                    //Должен произойти выход из программы
                    Environment.Exit(0);   
                    break;
            }

        }
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine($"Заказ тортов в KotovichCake, торты на ваш выбор!\n" +
         $"Выберите параметр торта\n" +
         $"-------------------------\n" +
         $"  Форма торта\n" +
         $"  Размер торта\n" +
         $"  Вкус коржей\n" +
         $"  Количество коржей\n" +
         $"  Глазурь\n" +
         $"  Декор\n" +
         $"  Конец заказа\n" +
         $"\nЦена: {cake.TotalPrice()}\n" +
         $"Ваш торт: {cake.TotalCake()}\n");
           
        }
        public void Submenu(List<Choice> list, int cakeIndex )
        {
             int position = 3;

            while (true)
            {
                ShowSubmenu(list);

                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                ConsoleKeyInfo InputKey = Console.ReadKey();

                switch (InputKey.Key)
                {
                    case ConsoleKey.UpArrow: //форма
                        if (position != 3)
                        {
                            position--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (position != list.Count() + 2)
                        {
                            position++;
                        }
                        break;
                    case ConsoleKey.Enter:
                        //int cakeIndex = position - 3;
                        switch (cakeIndex)
                        {
                            case 0:
                                this.cake.Shape = list[position-3].Name();
                                this.cake.ShapePrice = list[position-3].Price();
                                return;
                                break;
                            case 1:
                                this.cake.Size = list[position-3].Name();
                                this.cake.SizePrice = list[position-3].Price();
                                return;
                                break;
                            case 2:
                                this.cake.LayerFlavor = list[position-3].Name();
                                this.cake.LayerFlavorPrice = list[position-3].Price();
                                return;
                                break;
                            case 3:
                                this.cake.LayerQuantity = list[position-3].Name();
                                this.cake.LayerQuantityPrice = list[position-3].Price();
                                return;
                                break;
                            case 4:
                                this.cake.Glaze = list[position-3].Name();
                                this.cake.GlazePrice = list[position-3].Price();
                                return;
                                break;
                            case 5:
                                this.cake.Decoration = list[position-3].Name();
                                this.cake.DecorationPrice = list[position-3].Price();
                                return;
                                break;
                            default:        
                            break;
                             
                        }
                        break;
                    case ConsoleKey.Escape:
                        return;
                        break;

                }
                Console.Clear();
                



            }


           // }
        } 
        private void ShowSubmenu(List<Choice> list)
        {
            Console.Clear();
            Console.WriteLine($"Для выхода нажмите Escape\n" +
         $"Выберите пункт из меню\n" +
         $"-------------------------");
            foreach(var item in list)
            {
                Console.WriteLine($"  {item.Name()} -- {item.Price()} руб.");
            }

        }
           
    } 
    
}
