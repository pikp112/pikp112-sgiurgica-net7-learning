namespace WhiteDentalClinic.Application.Models.Dentist
{
    public class UpdateDentistRequestModel
    {
        public string Email { get; set; }
        public Guid MedicalServiceId { get; set; }
    }
}