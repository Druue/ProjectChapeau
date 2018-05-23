using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chapeau_DAL; // TODO: Remove this
using Chapeau_Logic;

namespace Chapeau_UI
{
    public class ChapeauUI
    {
        public class KitchenBarView
        {
            // Create listview for drinks
            ListView order = new ListView();
            order.Name = "lvOrder";
            order.Height = 200;
            order.Width = 350;
            order.View = View.Details;
            order.Scrollable = true;
            order.GridLines = true;

            ColumnHeader table = new ColumnHeader();
            table.Text = "lvTable";
            table.Name = "lvTable";
            table.Width = 100;
            order.Columns.Add(table);

            ColumnHeader items = new ColumnHeader();
            items.Text = "lvItems";
            items.Name = "lvItems";
            items.Width = 100;
            order.Columns.Add(items);

            ColumnHeader comments = new ColumnHeader();
            comments.Text = "lvDrinks";
            comments.Name = "lvDrinks";
            comments.Width = 100;
            order.Columns.Add(comments);

            ColumnHeader date = new ColumnHeader();
            date.Text = "lvPrice";
            date.Name = "lvPrice";
            date.Width = 100;
            order.Columns.Add(date);

            ChapeauDAL DB = new ChapeauDAL();
            DB.OrderDAO();

            /*
            // PopulateListView
            foreach (ListViewItem order in selectedDrinks)
            {
                ListViewItem.ListViewSubItemCollection d = drink.SubItems;
                ListViewItem drinks = new ListViewItem(d[0].Text);
                drinks.SubItems.Add(d[1].Text);
                drinks.SubItems.Add(d[3].Text);
                order.Items.Add(drinks);
            }
            */
            return order;
        }
    }
}
