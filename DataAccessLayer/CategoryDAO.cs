using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CategoryDAO
    {
        string connectionString = @"server=localhost;database=Lucy_SalesData;uid=trungcmnr;pwd=Cmnr123456@";
        Lucy_SalesDataDataContext context;

        public CategoryDAO()
        {
            context = new Lucy_SalesDataDataContext(connectionString);
        }

        public List<Category> GetAllCategories()
        {
            return context.Categories.ToList();
        }

        public bool SaveCategory(Category c)
        {
            Category old = context.Categories.FirstOrDefault(p => p.CategoryID == c.CategoryID);
            if (old != null)
            {
                return false;
            }
            context.Categories.InsertOnSubmit(c);
            context.SubmitChanges();
            return true;
        }

        public bool DeleteCategory(Category c)
        {
            Category old = context.Categories.FirstOrDefault(p => p.CategoryID == c.CategoryID);
            if (old != null)
            {
                context.Categories.DeleteOnSubmit(c);
                context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateCategory(Category c)
        {
            Category old = context.Categories.FirstOrDefault(p => p.CategoryID == c.CategoryID);
            if (old != null)
            {
                old.CategoryID = c.CategoryID;
                old.CategoryName = c.CategoryName;
                old.Description = c.Description;
                context.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
