using System;

namespace Livros
{
   class Loan
{
    public DateTime LoanDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public DateTime EstimatedReturnDate { get; set; }
    public Person Person { get; set; }
    public Book Book { get; set; }
    public bool Late { get; private set; }

    public Loan(Person person, Book book)
    {
        LoanDate = DateTime.Now;
        EstimatedReturnDate = LoanDate.AddDays(15); 
        Person = person;
        Book = book;
        Late = false;
    }

    public void Return()
    {
        ReturnDate = DateTime.Now;

        if (ReturnDate > EstimatedReturnDate)
        {
            Late = true;
        }
    }
}

}