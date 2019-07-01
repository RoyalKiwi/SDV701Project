using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSelfHost
{
        public class clsType
        {
            public List<string> PokemonList { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }

        }
        public class clsInventory
        {
            public int pokeDexNo { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public int dustcost { get; set; }
            public  DateTime datemodified { get; set; }
            public int quantity { get; set; }
            public string gender { get; set; }
            public string evolvable { get; set; }
            public int? candycostofevolution { get; set; }
            public string nextevolutionname { get; set; }
            public int? dustcostofnewmove { get; set; }
            public string typename { get; set; }

        }
        public class clsOrder
        {
            public int orderNo { get; set; }
            public DateTime dateordered { get; set; }
            public int dustcost { get; set; }
            public int quantatyordered { get; set; }
            public string customername { get; set; }
            public string customerphoneno { get; set; }
            public int inventorypokedexno { get; set; }
            public override string ToString()
            {
            return orderNo.ToString() + dateordered.ToString() + dustcost.ToString() + quantatyordered.ToString() + customername + customerphoneno + inventorypokedexno.ToString();
            }
        }

}

