using DAL.Models;
using DAL.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        IUnitOfWork unitOfWork;


        public CategoriesController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await unitOfWork.Categories.GetAll();
            return Ok(categories);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var category = await unitOfWork.Categories.Get(id);
            return Ok(category);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
                return BadRequest();

            var category = await unitOfWork.Categories.Get(id);

            if (category == null)
                return BadRequest();
            await unitOfWork.Categories.Delete(id);
            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            if (category == null)
                return BadRequest();
            var createdCategory = await unitOfWork.Categories.Add(category);
            return CreatedAtAction("Get", new { id = createdCategory.Id }, createdCategory);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Category category)
        {
            if (id != category.Id)
                return BadRequest();

            var categoryToUpdate = await unitOfWork.Categories.Get(category.Id);

            if (categoryToUpdate == null)
                return NotFound();

            await unitOfWork.Categories.Update(category);
            return NoContent();
        }

    }

}
