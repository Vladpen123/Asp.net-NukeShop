using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IGoodService
    {
        Task<IEnumerable<GoodDTO>> GetGoods();
        Task<GoodDTO> Get(int id);
        Task CreateGood(GoodDTO dto);
        Task UpdateGood(GoodDTO dto);
        Task DeleteGood(int id);
    }
}
