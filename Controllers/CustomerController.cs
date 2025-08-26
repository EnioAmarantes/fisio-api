using Application;
using Application.Requests;
using Application.Views;
using Microsoft.AspNetCore.Mvc;

namespace Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _customerService;

    public CustomerController(ICustomerService customerService)
        => _customerService = customerService;

    [HttpGet("{code}")]
    [ProducesResponseType(typeof(CustomerView), 200)]
    [ProducesResponseType(404)]
    [ProducesResponseType(500)]
    [Produces("application/json")]
    public async Task<IActionResult> GetCustomerByCode(Guid code)
    {
        var customer = await _customerService.GetCustomerByCodeAsync(code);
        if (customer == null)
        {
            return NotFound();
        }
        return Ok(customer);
    }

    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<CustomerListView>), 200)]
    [ProducesResponseType(404)]
    [ProducesResponseType(500)]
    [Produces("application/json")]
    public async Task<IActionResult> GetAllCustomers()
    {
        var customers = await _customerService.GetAllCustomersAsync();
        return Ok(customers);
    }

    [HttpPost]
    [ProducesResponseType(typeof(CustomerView), 201)]
    [ProducesResponseType(400)]
    [ProducesResponseType(500)]
    [Produces("application/json")]
    [Consumes("application/json")]
    public async Task<IActionResult> AddCustomer([FromBody] CustomerRequest customerRequest)
    {
        if (customerRequest == null)
        {
            return BadRequest("Customer data is required.");
        }

        CustomerView customerView = await _customerService.AddCustomerAsync(customerRequest);
        return CreatedAtAction(nameof(GetCustomerByCode), new { code = customerView.Code }, customerRequest);
    }

    [HttpPut("{code}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(400)]
    [ProducesResponseType(404)]
    [ProducesResponseType(500)]
    [Produces("application/json")]
    [Consumes("application/json")]
    public async Task<IActionResult> UpdateCustomer(Guid code, [FromBody] CustomerRequest customerRequest)
    {
        if (customerRequest == null)
        {
            return BadRequest("Customer data is required.");
        }
        var existingCustomer = await _customerService.GetCustomerByCodeAsync(code);
        if (existingCustomer == null)
        {
            return NotFound();
        }
        await _customerService.UpdateCustomerAsync(code, customerRequest);
        return NoContent();
    }

    [HttpDelete("{code}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(404)]
    [ProducesResponseType(500)]
    [Produces("application/json")]
    public async Task<IActionResult> DeleteCustomer(Guid code )
    {
        var existingCustomer = await _customerService.GetCustomerByCodeAsync(code);
        if (existingCustomer == null)
        {
            return NotFound();
        }
        await _customerService.DeleteCustomerAsync(code);
        return NoContent();
    }
}