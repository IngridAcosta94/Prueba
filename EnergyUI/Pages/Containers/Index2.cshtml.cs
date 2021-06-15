using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnergyController.Models;
using EnergyController.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnergyUI.Pages.Containers
{
    public class Index2Model : PageModel
    {
        private readonly IRepository repository;
        public IEnumerable<Container> Containers { get; set; }
        public Index2Model(IRepository repository)
        {
            this.repository = repository;
        }
        public void OnGet()
        {
            Containers = repository.GetAll();
        }

        
    }
}
