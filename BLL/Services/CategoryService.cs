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
    public class CategoryService : ICategoryService
    {
        HttpClient client;
        IMapper mapper;

        public CategoryService(HttpClient client)
        {
            this.client = client;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Good, GoodDTO>();
                cfg.CreateMap<GoodDTO, Good>();

                cfg.CreateMap<Category, CategoryDTO>();
                cfg.CreateMap<CategoryDTO, Category>();
            });
            mapper = new Mapper(config);
        }

        public async Task CreateCategory(CategoryDTO dto)
        {
            var category = mapper.Map<Category>(dto);

            var content = JsonConvert.SerializeObject(category);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);

            byteContent.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

            HttpResponseMessage response = await client.PostAsync($"api/Categories/", byteContent);
        }

        public async Task DeleteCategory(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"api/Categories/{id}");
            response.EnsureSuccessStatusCode();
        }

        public async Task<CategoryDTO> Get(int id)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync($"api/Categories/{id}");
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var category = JsonConvert.DeserializeObject<Category>(jsonString);
                if (category == null)
                    return null;
                return mapper.Map<CategoryDTO>(category);
            }
            else
                return null;
        }

        public async Task<IEnumerable<CategoryDTO>> GetCategories()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync("api/Categories/");
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var categories = JsonConvert.DeserializeObject<IEnumerable<Category>>(jsonString).ToList();
                if (categories == null)
                    return null;
                return mapper.Map<IEnumerable<CategoryDTO>>(categories);

            }
            else
                return null;
        }

        public async Task UpdateCategory(CategoryDTO dto)
        {
            var category = mapper.Map<Category>(dto);

            var content = JsonConvert.SerializeObject(category);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);

            byteContent.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

            HttpResponseMessage response = await client.PutAsync($"api/Categories/{category.Id}", byteContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
