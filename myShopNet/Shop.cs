using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myShopNet
{
    public class Shop : ShopInterface
    {
        public String GetArticleByIndex(int index)
        {
            ArticleSetTableAdapters.ShopTableTableAdapter adapter = new ArticleSetTableAdapters.ShopTableTableAdapter();
            return adapter.GetArticleByIndex(index);
        }

        public int GetNumberOfArticles()
        {
            ArticleSetTableAdapters.ShopTableTableAdapter adapter = new ArticleSetTableAdapters.ShopTableTableAdapter();
            return Convert.ToInt32(adapter.GetNumberOfArticles());
        }

        public bool Buy(List<String> cart)
        {

            try
            {
                ArticleSetTableAdapters.ShopTableTableAdapter adapter = new ArticleSetTableAdapters.ShopTableTableAdapter();

                foreach (String article in cart)
                {
                    adapter.BuyArticle(article);
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}