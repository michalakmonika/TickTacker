using TickTacker.Domain.Entities;
using TickTacker.Domain.Entities.OwnedTypes;
using TickTacker.Infrastructure.Persistence;
using TickTacker.Infrastructure.Seeders.Interfaces;

namespace TickTacker.Infrastructure.Seeders;

public class EmployeeSeeder : ISeeder
{
    private readonly TickTackerDbContext _dbContext;

    public EmployeeSeeder(TickTackerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Seed()
    {
        if(_dbContext.Database.CanConnect() && !_dbContext.Employees.Any())
        {
            var employees = new List<Employee>()
            {
                new Employee()
                {
                    FirstName = "Małgorzata",
                    MiddleName = "Joanna",
                    LastName = "Nowakowska",
                    Pesel = "74113037329",
                    BirthDate = new DateOnly(1974, 11, 30),
                    Address = new Address()
                    {
                        Country = "Polska",
                        City = "Poznań",
                        Street = "Grunwaldzka",
                        HouseNumber = "45C",
                        ApartmentNumber = "16",
                        PostalCode = "60-563",
                        PhoneNumber = "684426539"
                    },
                    EmergencyContact = new EmergencyContact()
                    {
                        FirstName = "Kamil",
                        LastName = "Nowakowski",
                        PhoneNumber = "654321987"
                    },
                    EmploymentId = 1
                },
                new Employee()
                {
                    FirstName = "Antonina",
                    LastName = "Pszczoła",
                    Pesel = "83080525526",
                    BirthDate = new DateOnly(1983, 8, 5),
                    Address = new Address()
                    {
                        Country = "Polska",
                        City = "Poznań",
                        Street = "Kwiatowa",
                        HouseNumber = "18",
                        PostalCode = "61-783",
                        PhoneNumber = "563398856"
                    },
                    EmergencyContact = new EmergencyContact()
                    {
                        FirstName = "Janina",
                        LastName = "Pszczoła",
                        PhoneNumber = "769523698"
                    },
                    EmploymentId = 2
                },
                new Employee()
                {
                    FirstName = "Tomasz",
                    LastName = "Bąkowski",
                    Pesel = "96050624116",
                    BirthDate = new DateOnly(1996, 5, 6),
                    Address = new Address()
                    {
                        Country = "Polska",
                        City = "Luboń",
                        Street = "Sikorskiego",
                        HouseNumber = "56",
                        ApartmentNumber = "5",
                        PostalCode = "62-030",
                        PhoneNumber = "869852845"
                    },
                    EmploymentId = 3
                }
            };

            foreach (Employee employee in employees)
            {
                _dbContext.Employees.Add(employee);
            }

            _dbContext.SaveChanges();
        }
    }
}
