using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vallahson.Entities;
using Vallahson.Interfaces;
using Vallahson.Repositories;

namespace Vallahson
{
    public partial class Billss : Form
    {
        private readonly BillingRepository _billingrepository;
        public Billss()
        {
            InitializeComponent();
            _billingrepository = new BillingRepository();
        }

        private async void Billss_Load(object sender, EventArgs e)
        {
            await FillDataGridAsync();
        }

        private async Task FillDataGridAsync()
        {
            BillDVG.DataSource = await _billingrepository.GetAllAsync();
        }

        private async void AddBtn_Click(object sender, EventArgs e)
        {
            if (Customertb.Text.IsNullOrEmpty() || Amounttb.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Form is not valid!");
                return;
            }

            Bill bill = new()
            {

                Amount = int.Parse(Amounttb.Text),
                CustomerId = int.Parse(Customertb.Text),

            };

            try
            {
                await _billingrepository.Add(bill);
                await _billingrepository.SaveChangesAsync();

                MessageBox.Show("Billing added successfully");

                await FillDataGridAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (BillDVG.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            Bill selectedItem = (Bill)BillDVG.SelectedRows[0].DataBoundItem;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this billing?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    _billingrepository.Remove(selectedItem);
                    await _billingrepository.SaveChangesAsync();

                    MessageBox.Show("Billing deleted successfully");

                    await FillDataGridAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Itemss itemss = new();
            itemss.Show();
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Categoryss categoryss = new();
            categoryss.Show();
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Customerss customerss = new();
            customerss.Show();
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new();
            dashBoard.Show();
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}