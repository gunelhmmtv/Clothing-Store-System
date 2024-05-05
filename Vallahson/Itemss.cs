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
using Vallahson.Extentions;
using Vallahson.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Vallahson
{
    public partial class Itemss : Form
    {
        private readonly ItemRepository _itemRepository;
        private readonly CategoryRepository _categoryRepository;
        public Itemss()
        {
            InitializeComponent();
            _itemRepository = new ItemRepository();
            _categoryRepository = new CategoryRepository();
        }

        private async void AddBtn_Click(object sender, EventArgs e)
        {
            if (itemtb.IsEmpty() || !Pricetb.IsGreaterThan(3))
            {
                MessageBox.Show("Form is not valid!");
                return;
            }

            Item item = new()
            {
                ItemName = itemtb.Text,
                Price = decimal.Parse(Pricetb.Text),
                CategoryId = (int)categorytb.SelectedValue,

            };

            try
            {
                await _itemRepository.Add(item);
                await _itemRepository.SaveChangesAsync();

                MessageBox.Show("Product added successfully");

                await FillDataGridAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private async void Itemss_Load(object sender, EventArgs e)
        {
            await FillDataGridAsync();
            await FillComboBoxAsync();
        }
        private async Task FillDataGridAsync()
        {
            ItemDVG.DataSource = await _itemRepository.GetAllAsync();
        }
        private async Task FillComboBoxAsync()
        {
            categorytb.Items.Clear();
            categorytb.DisplayMember = "CategoryName";
            categorytb.ValueMember = "Id";
            categorytb.DataSource = await _categoryRepository.GetAllAsync();
        }

        private async void EditBtn_Click(object sender, EventArgs e)
        {
            if (ItemDVG.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            Item selectedRowItem = (Item)ItemDVG.SelectedRows[0].DataBoundItem;

            try
            {
                _itemRepository.Update(selectedRowItem);
                await _itemRepository.SaveChangesAsync();

                await FillDataGridAsync();

                MessageBox.Show("Item updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (ItemDVG.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            Item selectedItem = (Item)ItemDVG.SelectedRows[0].DataBoundItem;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    _itemRepository.Remove(selectedItem);
                    await _itemRepository.SaveChangesAsync();

                    MessageBox.Show("Item deleted successfully");

                    await FillDataGridAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
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
