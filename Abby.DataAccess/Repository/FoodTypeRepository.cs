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
    public class FoodTypeRepository : Repository<FoodType>, IFoodTypeRepository
    {
        private readonly ApplicationDBContext _db;
        public FoodTypeRepository(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }

        public void Update(FoodType FoodType)
        {
            var objFromDb = _db.FoodType.FirstOrDefault(u => u.Id == FoodType.Id);
            objFromDb.Name = FoodType.Name;
        }
    }
}
