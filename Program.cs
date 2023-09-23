
using ConsoleFluentValidtion;
using FluentValidation;
using FluentValidation.Results;
using System.ComponentModel.DataAnnotations;

Client client = new Client();


var orders = new List<Order>();
orders.Add(new Order { quantity = 0 });

orders.Add(new Order { quantity = 1 });
orders.Add(new Order { quantity = 2 });
orders.Add(new Order { quantity = 3 });
orders.Add(new Order { quantity = 4 });
orders.Add(new Order { quantity = 5 });
client.Orders = orders;


ClientValidation clientValidation = new ClientValidation();
FluentValidation.Results.ValidationResult result = clientValidation.Validate(client,c=> c.IncludeAllRuleSets());





if (!result.IsValid) { 

    foreach (ValidationFailure failure in result.Errors)
    {
        Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
    }
}