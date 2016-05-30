using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myShopNet
{
    interface ShopInterface
    {
        String GetArticleByIndex(int index);
        int GetNumberOfArticles();
        bool Buy(List<String> cart);
    }
}
