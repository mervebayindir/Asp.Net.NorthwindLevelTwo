using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        //Tum urunlerı lıstelemek ısterken bır ıs kuralını kontrol etmek ıcın parametre verebılmek ıcın kullanılır IPrpductServices

        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);
        Product GetById(int productId);
    }
}
