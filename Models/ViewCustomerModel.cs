using System.ComponentModel.DataAnnotations;
using technicalAssesment.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace technicalAssesment.Models
{
    public class ViewCustomerModel
    {

        
        public Guid dataId { get; set; }

        
        public string? FirstName { get; set; }

        
        public string? LastName { get; set; }

        
        public string? cellphone { get; set; }

        public string? comment { get; set; }

        //Physical Address
        public string? physicalAddressLine { get; set; }

        public string? physicalSuburb { get; set; }

        public string? physicalCountry { get; set; }

        public string? physicalPostalCode { get; set; }

        //Post Address
        public string? postalAddressLine1 { get; set; }

        public string? postalSuburb { get; set; }

        public string? postalCountry { get; set; }

        public string? postalCode { get; set; }




    }
}
