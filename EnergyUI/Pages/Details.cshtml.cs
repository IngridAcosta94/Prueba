using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnergyController.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EnergyUI.Pages
{
    public class DetailsModel : PageModel
    {

        private readonly IRepository repository;
        public Container Container { get; private set; }

        public DetailsModel(IRepository repository)
        {
            this.repository = repository;
        }
        public void OnGet(int id)
        {
            Container = repository.Get(id);
        }

    }
}
