using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Departament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Departament()
        {

        }

        public Departament(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {

            //solução com Linq
            return Sellers.Sum(seller => seller.TotalSales(initial, final));

            //Solução com função, coloquei apenas para entender melhor
            // o que a solução Linq acima esta fazendo.
            /*
            double total = 0;
            foreach(var sr in Sellers)
            {
                total += sr.TotalSales(initial, final);
            }
            return total;
            */
        }
    }
}
