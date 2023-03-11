﻿using System.ComponentModel.DataAnnotations;

namespace WhiteDentalClinic.Application.Models.AppointmentModel
{
    public class CreateAppointmentRequestModel
    {
        public Guid Id = Guid.NewGuid();
        public DateTime dateTime { get; set; }
        public Guid CustomerId { get; set; }
        public Guid DentistId { get; set; }
    }
}