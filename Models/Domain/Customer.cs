using System.ComponentModel.DataAnnotations;
using technicalAssesment.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;


namespace technicalAssesment.Models.Domain
{
    public class Customer
    {

        [Key]
        public Guid dataId { get; set; }


        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "length can't be more than 8 numbers")]
        public string? cellphone { get; set; }

        [Required]
        [StringLength(50)]
        public string? comment { get; set; }

        //Physical Address
        [Required]
        public string? physicalAddressLine { get; set; }

        [Required]
        public string? physicalSuburb { get; set; }

        [Required]
        public string? physicalCountry { get; set; }

        [Required]
        [StringLength(14, ErrorMessage = "length can't be more than 4 numbers")]
        public string? physicalPostalCode { get; set; }

        //Post Address
        [Required]
        public string? postalAddressLine1 { get; set; }

        [Required]
        public string? postalSuburb { get; set; }

        [Required]
        public string? postalCountry { get; set; }

        [Required]
        [StringLength(14, ErrorMessage = "length can't be more than 4 numbers")]
        public string? postalCode { get; set; }



    }
}
