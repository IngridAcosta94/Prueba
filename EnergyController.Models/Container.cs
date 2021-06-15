using System;

namespace EnergyController.Models
{
	public class Container
	{
        
            public int ContainerId { get; set; }
            public string ProductDimensions { get; set; }
            public string ItemWeight { get; set; }
            public string Manufacturer { get; set; }
            public string ASIN { get; set; } 
            public string ItemModelNumber { get; set; }
            public double Capacity { get; set; }
            public string Owner { get; set; }
            public string Location { get; set; }


        public int WorkshopId { get; set; }
        public WorkShop WorkShop { get; set; }


    }
}
