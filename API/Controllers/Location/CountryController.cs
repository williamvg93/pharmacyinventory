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

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Country>>> Get()
    {
        var countries = await _unitOfWork.Countries.GetAllAsync();
        return Ok(countries);
    }
}
