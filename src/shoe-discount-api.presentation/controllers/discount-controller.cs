namespace shoe_discount_api.presentation.controllers;

using Microsoft.AspNetCore.Mvc;
using shoe_discount_api.application.dtos;
using shoe_discount_api.application.services;

[ApiController]
[Route("api/[controller]")]
public class DiscountController : ControllerBase
{
    private readonly DiscountApplicationService _service;

    public DiscountController(DiscountApplicationService service)
    {
        _service = service;
    }

    [HttpPost("check")]
    public IActionResult Check([FromBody] DiscountRequest request)
    {
        if (request.OriginalPrice <= 0)
            return BadRequest("El precio debe ser mayor a 0");

        var response = _service.CheckDiscount(request);
        return Ok(response);
    }
}
