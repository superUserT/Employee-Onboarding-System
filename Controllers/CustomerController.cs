using Microsoft.AspNetCore.Mvc;
using technicalAssesment.Models.Domain;
using technicalAssesment.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;
using technicalAssesment.Data;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data.SqlClient;
using System.Configuration;

namespace technicalAssesment.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerDbContext customerDbContext;

        public CustomerController(CustomerDbContext customerDbContext)
        {
            this.customerDbContext = customerDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var customer = await customerDbContext.CustomerData.ToListAsync();
            return View(customer);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }

        public async Task<IActionResult> ReadMore(string? name)
        {
            if (name == null)
            {
                return NotFound();
            }

            var customer = await customerDbContext.CustomerData.FirstOrDefaultAsync(c => c.FirstName == name);

            if (customer == null)
            {
                return NotFound();
            }
           
            return View(customer);
            
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer(AddCustomerModel addCustomerRequest)
        {
            var customer = new Customer()
            {
                dataId = Guid.NewGuid(),
                FirstName = addCustomerRequest.FirstName,
                LastName = addCustomerRequest.LastName,
                cellphone = addCustomerRequest.cellphone,
                comment = addCustomerRequest.comment,

                physicalAddressLine = addCustomerRequest.physicalAddressLine,
                physicalSuburb = addCustomerRequest.physicalSuburb,
                physicalCountry = addCustomerRequest.physicalCountry,
                physicalPostalCode = addCustomerRequest.physicalPostalCode,
                
                postalAddressLine1 = addCustomerRequest.postalAddressLine1,
                postalCode = addCustomerRequest.postalCode,
                postalSuburb = addCustomerRequest.postalSuburb,
                postalCountry = addCustomerRequest.postalCountry
     

            };


            await customerDbContext.CustomerData.AddAsync(customer);
            await customerDbContext.SaveChangesAsync();
            return RedirectToAction("Index");

            
        }



        [HttpGet]
        public async Task<IActionResult> View(Guid id)
        {
            var customerdata = await customerDbContext.CustomerData.FirstOrDefaultAsync(x => x.dataId == id);

            if (customerdata != null)
            {
                var viewModel = new ViewCustomerModel()
                {
                    dataId = customerdata.dataId,
                    FirstName = customerdata.FirstName,
                    LastName = customerdata.LastName,
                    cellphone = customerdata.cellphone,
                    comment = customerdata.comment,
                    physicalAddressLine = customerdata.physicalAddressLine,
                    physicalSuburb = customerdata.physicalSuburb,
                    physicalCountry = customerdata.physicalCountry, 
                    postalCode = customerdata.postalCode,  
                    postalAddressLine1 = customerdata.postalAddressLine1,
                    postalSuburb = customerdata.postalSuburb,
                    postalCountry = customerdata.postalCountry, 
                    physicalPostalCode = customerdata.physicalPostalCode,

                };
                return await Task.Run(() => View("View", viewModel));

            }
            return RedirectToAction("Index");

        }

        [HttpPost]
        public async Task<IActionResult> View(ViewCustomerModel model)
        {
            var customer = await customerDbContext.CustomerData.FindAsync(model.dataId);

            if (customer != null)
            {

                customer.FirstName = model.FirstName;
                customer.LastName = model.LastName;
                customer.cellphone = model.cellphone;
                customer.comment = model.comment;
                customer.physicalAddressLine = model.physicalAddressLine;
                customer.physicalSuburb = model.physicalSuburb;
                customer.physicalCountry = model.physicalCountry;
                customer.postalCode = model.postalCode;
                customer.postalAddressLine1 = model.postalAddressLine1;
                customer.postalSuburb = model.postalSuburb;
                customer.physicalPostalCode = model.physicalPostalCode;
                customer.postalCountry = model.postalCountry;
              

                await customerDbContext.SaveChangesAsync();

                return RedirectToAction("Index");

            }
            return RedirectToAction("Index");
        }

    }
}
