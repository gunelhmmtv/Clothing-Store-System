using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Vallahson.Entities;
using Vallahson.Interfaces;
using Vallahson.Repositories;

namespace Vallahson
{
    public partial class Customerss : Form
    {
        private readonly CustomerRepository _customerrepository;
        public Customerss()
        {
            InitializeComponent();
            _customerrepository = new CustomerRepository();
        }

        private async void Customerss_Load(object sender, EventArgs e)
        {
            await FillDataGridAsync();

        }
        private async Task FillDataGridAsync()
        {
            CustomerDVG.DataSource = _customerrepository.GetAllAsync();
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (CustomerDVG.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }



            DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Customer selectedItem = (Customer)CustomerDVG.SelectedRows[0].DataBoundItem;
                    _customerrepository.Remove(selectedItem);
                    await _customerrepository.SaveChangesAsync();

                    MessageBox.Show("Customer deleted successfully");

                    await FillDataGridAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private async void AddBtn_Click(object sender, EventArgs e)
        {
            if (Nametb.Text.IsNullOrEmpty() || Phonetb.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Form is not valid!");
                return;
            }

            Customer customer = new()
            {
                CustomerName = Nametb.Text,
                PhoneNumber = Phonetb.Text,
            };

            try
            {
                await _customerrepository.Add(customer);
                await _customerrepository.SaveChangesAsync();

                MessageBox.Show("Customer added");
                await FillDataGridAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }



        }

        private async void EditBtn_Click(object sender, EventArgs e)
        {
            if (CustomerDVG.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            Customer selectedRowItem = (Customer)CustomerDVG.SelectedRows[0].DataBoundItem;

            try
            {
                _customerrepository.Update(selectedRowItem);
                await _customerrepository.SaveChangesAsync();

                await FillDataGridAsync();

                MessageBox.Show("Customer updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Itemss items = new();
            items.Show();
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Categoryss categoryss = new();
            categoryss.Show();
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Billss billss = new();
            billss.Show();
            Close();
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
