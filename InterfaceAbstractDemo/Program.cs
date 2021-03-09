using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Adapters;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer {DateOfBirth = new DateTime(1997,1,1), FirstName = "Ahmet Efecan", LastName = "Bayat", NationalityId = "12345678910" });

        }
    }
}
