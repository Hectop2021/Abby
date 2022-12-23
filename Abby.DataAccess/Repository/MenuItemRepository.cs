using Abby.DataAccess.Data;
using Abby.DataAccess.Repository.IRepository;
using Abby.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abby.DataAccess.Repository
{
    public class MenuItemRepository : Repository<MenuItem>, IMenuItemRepository
    {
        private readonly ApplicationDBContext _db;
        public MenuItemRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }

        public void Update(MenuItem MenuItem)
        {
            var objFromDb = _db.MenuItem.FirstOrDefault(u => u.Id == MenuItem.Id);
            objFromDb.Name = MenuItem.Name;
            objFromDb.Description = MenuItem.Description;
            objFromDb.Price = MenuItem.Price;
            objFromDb.CategoryId = MenuItem.CategoryId;
            objFromDb.FoodTypeId = MenuItem.FoodTypeId;
            if (objFromDb.Image != null)
            {
                objFromDb.Image = MenuItem.Image;
            }
        }
    }
}
