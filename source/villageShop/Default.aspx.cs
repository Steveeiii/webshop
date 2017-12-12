using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webShop
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lstProducts.DataSource = getProductList();
            lstProducts.DataBind();
        }

        private List<Product> getProductList()
        {
            var products = new List<Product>();

            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            var pathToSourceFile = basePath + @"resources\products.csv";
            var fileContent = File.ReadAllLines(pathToSourceFile);

            for (int i = 1; i < fileContent.Count(); i++)
            {
                var line = fileContent[i];
                var txt = line.Split(';');

                var product = new Product();
                product.ID = Convert.ToInt32(txt[0]);
                product.Name = txt[1];
                product.SpecialOffer = Convert.ToDouble(txt[2]);
                product.NormalPrice = Convert.ToDouble(txt[3]);
                product.Image = @"~\resources\img\" + txt[4];
                product.Description = txt[5];

                products.Add(product);
            }
            return products;
        }
    }
}