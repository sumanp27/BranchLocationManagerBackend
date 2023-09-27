using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.ModelBuilder;
using WebAppAPI.Data;
using WebAppAPI.Models.Branch;

namespace WebAppAPI.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]

    public class BranchesController : ControllerBase
    {
        private readonly DemoProjectDbContext _context;
        private readonly IMapper _mapper;

        public BranchesController(DemoProjectDbContext context,IMapper mapper)
        {
            this._context = context;
          this._mapper = mapper;
        }

      

        // GET: api/Branches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BranchDto>>> GetBranches()
        {

          if (_context.Branches == null)
          {
              return NotFound();
          }
           var branches= await _context.Branches.ToListAsync();

            return Ok(branches);

        }

        // GET: api/Branches/5
        [HttpGet("{buCode5}")]
        public async Task<ActionResult<BranchDto>> GetBranch(string buCode5)
        {
          if (_context.Branches == null)
          {
              return NotFound();
          }
            var branch = await _context.Branches.FindAsync(buCode5);
            if (branch == null)
            {
                return NotFound();
            }
           // var records = new BranchDto();
            //else
            //{
            //    var records = new BranchDto
            //    {

            //        BuCode5 = branch.BU_CODE5,
            //        OpenedDt = branch.OPENED_DT,
            //        Address = branch.ADDRESS,
            //        City = branch.CITY,
            //        StateName = branch.STATE_NAME,
            //        CountryName = branch.COUNTRY_NAME,
            //        Currency = branch.CURRENCY,
            //        Phone = branch.PHONE,
            //        BusinessHours = branch.BUSINESS_HOURS,
            //        Latitude = branch.LATITUDE,
            //        Longitude = branch.LONGITUDE,
            //    };
            //}

            return Ok(branch);
        }

        // PUT: api/Branches/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{buCode5}")]
        //[Authorize]
        public async Task<IActionResult> PutBranch(string buCode5, BranchDto branchDto)
        {
            if (buCode5 != branchDto.BuCode5)
            {
                return BadRequest();
            }

            var branch = await _context.Branches.FindAsync(buCode5);
            

            if (branch == null)
            {
               return NotFound();
                //throw new NotFoundException(nameof(GetCountry), id);
            }
            

            try
            {
                //_context.Entry(branchDto).State=EntityState.Modified;


                branch.BuCode5 = branchDto.BuCode5;
                branch.OpenedDt = branchDto.OpenedDt;
                branch.Address = branchDto.Address;
                branch.City = branchDto.City;
                branch.StateName = branchDto.StateName;
                branch.CountryName = branchDto.CountryName;
                branch.Currency = branchDto.Currency;
                branch.Phone = branchDto.Phone;
                branch.BusinessHours = branchDto.BusinessHours;
                branch.Latitude = branchDto.Latitude;
                branch.Longitude = branchDto.Longitude;
                branch.Status=branchDto.Status;
                    
                

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BranchExists(buCode5))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Branches
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        //[Authorize]
        public async Task<ActionResult<BranchDto>> PostBranch(BranchDto postBranchDto)
        {

           

            

            if (_context.Branches == null)
          {
              return Problem("Entity set 'DemoProjectDbContext.Branches'  is null.");
          }
            _context.Branches.Add(postBranchDto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBranch",new {buCode5 =postBranchDto.BuCode5}, postBranchDto);
          
        }

        // DELETE: api/Branches/5
        [HttpDelete("{buCode5}")]
        //[Authorize]
        public async Task<IActionResult> DeleteBranch(string buCode5)
        {
            if (_context.Branches == null)
            {
                return NotFound();
            }
            var branch = await _context.Branches.FindAsync(buCode5);
            if (branch == null)
            {
                return NotFound();
            }

            _context.Branches.Remove(branch);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BranchExists(string buCode5)
        {
            return (_context.Branches?.Any(e => e.BuCode5 == buCode5)).GetValueOrDefault();
          
        }
    }
}
