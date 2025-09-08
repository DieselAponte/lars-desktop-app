using System.Collections.Generic;

namespace LARS_Project.Models;

public class Borrower
{
    private int Id { get; set; }
    private List<Guarantor> Guarantors { get; set; }
    private string Name { get; set; }
    private string LastName { get; set; }
    private string Dni { get; set; }
    private decimal EconomicIncome { get; set; }
    private string Description { get; set; }
    private string PhoneNumber { get; set; }
    private string Address { get; set; }

    public Borrower(List<Guarantor> guarantors, string name, string lastName, string dni, decimal economicIncome,
        string phoneNumbber, string address)
    {
        this.Guarantors = guarantors;
        this.Name = name;
        this.LastName = lastName;
        this.Dni = dni;
        this.EconomicIncome = economicIncome;
        this.PhoneNumber = phoneNumbber;
        this.Address = address;
    }
    
    
}