namespace shoe_discount_api.presentation.controllers;

using Microsoft.AspNetCore.Mvc;
using shoe_discount_api.infrastructure.data;

[ApiController]
[Route("api")]
public class CatalogController : ControllerBase
{
    [HttpGet("membership/status")]
    public IActionResult GetMembershipStatuses()
    {
        return Ok(CatalogData.MembershipStatuses);
    }

    [HttpGet("shoe/brands")]
    public IActionResult GetBrands()
    {
        return Ok(CatalogData.ShoeBrands);
    }

    [HttpGet("shoe/seasons")]
    public IActionResult GetSeasons()
    {
        return Ok(CatalogData.ShoeSeasons);
    }
}