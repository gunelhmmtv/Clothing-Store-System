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
    public partial class Categoryss : Form
    {
        private readonly CategoryRepository _categoryrepository;
        public Categoryss()
        {
            InitializeComponent();
            _categoryrepository = new CategoryRepository();
        }

        private async void AddBtn_Click(object sender, EventArgs e)
        {
            if (categorytb.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Form is not valid!");
                return;
            }

            Category category = new()
            {
                CategoryName = categorytb.Text,
            };

            try
            {
                await _categoryrepository.Add(category);
                await _categoryrepository.SaveChangesAsync();

                MessageBox.Show("Category added successfully");

                await FillDataGridAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private async void Categoryss_Load(object sender, EventArgs e)
        {
            await FillDataGridAsync();
        }

        private async Task FillDataGridAsync()
        {
            CategoryDGV.DataSource = await _categoryrepository.GetAllAsync();
        }

        private async void EditBtn_Click(object sender, EventArgs e)
        {
            if (CategoryDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            Category selectedRowItem = (Category)CategoryDGV.SelectedRows[0].DataBoundItem;

            try
            {
                _categoryrepository.Update(selectedRowItem);
                await _categoryrepository.SaveChangesAsync();

                await FillDataGridAsync();

                MessageBox.Show("Category updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (CategoryDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            Category selectedItem = (Category)CategoryDGV.SelectedRows[0].DataBoundItem;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this category?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    _categoryrepository.Remove(selectedItem);
                    await _categoryrepository.SaveChangesAsync();

                    MessageBox.Show("Category deleted successfully");

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

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Customerss customerss = new();
            customerss.Show();
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
            DashBoard dashboardss = new();
            dashboardss.Show();
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}