using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace State_Machin_WinForm
{
    public partial class CoffeeMachine : Form
    {
        private CoffeeMachin coffeeMachin = new CoffeeMachin();
        private CoffeePrices coffeePrices = new CoffeePrices();

        public CoffeeMachine()
        {
            InitializeComponent();
        }

        private void CoffeeMachine_Load(object sender, EventArgs e)
        {
        }

        private void InsertMoneyOK_Click(object sender, EventArgs e)
        {
            var comboBoxValue = InsertMoneyComboBox.SelectedItem;
            if (comboBoxValue != null )
            {
                coffeeMachin.PerformAction(int.Parse(comboBoxValue.ToString()));
            }
            UpdateSold();
        }

        private void SmallCoffeeButton_Click(object sender, EventArgs e)
        {
            coffeeMachin.GetProduct(coffeePrices.SMALL_COFFEE);
            UpdateSold();
        }

        private void BigCoffeeButton_Click(object sender, EventArgs e)
        {
            coffeeMachin.GetProduct(coffeePrices.BIG_COFFEE);
            UpdateSold();
        }

        private void TeaButton_Click(object sender, EventArgs e)
        {
            coffeeMachin.GetProduct(coffeePrices.TEA);
            UpdateSold();
        }

        private void CafeaCuLapteButton_Click(object sender, EventArgs e)
        {
            coffeeMachin.GetProduct(coffeePrices.COFFEE_WITH_MILK);
            UpdateSold();
        }

        private void CoffeChocolateButton_Click(object sender, EventArgs e)
        {
            coffeeMachin.GetProduct(coffeePrices.COFFEE_WITH_CHOCOLATE);
            UpdateSold();
        }

        private void LatteMachiattoButton_Click(object sender, EventArgs e)
        {
            coffeeMachin.GetProduct(coffeePrices.LATTE_MACHIATTO);
            UpdateSold();
        }

        private void UpdateSold()
        {
            SoldTextBox.Text = coffeeMachin.CurrentState.ToString();
        }
    }
}
