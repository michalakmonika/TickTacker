using Microsoft.AspNetCore.Mvc;
using TickTacker.Application.Services.Interfaces;
using TickTacker.Domain.Entities;

namespace TickTacker.MVC.Controllers;

public class EmployeeController : Controller
{
    private readonly IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Employee employee)
    {
        _employeeService.Create(employee);
        return RedirectToAction(nameof(Create)); // TODO: refactor
    }


}
