using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;

namespace Cards.Main
{
    public partial class AddItemType : Form
    {
        Model1 db = new Model1();
        public AddItemType()
        {
            InitializeComponent();
        }

        private void btnexist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            var itemtype = new ItemType
            {
                itemTypeName = txtItemType.Text
            };
            db.ItemTypes.Add(itemtype);
            db.SaveChanges();
        }
    }
}
