using System;
using System.Collections.Generic;
using System.Linq;
using EnergyController.Models;

namespace EnergyController.Service
{
	public class MockContainerRepository : IRepository
	{
        private List<Container> _containers;
        public MockContainerRepository()
        {
            _containers = new List<Container>() {
            new Container{ ASIN="1234567890", Capacity = 60.0, ContainerId = 1, ItemModelNumber= "12345", ItemWeight = "45.5", Location = "Domicilio Conocido", Manufacturer = "Oshrans",ProductDimensions = "60 x 60 x 60", WorkShop = new  WorkShop{ PhotoBusiness="Workshops_1.jpg", Name= "Taller el veloz", } },
            new Container{ ASIN="0987654321", Capacity = 40.0, ContainerId = 2, ItemModelNumber= "67890", ItemWeight = "30", Location = "Domicilio Conocido", Manufacturer = "Rythmon",ProductDimensions = "70 x 80 x 100", WorkShop = new  WorkShop{PhotoBusiness="Workshops_2.jpg", Name= "RefaCar" } },
            new Container{ ASIN="1234567890", Capacity = 100.0, ContainerId = 3,ItemModelNumber = "24680", ItemWeight = "70", Location = "Domicilio Conocido", Manufacturer ="Rythmon", ProductDimensions = "60 x 60 x 60",  WorkShop = new  WorkShop{PhotoBusiness="Workshops_3.jpg", Name = "Taller la Anita" } },
            new Container{ ASIN="0987654321", Capacity = 60.0, ContainerId = 4, ItemModelNumber= "13579", ItemWeight = "45.5", Location = "Domicilio Conocido", Manufacturer = "Oshrans",ProductDimensions = "50 x 150 x90",  WorkShop = new WorkShop{PhotoBusiness="Workshops_4.jpg", Name= "Autoservicio Mythic Car"} },
            new Container{ ASIN="1234567890", Capacity = 50.0, ContainerId = 5, ItemModelNumber= "12378", ItemWeight = "50", Location = "Domicilio Conocido", Manufacturer = "LG",ProductDimensions = "90 x 150 x 90",  WorkShop = new  WorkShop{PhotoBusiness=string.Empty, Name ="Taller la Carcacha" } }
            };
            //_containers 
        }

        public IEnumerable<Container> GetAll()
        {
            return _containers;
        }
        public Container Get(int id)
        {
            return _containers.FirstOrDefault(x => x.ContainerId == id);
        }














       


















    }

}
