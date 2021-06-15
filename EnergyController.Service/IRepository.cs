using System;
using System.Collections.Generic;
using System.Text;
using EnergyController.Models;


namespace EnergyController.Service
{
	

	public interface IRepository
	{
		public IEnumerable<Container> GetAll();
		public Container Get1 (int id);

	}









}
