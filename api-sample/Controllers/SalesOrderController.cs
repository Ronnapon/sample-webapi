using api_sample.DataTransferObjects;
using api_sample.Services;
using Microsoft.AspNetCore.Mvc;

namespace api_sample.Controllers;

[ApiController]
[Route("[controller]")]
public class SalesOrderController : ControllerBase
{
    private readonly SalesOrderService _saleOrderService;

    public SalesOrderController(SalesOrderService salesOrderService)
    {
        _saleOrderService = salesOrderService;
    }

    // GET
    [HttpGet]
    public IActionResult GetItem(string docNumber)
    {
        _saleOrderService.GetItem(docNumber);
        return Ok();
    }
    
    // Delete
    [HttpDelete]
    public IActionResult CreateItem(string docNumber)
    {
        _saleOrderService.DeleteItem(docNumber);
        return Ok();
    }
    // Post
    [HttpPost]
    public IActionResult AddItem(SalesOrderForCreateDto salesOrderForCreateDto)
    {
        _saleOrderService.CreateItem(salesOrderForCreateDto);
        return Ok();
    }
    // Put
    [HttpPut]
    public IActionResult UpdateItem(string docNumber, SalesOrderForUpdateDto salesOrderForUpdateDto)
    {
        _saleOrderService.UpdateItem(docNumber, salesOrderForUpdateDto);
        return Ok();
    }
}