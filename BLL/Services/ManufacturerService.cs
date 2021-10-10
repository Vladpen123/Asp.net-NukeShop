using AutoMapper;
using BLL.DTO;
using DAL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ManufacturerService : IManufacturerService
    {
        HttpClient client;
        IMapper mapper;

        public ManufacturerService(HttpClient client)
        {
            this.client = client;

            var config = new MapperConfiguration(cfg =>
            {
            cfg.CreateMap<GoodDTO, Good>().ReverseMap();
            cfg.CreateMap<Manufacturer, ManufacturerDTO>().ReverseMap();        
            });
              
            mapper = new Mapper(config);
        }

        public async Task CreateManufacturer(ManufacturerDTO dto)
        {
            var manufacturer = mapper.Map<Manufacturer>(dto);

            var content = JsonConvert.SerializeObject(manufacturer);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);

            byteContent.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

            HttpResponseMessage response = await client.PostAsync($"api/Manufacturers/", byteContent);
        }

        public async Task DeleteManufacturer(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"api/Manufacturers/{id}");
            response.EnsureSuccessStatusCode();
        }

        public async Task<ManufacturerDTO> Get(int id)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync($"api/Manufacturers/{id}");
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var manufacturer = JsonConvert.DeserializeObject<Manufacturer>(jsonString);
                if (manufacturer == null)
                    return null;
                return mapper.Map<ManufacturerDTO>(manufacturer);
            }
            else
                return null;
        }

        public async Task<IEnumerable<ManufacturerDTO>> GetManufacturers()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync("api/Manufacturers/");
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var manufacturers = JsonConvert.DeserializeObject<IEnumerable<Manufacturer>>(jsonString);
                if (manufacturers == null)
                    return null;
                return mapper.Map<IEnumerable<ManufacturerDTO>>(manufacturers);
            }
            else
                return null;
        }

        public async Task UpdateManufacturer(ManufacturerDTO dto)
        {
            var manufacturer = mapper.Map<Manufacturer>(dto);

            var content = JsonConvert.SerializeObject(manufacturer);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);

            byteContent.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

            HttpResponseMessage response = await client.PutAsync($"api/Manufacturers/{manufacturer.Id}", byteContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
