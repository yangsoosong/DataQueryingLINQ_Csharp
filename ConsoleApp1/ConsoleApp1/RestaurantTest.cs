using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class RestaurantTest
{
    public static void Main(string[] args)
    {
        Restaruarnt yume = new Restaruarnt("Yume Wo Katare", "100 Mass Ave", 0.18);
        yume.GenerateReceipt();
    }
}