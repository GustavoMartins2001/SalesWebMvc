using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double Salary { get; set; }
        public Departament Departament { get; set; }

        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {

        }

        public Seller(int id, string name, string email, DateTime birthDate, double salary, Departament departament)
        {
            Id = id;
            Name = name;
            Email = email;
            Salary = salary;
            BirthDate = birthDate;
            Departament = departament;
        }

        public void AddSales(SalesRecord sale)
        {
            Sales.Add(sale);
        }
        public void RemoveSales(SalesRecord sale)
        {
            Sales.Remove(sale);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
           return Sales.Where(sale => sale.Date >= initial && sale.Date <= final).Sum(sale => sale.Amount);
        }
    }
}
