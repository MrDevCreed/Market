using Data.Database;
using Data.Repositorys.Common;
using Data.Repositorys.Interfaces;
using Domain;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositorys.Implementations
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context) : base(context)
        {
            this._context = context;
        }

        public List<Category> GetList()
        {
            return _context.Categories.ToList();
        }
    }
}
