using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess
// Burada T çok geniş bir aralığa sahip olduğu için onun sadece kendi nesnelerimizi almasını istedik.
{   // Burada class referans tip tutucu olarak görev alıyor yani int gibi string gibi bir şey implemente edilemesin diye ama bu sefer de referans tutucuları kısıtlamamız gerekiyor.
    // Bizde ona where şartı içerisinde IEntity ekledik ki bizim nesnelerimizin bağlı olduğu ana yer olduğu için... Bu da demek oluyor ki IEntity veya Product veya Customer veya Category hepsi buraya yazılabilir.
    // Yani IEntity ve IEntitynin inherite ettiği yerlerin hepsi için geçerli.
    // Ama IEntity soyut bir class ve biz onu implemente ettiğimizde sorun alıyoruz soyut bir class olduğu için yani IEntity'nin implement edilmememsini istiyoruz.
    // new() dediğimizde soyut sınıflar new'lenemeyeceği için bu işlemde sadece new'lenebilir IEntity Classların yazılmasını istiyoruz yani 
    public interface IEntityRepository<T>where T:class, IEntity, new () 
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
