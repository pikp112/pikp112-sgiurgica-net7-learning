﻿using WhiteDentalClinic.DataAccess.Entities.AppointmentEntity;
using WhiteDentalClinic.DataAccess.Entities.CommonEntities;
using WhiteDentalClinic.DataAccess.Entities.CustomerDentistEntity;

namespace WhiteDentalClinic.DataAccess.Entities.CustomerEntity
{
    public class Customer : BaseEntity
    {
        public Customer()
        {
            CreatedAt = DateTime.Now;
        }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public override Role Role => Role.Customer;
        public DateTime CreatedAt { get; set; }
        public List<CustomerDentist> Dentists { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
