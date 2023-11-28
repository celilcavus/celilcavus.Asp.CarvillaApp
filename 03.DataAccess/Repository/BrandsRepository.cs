using _01.Entity;
using _03.DataAccess.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DataAccess.Repository
{
	public class BrandsRepository : Repository<Brands>, IBrandsRepository
	{
		public BrandsRepository()
		{

		}

	
	}
}
