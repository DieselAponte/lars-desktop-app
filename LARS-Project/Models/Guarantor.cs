namespace LARS_Project.Models;

public class Guarantor
{
    private int Id { get; set; }
    private int IdBorrower { get; set; }
    private string Name { get; set; }
    private string LastName { get; set; }
    private decimal EconomicIncome { get; set; }
    private string Description { get; set; }
    private string PhoneNumber { get; set; }
    private string Address { get; set; }
    private string RelationWithBorrower { get; set; }

    public Guarantor(int idBorrower, string name, string lastName, decimal economicIncome, string phoneNumber,
        string address, string relationWithBorrower)
    {
        this.IdBorrower = idBorrower;
        this.Name = name;
        this.LastName = lastName;
        this.EconomicIncome = economicIncome;
        this.PhoneNumber = phoneNumber;
        this.Address = address;
        this.RelationWithBorrower = relationWithBorrower;
    }
}