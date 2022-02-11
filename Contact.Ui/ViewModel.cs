using System;
using System.Collections.Generic;
using System.Text;
using Contact.Data.Models;
using Contact.Data.Repositories;

namespace Contact.Ui
{
	public class ViewModel
	{
		private PersonRepository repository;
		public ViewModel(PersonRepository repository)
		{
			this.repository = repository;
		}

		public IEnumerable<Person> Refresh()
		{
			return repository.Read();
		}
	}
}
