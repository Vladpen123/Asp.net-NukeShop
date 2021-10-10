using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetCategories();
        Task<CategoryDTO> Get(int id);
        Task CreateCategory(CategoryDTO category);
        Task UpdateCategory(CategoryDTO category);
        Task DeleteCategory(int id);
    }
}
