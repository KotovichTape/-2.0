using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace тортики_2._0
{
    public class Cake
    {
        public string Shape = "Не задано";
        public string Size = "Не задано";
        public string LayerFlavor = "Не задано"; //вкус коржей
        public string LayerQuantity = "Не задано"; // кол-во коржей
        public string Glaze = "Не задано"; //глазурь
        public string Decoration = "Не задано"; // украшение торта 

        //public string ShapeCake;
        //public string SizeCake;
        //public string LayerFlavorCake; //вкус коржей
        //public string LayerQuantityCake; // кол-во коржей
        //public string GlazeCake; //глазурь
        //public string DecorationCake; // украшение торта 


        public int ShapePrice = 0;
        public int SizePrice = 0;
        public int LayerFlavorPrice = 0;
        public int LayerQuantityPrice = 0;
        public int GlazePrice = 0;
        public int DecorationPrice = 0;

        public void SendToFile(string filename)
        {
            string textToFile = $"Заказ от{DateTime.Now}\n\tФорма:  {this.Shape}" +
                $", размер: {this.Size}, вкус коржей: {this.LayerFlavor}" +
                $", кол-во коржей: {this.LayerQuantity}, глазурь: {this.Glaze}" +
                $",украшения: {this.Decoration}\n" +
                $"Цена: {TotalPrice()} рублей. \n";
            File.AppendAllText($"{filename}", textToFile);
            
        }
         public int TotalPrice()
        {
            int result = this.ShapePrice + this.SizePrice + this.LayerFlavorPrice + this.LayerQuantityPrice + this.GlazePrice + this.DecorationPrice;
            return result;
        }
        public string TotalCake()
        {
            string cakeresult = "\n";
            if (this.ShapePrice != 0)
            {
                cakeresult = cakeresult + $"форма:      {this.Shape}  --  {this.ShapePrice}\n";
            }
            if (this.SizePrice != 0)
            {
                cakeresult = cakeresult + $"размер:     {this.Size}  --  {this.SizePrice}  \n";
            }
            if (this.LayerFlavorPrice != 0)
            {
                cakeresult = cakeresult + $"вкус коржей:  {this.LayerFlavor}  --  {this.LayerFlavorPrice} \n";
            }
            if (this.LayerQuantityPrice != 0)
            {
                cakeresult = cakeresult + $"количество коржей:  {this.LayerQuantity}  --  {this.LayerQuantityPrice}\n";
            }
            if (this.GlazePrice != 0)
            {
                cakeresult = cakeresult + $"глазурь:  {this.Glaze} --   {this.GlazePrice}\n";
            }
            if (this.DecorationPrice != 0)
            {
                cakeresult = cakeresult + $"декор: {this.Decoration}  -- {this.DecorationPrice} \n";
            }

            //string cakeresult = this.ShapeCake + this.SizeCake + this.LayerFlavorCake + this.LayerQuantityCake + this.GlazeCake + this.DecorationCake;
            return cakeresult;
        }
    }
}



