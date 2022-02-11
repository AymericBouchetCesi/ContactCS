using System;
using Contact.Data.Repositories;

namespace Contact.Ui
{
	class Program
	{
		static void Main(string[] args)
		{
			PersonRepository personRepository = new PersonRepository();
			ViewModel viewModel = new ViewModel(personRepository);

			foreach (var item in viewModel.Refresh())
			{
				Console.WriteLine(item.Name);
			}
		}
	}
}
