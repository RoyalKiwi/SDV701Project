using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSelfHost
{
    public class PokemonController : System.Web.Http.ApiController
    {
        public List<string> GetTypeName()
        {
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT name FROM type", null);
            List<string> lcTypes = new List<string>();
            foreach (DataRow dr in lcResult.Rows) lcTypes.Add((string)dr[0]);
            return lcTypes;

        }

        public clsInventory GetPokemon(string Name)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("Name", Name);
            DataTable lcResult =
            clsDbConnection.GetDataTable("SELECT * FROM inventory WHERE name = @Name", par);
            if (lcResult.Rows.Count > 0)
                return new clsInventory()
                {
                    pokeDexNo = Convert.ToInt32(lcResult.Rows[0]["pokeDexNo"]),
                    name = Convert.ToString(lcResult.Rows[0]["name"]),
                    description = Convert.ToString(lcResult.Rows[0]["description"]),
                    dustcost = Convert.ToInt32(lcResult.Rows[0]["dustcost"]),
                    datemodified = Convert.ToDateTime(lcResult.Rows[0]["datemodified"]),
                    quantity = Convert.ToInt32(lcResult.Rows[0]["quantity"]),
                    gender = Convert.ToString(lcResult.Rows[0]["gender"]),
                    evolvable = Convert.ToString(lcResult.Rows[0]["evolvable"]),
                    candycostofevolution = lcResult.Rows[0]["candycostofevolution"] is DBNull ? (int?)null : Convert.ToInt32(lcResult.Rows[0]["candycostofevolution"]),
                    nextevolutionname = Convert.ToString(lcResult.Rows[0]["nextevolutionname"]),
                    dustcostofnewmove = lcResult.Rows[0]["dustcostofnewmove"] is DBNull ? (int?)null : Convert.ToInt32(lcResult.Rows[0]["dustcostofnewmove"]),
                    typename = Convert.ToString(lcResult.Rows[0]["typename"])
                };
            else
                return null;

        }

        public clsType GetTypes(string Name)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("Name", Name);
            DataTable lcResult =
            clsDbConnection.GetDataTable("SELECT * FROM type WHERE name = @Name", par);
            if (lcResult.Rows.Count > 0)
            {
                return new clsType()
                {
                    PokemonList = GetPokemonNames(Name),
                    Name = Convert.ToString(lcResult.Rows[0]["name"]),
                    Description = Convert.ToString(lcResult.Rows[0]["description"]),
                };
            }
            else
                return null;
        }

        private List<string> GetPokemonNames(string Name)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("Name", Name);
            DataTable lcResult =
            clsDbConnection.GetDataTable("SELECT name FROM inventory WHERE typename = @Name", par);
            List<string> lcNames = new List<string>();
            foreach (DataRow dataRow in lcResult.Rows)
                lcNames.Add(Convert.ToString(dataRow["name"]));
            return lcNames;
        }


        public string PostPokemon(clsInventory prPokemon)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("pokeDexNo", prPokemon.pokeDexNo);
            par.Add("name", prPokemon.name);
            par.Add("description", prPokemon.description);
            par.Add("dustcost", prPokemon.dustcost);
            par.Add("quantity", prPokemon.quantity);
            par.Add("gender", prPokemon.gender);
            par.Add("evolvable", prPokemon.evolvable);
            par.Add("candycostofevolution", prPokemon.candycostofevolution);
            par.Add("nextevolutionname", prPokemon.nextevolutionname);
            par.Add("dustcostofnextmove", prPokemon.dustcostofnewmove);
            par.Add("typename", prPokemon.typename);
            int lcRecordcount = clsDbConnection.Execute("INSERT INTO inventory (pokeDexNo, name, description, dustcost, datemodified, quantity, gender, evolvable, candycostofevolution, nextevolutionname, dustcostofnewmove, typename) VALUES (@pokeDexNo, @name, @description, @dustcost, now(), @quantity, @gender, @evolvable, @candycostofevolution, @nextevolutionname, @dustcostofnextmove, @typename)", par);
            if (lcRecordcount == 1) { return "Sucessfully Added"; } else { return "Failed"; };
        }
        public string PutPokemon(clsInventory prPokemon)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("pokeDexNo", prPokemon.pokeDexNo);
            par.Add("name", prPokemon.name);
            par.Add("description", prPokemon.description);
            par.Add("dustcost", prPokemon.dustcost);
            par.Add("quantity", prPokemon.quantity);
            par.Add("gender", prPokemon.gender);
            int lcRecordcount = clsDbConnection.Execute("UPDATE inventory SET name = @name, description = @description, dustcost = @dustcost, datemodified = now(), quantity = @quantity, gender = @gender WHERE pokeDexNo = @pokeDexNo;", par);
            if (lcRecordcount == 1) { return "Sucessfully Added"; } else { return "Failed"; };
        }
        public List<clsOrder> GetOrdersList()
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            DataTable lcResult =
            clsDbConnection.GetDataTable("SELECT * FROM orders", par);
            List<clsOrder> lcOrders = new List<clsOrder>();
            foreach (DataRow dataRow in lcResult.Rows)
                lcOrders.Add(new clsOrder
                {
                    orderNo = Convert.ToInt32(lcResult.Rows[0]["orderNo"]),
                    dateordered = Convert.ToDateTime(lcResult.Rows[0]["dateordered"]),
                    dustcost = Convert.ToInt32(lcResult.Rows[0]["dustcost"]),
                    quantatyordered = Convert.ToInt32(lcResult.Rows[0]["quantatyordered"]),
                    customername = Convert.ToString(lcResult.Rows[0]["customername"]),
                    customerphoneno = Convert.ToString(lcResult.Rows[0]["customerphoneno"]),
                    inventorypokedexno = Convert.ToInt32(lcResult.Rows[0]["inventorypokedexno"])
                });
            return lcOrders;
        }
    }
}
