using DataAccessLayer.Concrate.Repositories;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAllBl()
        {
            return repo.List();
        }

        public void CategoryAddBl(Category p)
        {
            if (p.CategoryName.Length <= 3)
            {
                //hata mesajı
            }
            else
            {
                repo.Insert(p);

            }
        }
    }
}
