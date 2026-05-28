using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Roles
    {
        // Szerepek
        public string[] Karakterek { get; } =
        {
            "Csonkito", // külön formos megoldás
            "Felugyelo", // éjszaka nem használhatod a képességed (gyilkosoknak insta death???)
            "Gyilkos", // 50 damage
            "Keresztapa", // 75 damage
            "Orvos", // !!! alap 5 karakter !!!
            "Kislany", // kémked
            "Logan", // nappal lehet csak megölni
            //"Saman", // egyzer 100ra és egyszer 0ra teszi valakinek az HPját
            "Selyemfiu", // 25 damage ad minden nap célpontjának aki poisont kap, Victim listre rátenni
            "Alien", // megöli azt aki felterjesztette
            "Farajo", // Ugyanaz mint az orvos
            "John Wick", //(ha meghal a kislány akkor ölhet onnantól, néppel van)
            "Prosti", // képes a poisont levenni a selyemfiutól
            //---------------------------------------------------------------
            "Cupido", // két embert összeköt (saját bool a playerbe, és egyszerre kell a dropdown és a list targetinghez)
            "Polgarmester", // megmondhatja hogy Ő a polgármester
            "Orban Viktor", // csak 2/3 lehet kiszavazni (Y/N messagebox)
            "Porszivougynok", // minden élőnek kell eladni 
            "Novak Katalin", // minden észjaka felterjeszthet egy élőt hogy nappal ne ölhessék meg
             "Magyar Peter" // akit felterjeszt az instant megy a levesbe
                // Goth csaj aki feltámaszt valakit egyszer
             // "Malac", // minden REVERSE ha röfög || nehéz programozni
             //"Gandalf",
            // "Magdi Anyus"
            // ??? vega, csirke, 
        };

        // SORREND:
        // este kell: {Csonkito, Keresztapa, Gyilkos, Felugyelo, Orvos, Saman, Selyemfiu, Farajo, John Wick ,Prosti, Porszivougynok, Novak Katalin}
        // este nem kell felébreszteni: {Kislany, Logan, Polgarmester, Orban Viktor, Magyar Peter}
        // csak egyszer kell felébreszteni: {Saman, John Wick, Cupido}

        
    }
}
