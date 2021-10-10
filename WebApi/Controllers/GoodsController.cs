using DAL.Models;
using DAL.Repositories;
using DAL.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/")]
    public class GoodsController : ControllerBase
    {
        IUnitOfWork unitOfWork;

        public GoodsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var goods = (await unitOfWork.Goods.GetAll())
                //Where(x=>x.CategoryId == category)
                //Where(x => x.ManufacturerId == manufacturer).
                //Where(x => x.Gender.Equals(gender))
                .ToList();
            return Ok(goods);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var good = await unitOfWork.Goods.Get(id);
            if (good != null)
                return Ok(good);
            return BadRequest();
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
                return BadRequest();

            var good = await unitOfWork.Goods.Get(id);

            if (good == null)
                return BadRequest();
            await unitOfWork.Goods.Delete(id);
            return Ok(good);
        }

        [HttpPost]

        public async Task<IActionResult> Create(Good good)
        {
            if (good == null)
                return BadRequest();
            var createdGood = await unitOfWork.Goods.Add(good);
            return CreatedAtAction("Get", new { id = createdGood.Id }, createdGood);
        }


        [HttpPut("{id}")]

        public async Task<IActionResult> Update(int id, Good good)
        {
            if (id != good.Id)
                return BadRequest();

            var goodToUpdate = await unitOfWork.Goods.Get(good.Id);

            if (goodToUpdate == null)
                return NotFound();

            await unitOfWork.Goods.Update(good);
            return Ok(goodToUpdate);
        }
    }
}
