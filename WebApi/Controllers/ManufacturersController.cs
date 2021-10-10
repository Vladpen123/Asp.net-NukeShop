using DAL.Models;
using DAL.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturersController : ControllerBase
    {
        IUnitOfWork unitOfWork;


        public ManufacturersController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var manufacturers = await unitOfWork.Manufacturers.GetAll();
            return Ok(manufacturers);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var manufacturer = await unitOfWork.Manufacturers.Get(id);
            return Ok(manufacturer);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
                return BadRequest();

            var manufacturer = await unitOfWork.Manufacturers.Get(id);

            if (manufacturer == null)
                return BadRequest();
            await unitOfWork.Manufacturers.Delete(id);
            return Ok(manufacturer);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Manufacturer manufacturer)
        {
            if (manufacturer == null)
                return BadRequest();
            var manufacturerCategory = await unitOfWork.Manufacturers.Add(manufacturer);
            return CreatedAtAction("Get", new { id = manufacturerCategory.Id }, manufacturerCategory);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Manufacturer manufacturer)
        {
            if (id != manufacturer.Id)
                return BadRequest();

            var manufacturerToUpdate = await unitOfWork.Manufacturers.Get(manufacturer.Id);

            if (manufacturerToUpdate == null)
                return NotFound();

            await unitOfWork.Manufacturers.Update(manufacturer);
            return NoContent();
        }
    }
}