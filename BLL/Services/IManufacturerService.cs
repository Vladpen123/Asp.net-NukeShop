using BLL.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IManufacturerService
    {
        Task<IEnumerable<ManufacturerDTO>> GetManufacturers();
        Task<ManufacturerDTO> Get(int id);
        Task CreateManufacturer(ManufacturerDTO dto);
        Task UpdateManufacturer(ManufacturerDTO dto);
        Task DeleteManufacturer(int id);
    }
}