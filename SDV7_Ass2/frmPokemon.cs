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
    public partial class frmPokemon : Form
    {
        private clsInventory Pokemon;
        public frmPokemon(clsInventory prPokemon)
        {
            InitializeComponent();
            Pokemon = prPokemon;
            cbType.Text = Pokemon.typename;
            txtDexNo.Text = Pokemon.pokeDexNo.ToString();
            txtName.Text = Pokemon.name;
            txtDescription.Text = Pokemon.description;
            txtDustCost.Text = Pokemon.dustcost.ToString();
            txtQuantity.Text = Pokemon.quantity.ToString();
            if (Pokemon.gender == "M") { cbGender.SelectedIndex = 0; }else if (Pokemon.gender == "F") { cbGender.SelectedIndex = 1; };
            if (Pokemon.evolvable == "Y") { cbEvolvable.SelectedIndex = 0; }else if (Pokemon.evolvable == "N") { cbEvolvable.SelectedIndex = 1; };
            if (Pokemon.dustcostofnewmove == null) { txtDustCostNewMove.Text = "N/A"; } else { txtDustCostNewMove.Text = Pokemon.dustcostofnewmove.ToString(); }
            if (string.IsNullOrEmpty(Pokemon.nextevolutionname)) { txtNextEvolution.Text = "N/A"; } else { txtNextEvolution.Text = Pokemon.nextevolutionname; }
            if (Pokemon.candycostofevolution == null) { txtCandyCostEvolution.Text = "N/A"; } else { txtCandyCostEvolution.Text = Pokemon.candycostofevolution.ToString(); }
            if (Pokemon.pokeDexNo.ToString() != "0")
            {
                cbType.Enabled = false;
                txtDexNo.Enabled = false;
                cbEvolvable.Enabled = false;
            }
        }

        private void cbEvolvable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEvolvable.SelectedIndex == 0)
            {
                txtDustCostNewMove.Enabled = false;
                txtNextEvolution.Enabled = true;
                txtCandyCostEvolution.Enabled = true;
            }
            else
            {
                txtDustCostNewMove.Enabled = true;
                txtNextEvolution.Enabled = false;
                txtCandyCostEvolution.Enabled = false;
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                PushData();
                if (txtDexNo.Enabled == true)
                { //Add
                    MessageBox.Show(await ServiceClient.InsertPokemonAsync(Pokemon));
                }
                else
                { //Update
                    MessageBox.Show(await ServiceClient.UpdatePokemonAsync(Pokemon));
                }
                Close();
            }
        }

        private bool CheckData()
        {
            if (cbType.SelectedItem == null) { MessageBox.Show("Please Selected a Type"); return false; };
            if (txtDexNo.Text == "0") { MessageBox.Show("Please Input a DexNo"); return false; };
            if (txtName.Text == "") { MessageBox.Show("Please Input a Name"); return false; };
            if (txtDescription.Text =="") { MessageBox.Show("Please Input a Description"); return false; };
            if (txtDustCost.Text == "0") { MessageBox.Show("Please Input a Dust Cost"); return false; };
            if (txtQuantity.Text == "") { MessageBox.Show("Please Input the Quantity"); return false; };
            if (cbGender.SelectedItem == null) { MessageBox.Show("Please Selected a Gender"); return false; };
            if (cbEvolvable.SelectedItem == null) { MessageBox.Show("Please Selected a Evolvable"); return false; };
            if (txtDustCostNewMove.Enabled == true && txtDustCostNewMove.Text == "N/A"){ MessageBox.Show("Please Input the Dust Cost of a New Move"); return false; };
            if (txtDustCostNewMove.Enabled == true && string.IsNullOrEmpty(txtDustCostNewMove.Text)) { MessageBox.Show("Please Input the Dust Cost of a New Move"); return false; };
            if (txtNextEvolution.Enabled == true && txtNextEvolution.Text == "N/A") { MessageBox.Show("Please Input the Next Evolutions Name"); return false; };
            if (txtNextEvolution.Enabled == true && string.IsNullOrEmpty(txtNextEvolution.Text)) { MessageBox.Show("Please Input the Next Evolutions Name"); return false; };
            if (txtCandyCostEvolution.Enabled == true && txtCandyCostEvolution.Text == "N/A") { MessageBox.Show("Please Input the Candy Cost of the Next Evolution"); return false; };
            if (txtCandyCostEvolution.Enabled == true && string.IsNullOrEmpty(txtCandyCostEvolution.Text)) { MessageBox.Show("Please Input the Candy Cost of the Next Evolution"); return false; };
            return true;
        }

        private void PushData()
        {
            Pokemon.typename = cbType.SelectedItem.ToString();
            Pokemon.pokeDexNo = Convert.ToInt32(txtDexNo.Text);
            Pokemon.name = txtName.Text;
            Pokemon.description = txtDescription.Text;
            Pokemon.dustcost = Convert.ToInt32(txtDustCost.Text);
            Pokemon.quantity = Convert.ToInt32(txtQuantity.Text);
            if (cbGender.SelectedIndex == 0) { Pokemon.gender = "M"; } else if (cbGender.SelectedIndex == 1) { Pokemon.gender = "F"; };
            if (cbEvolvable.SelectedIndex == 0) { Pokemon.evolvable = "Y"; } else if (cbEvolvable.SelectedIndex == 1) { Pokemon.evolvable = "N"; };
            if (txtDustCostNewMove.Enabled == true) { Pokemon.dustcostofnewmove = Convert.ToInt32(txtDustCostNewMove.Text); } else { Pokemon.dustcostofnewmove = null; };
            if (txtNextEvolution.Enabled == true) { Pokemon.nextevolutionname = txtNextEvolution.Text; } else { Pokemon.nextevolutionname = ""; };
            if (txtCandyCostEvolution.Enabled == true) { Pokemon.candycostofevolution = Convert.ToInt32(txtCandyCostEvolution.Text); } else { Pokemon.candycostofevolution = null; };
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
