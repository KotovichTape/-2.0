using тортики_2._0;

//Cake cake1 = new Cake();
Choice shape1 = new Choice("Квадратный", 499);
Choice shape2 = new Choice("Круглый", 699);
Choice shape3 = new Choice("Треугольный", 999);


List<Choice> shapes = new List<Choice>();

shapes.Add(shape1);
shapes.Add(shape2);
shapes.Add(shape3);

//размер

Choice size1 = new Choice("Маленький", 499);
Choice size2 = new Choice("Средний", 799);
Choice size3 = new Choice("Большой", 1499);


List<Choice> sizes = new List<Choice>();

sizes.Add(size1);
sizes.Add(size2); 
sizes.Add(size3);

//вкус

Choice layerFlavor1 = new Choice("С ягодной пропиткой", 399);
Choice layerFlavor2 = new Choice("Бисквит", 599);
Choice layerFlavor3 = new Choice("Ваниль", 649);


List<Choice> layerFlavors = new List<Choice>();

layerFlavors.Add(layerFlavor1);
layerFlavors.Add(layerFlavor2);
layerFlavors.Add(layerFlavor3);

//кол-во

Choice layerQuantity1 = new Choice("1", 500);
Choice layerQuantity2 = new Choice("2", 1000);
Choice layerQuantity3 = new Choice("3", 1500);
Choice layerQuantity4 = new Choice("4", 2000);


List<Choice> layerQuantities = new List<Choice>();

layerQuantities.Add(layerQuantity1);
layerQuantities.Add(layerQuantity2);
layerQuantities.Add(layerQuantity3);
layerQuantities.Add(layerQuantity4);

//шлазурь

Choice glaze1 = new Choice("Шоколадная", 199);
Choice glaze2 = new Choice("Клубничная", 269);
Choice glaze3 = new Choice("Банановая", 149);



List<Choice> glazes = new List<Choice>();

glazes.Add(glaze1);
glazes.Add(glaze2);
glazes.Add(glaze3);

//Декор

Choice decoration1 = new Choice("Ягодное", 349);
Choice decoration2 = new Choice("Паутинкой", 449);
Choice decoration3 = new Choice("Шоколадное", 449);



List<Choice> decorations = new List<Choice>();

decorations.Add(decoration1);
decorations.Add(decoration2);
decorations.Add(decoration3);




List<List<Choice>> allLists = new List<List<Choice>>();

allLists.Add(shapes);
allLists.Add(sizes);
allLists.Add(layerFlavors);
allLists.Add(layerQuantities);
allLists.Add(glazes);
allLists.Add(decorations);

//cake1.Shape = "круглый";
//cake1.Glaze = "шоколадная";
//cake1.LayerQuantity = 3;
//cake1.LayerFlavor = "Ваниль";
//cake1.Decoration = "Ягодный";
//cake1.Size = "большой";

//cake1.SendToFile("../../../ordersHistore.txt");
Console.Clear();

Order order = new Order();

int position = 3;


while (true)
{
    order.ShowMenu();

 Console.SetCursorPosition(0, position);
 Console.WriteLine("->");

 ConsoleKeyInfo InputKey = Console.ReadKey();
    
    
    switch (InputKey.Key)
    {
        case ConsoleKey.UpArrow:
            if (position != 3)
            {
                position--;
            }
            break;
        case ConsoleKey.DownArrow:
            if (position != 9)
            {
                position++;
            }
            break;
        //.............u
        case ConsoleKey.Enter:
            Console.Clear();

            if (position == 9)
            {
                order.EndOrder();
            }
            else
            {
                int sublistIndex = position - 3;
                order.Submenu(allLists[sublistIndex], sublistIndex); //TODO
                
            }
            break;
        case ConsoleKey.Escape:
            Console.Clear();
            Environment.Exit(1);
        break;
        default:
        break;
    }
}

