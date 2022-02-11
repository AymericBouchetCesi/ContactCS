using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contact.Data.Models;

namespace Contact.Data.Repositories
{
	public class PersonRepository
	{
		private DataContext context = new DataContext();
		public IEnumerable<Person> Read()
		{
			return context.people.ToList();
		}
	}
}
