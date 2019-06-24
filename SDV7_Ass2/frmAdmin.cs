using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAdmin
{
    public partial class frmAdmin : Form
    {
        private frmOrders frmOrders;
        private frmPokemon frmPokemon;
        private clsInventory Pokemon;
        private clsType Types;
        public frmAdmin()
        {
            InitializeComponent();
        }

        private async void UpdateDisplay()
        {
            cbTypes.DataSource = null;
            cbTypes.DataSource = await ServiceClient.GetTypeNameAsync();
            getpokemonlist();
        }

        private async void getpokemonlist()
        {
            lstPokemon.DataSource = null;
            Types = await ServiceClient.GetNamesAsync(cbTypes.SelectedItem as string);
            lstPokemon.DataSource = Types.PokemonList;
        }

        private async void SetDetails()
        {
            Pokemon = await ServiceClient.GetPokemonAsync(lstPokemon.SelectedItem as string);
            lblType.Text = Pokemon.typename;
            lblTypeDescription.Text = Types.Description;
            lblName.Text = Pokemon.name;
            lblDescription.Text = Pokemon.description;
            lblDustCost.Text = Pokemon.dustcost.ToString();
            lblDateModified.Text = Pokemon.datemodified.ToString();
            lblQuantity.Text = Pokemon.quantity.ToString();
            lblGender.Text = Pokemon.gender;
            lblEvolvable.Text = Pokemon.evolvable;
            if(Pokemon.dustcostofnewmove == null) { lblDustCostMove.Text = "N/A"; } else { lblDustCostMove.Text = Pokemon.dustcostofnewmove.ToString(); }
            if (Pokemon.nextevolutionname == "") { lblNextEvloutionName.Text = "N/A"; } else { lblNextEvloutionName.Text = Pokemon.nextevolutionname; }
            if (Pokemon.candycostofevolution == null) { lblNextEvolutionCost.Text = "N/A"; } else { lblNextEvolutionCost.Text = Pokemon.candycostofevolution.ToString(); }
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            frmOrders = new frmOrders();
            frmOrders.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsInventory Pokemon = new clsInventory();
            frmPokemon = new frmPokemon(Pokemon);
            frmPokemon.Show();
        }

        private void lstPokemon_DoubleClick(object sender, EventArgs e)
        {
            SetDetails();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void cbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            getpokemonlist();
        }

        private void lstPokemon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstPokemon.DataSource != null)
            {
                SetDetails();
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmPokemon = new frmPokemon(Pokemon);
            frmPokemon.Show();
        }
    }
}
