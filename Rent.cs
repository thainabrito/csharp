using RentCars.Types;

namespace RentCars.Models;

public class Rent
{
    public Vehicle Vehicle { get; set; }
    public Person Person { get; set; }
    public int DaysRented { get; set; }
    public double Price { get; set; }
    public RentStatus Status { get; set; }
    private double _taxa;

    public Rent(Vehicle vehicle, Person person, int daysRented)
    {
        Vehicle = vehicle;
        Person = person;
        DaysRented = daysRented;
        Price = CalculatePrice();
        Vehicle.IsRented = true;
        Person.Debit = Price;
        Status = RentStatus.Confirmed;
    }

        private double CalculatePrice()
    {
        VerifyTaxa();
        return DaysRented * Vehicle.PricePerDay * _taxa;
    }
    
    private void VerifyTaxa()
    {
        if (Person.GetType() == typeof(LegalPerson))
        {
            _taxa = 0.9;
            return;
        }
        _taxa = 1;
    }
    

    public void Cancel()
    {        
        Status = RentStatus.Canceled;
    }

    public void Finish()
    {        
        Status = RentStatus.Finished;
    }
}
