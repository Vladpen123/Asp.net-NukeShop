using AutoMapper;
using BLL.DTO;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace BLL.Services
{
    public class GoodService : IGoodService
    {
        IMapper mapper;
        HttpClient client;
        // IGoodRepository goodRepository;

        public GoodService(HttpClient client)
        {
            this.client = client;
            // this.goodRepository = goodRepository;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Good, GoodDTO>()
                    .ForMember(dest => dest.CategoryName, y => y.MapFrom(src => src.Category.Name))
                    .ForMember(dest => dest.ManufacturerName, y => y.MapFrom(src => src.Manufacturer.Name))
                    .ForMember(dest => dest.Gender, y => y.MapFrom(src => ((int)src.Gender)));

                cfg.CreateMap<GoodDTO, Good>();

            });

            mapper = new Mapper(config);
        }

        public async Task<IEnumerable<GoodDTO>> GetGoods()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync("api/Goods/");
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var goods = JsonConvert.DeserializeObject<IEnumerable<Good>>(jsonString);
                if (goods == null)
                    return null;
                return mapper.Map<IEnumerable<GoodDTO>>(goods);
            }
            else
                return null;
        }

        public async Task<GoodDTO> Get(int id)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync($"api/Goods/{id}");
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var good = JsonConvert.DeserializeObject<Good>(jsonString);
                if (good == null)
                    return null;
                return mapper.Map<GoodDTO>(good);
            }
            else
                return null;
        }

        public async Task CreateGood(GoodDTO dto)
        {
            var good = mapper.Map<Good>(dto);

            var content = JsonConvert.SerializeObject(good);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);

            byteContent.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

            HttpResponseMessage response = await client.PostAsync($"api/Goods/", byteContent);

        }

        public async Task UpdateGood(GoodDTO dto)
        {
            var good = mapper.Map<Good>(dto);

            var content = JsonConvert.SerializeObject(good);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);

            byteContent.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

            HttpResponseMessage response = await client.PutAsync($"api/Goods/{good.Id}", byteContent);
            response.EnsureSuccessStatusCode();

        }

        public async Task DeleteGood(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"api/Goods/{id}");
            response.EnsureSuccessStatusCode();
        }
    }

}

