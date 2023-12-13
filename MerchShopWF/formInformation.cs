using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerchShopWF
{
    public partial class formInformation : Form
    {
        public formInformation()
        {
            InitializeComponent();
        }

        private void formInformation_Load(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                var q = from orders in dbContext.Orders
                        join customers in dbContext.Customers on orders.CustomerId equals customers.Id
                        join item_order in dbContext.ItemOrders on orders.Id equals item_order.OrderId
                        join items in dbContext.Items on item_order.ItemId equals items.Id
                        join albums in dbContext.Albums on items.AlbumId equals albums.Id
                        join performers in dbContext.Performers on albums.PerformerId equals performers.Id
                        orderby orders.Id
                        select new GlobalInfo()
                        {
                            OrderID = orders.Id,
                            Date = orders.Date,
                            TotalPrice = orders.TotalPrice,
                            Status = orders.Status,
                            Customer = customers.Name,
                            Performer = performers.Name,
                            Album = albums.Name,
                            Item = items.Name,
                            Price = items.Price,
                            Units = item_order.Units
                        };
                var InfoList = q.ToList();
                var bindingList = new BindingList<GlobalInfo>(InfoList);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
                int i = 1;
            }
        }
    }
}
