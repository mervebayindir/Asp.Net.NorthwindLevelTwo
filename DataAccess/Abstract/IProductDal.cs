using Core.DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //Listeleme, Ekleme, Silme, Guncelleme  işlemlerı yapılır.
        //Repository Pattern ınsert,update,delete operasyonları generıc hala getırılıp ortak kullanım sağlanır.


    }
}
