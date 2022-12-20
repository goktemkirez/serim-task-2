using System.ComponentModel.DataAnnotations;

namespace SerimTask2.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string? OrganizationId { get; set; }
        public string? CountryId { get; set; }
        public string? ActivationId { get; set; }
        public string? Mobile { get; set; }
        public string? IdentificationNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Gender { get; set; }
        public string? EMail { get; set; }
        public string? CustomerNumber { get; set; }
        public string? Address { get; set; }
        public int? BankId { get; set; }
        public int? AreaCode { get; set; }
        public int? BlackList { get; set; }
        public int? Situation { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool? Status { get; set; }
    }
}
