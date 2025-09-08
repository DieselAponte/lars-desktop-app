using System;

namespace LARS_Project.Models;

public class Loan
{
    private int Id { get; set; }
    private int IdBorrower { get; set; }
    private string Status { get; set; }
    private decimal LoanCapital { get; set; }
    private decimal InterestRate { get; set; }
    private string PurposeOfLoan { get; set; }
    private string DocumentPath { get; set; }
    private DateTime StartDate { get; set; }
    private DateTime EndDate { get; set; }

    public Loan(int idBorrower, decimal loanCapital, decimal interestRate, string purposeOfLoan, string documentPath)
    {
        this.IdBorrower = idBorrower;
        this.LoanCapital = loanCapital;
        this.InterestRate = interestRate;
        this.PurposeOfLoan = purposeOfLoan;
        this.DocumentPath = documentPath;
    }
}