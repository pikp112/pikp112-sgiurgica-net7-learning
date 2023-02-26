using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteDentalClinic.DataAccess.Entities.DentistEntity;

namespace WhiteDentalClinic.DataAccess.Entities.MedicalServiceEntity
{
    public class MedicalService
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public List<Dentist> Dentists { get; set; }
    }
}
