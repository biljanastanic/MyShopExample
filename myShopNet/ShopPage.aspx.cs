using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myShopNet
{
    public partial class ShopPage : System.Web.UI.Page
    {
        ShopInterface shop = new Shop();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                int numberOfArticles = shop.GetNumberOfArticles();

                for (int i = 1; i <= numberOfArticles; i++)
                {
                    ShopListLB.Items.Add(shop.GetArticleByIndex(i));
                }
            }
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {

            List<String> cart = (List<String>)Session["CART"];

            if (cart == null)
                cart = new List<string>();

            if (ShopListLB.SelectedIndex != -1)
            {
                cart.Add(ShopListLB.SelectedValue);

                CartListLB.Items.Clear();

                foreach (String article in cart)
                {
                    CartListLB.Items.Add(article);
                }
            }
            Session["CART"] = cart;
        }

        protected void RemoveBtn_Click(object sender, EventArgs e)
        {
            List<String> cart = (List<String>)Session["CART"];

            if (cart == null)
                cart = new List<string>();

            if (CartListLB.SelectedIndex != -1)
            {
                cart.Remove(CartListLB.SelectedValue);
                CartListLB.Items.Clear();

                foreach (String article in cart)
                {
                    CartListLB.Items.Add(article);
                }
            }
            Session["CART"] = cart;
        }

        protected void BuyBtn_Click(object sender, EventArgs e)
        {

            shop.Buy((List<String>)Session["CART"]);

            Session["CART"] = new List<String>();
            CartListLB.Items.Clear();
        }
    }
}