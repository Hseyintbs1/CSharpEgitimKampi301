using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concreate
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
    }
}

/*
        SOLİD
        S: Single Responsibility Principle (Tek Sorumluluk ilkesi): Bir sınıfın bir tek sorumluluğu olmalıdır. Sadece bir iş yapmalıdır.
        O: Open Closed Principle
        L: Liskov Substitution Principle
        I: Interface Segregation Principle
        D: Dependency Inversion Principle
 */