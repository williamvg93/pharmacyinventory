using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.entities.Location;
using Infrastructure.Data;
using Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers.Location;

public class CountryController : BaseController
{
    private readonly UnitOfWork _unitOfWork;

    public CountryController(UnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    /* Obtener todas las Countries */
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Country>>> Get()
    {
        var countries = await _unitOfWork.Countries.GetAllAsync();
        return Ok(countries);
    }

    /* Obtener Country por el ID */
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<Country>> Get(int id)
    {
        var country = await _unitOfWork.Countries.GetByIdAsync(id);
        if (country == null)
        {
            return NotFound();
        }
        return country;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Country>> Post(Country country)
    {
        this._unitOfWork.Countries.Add(country);
        await _unitOfWork.SaveAsync();
        if (country == null)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post), new { id = country.Id }, country);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Country>> Put(int id, [FromBody] Country country)
    {
        if (country.Id == 0)
        {
            country.Id = id;
        }
        if (country.Id != id)
        {
            return BadRequest();
        }
        if (country == null)
        {
            return NotFound();
        }
        _unitOfWork.Countries.Update(country);
        await _unitOfWork.SaveAsync();
        return country;
    }

}
