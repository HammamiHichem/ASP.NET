using System;
using System.ComponentModel.DataAnnotations;

public class MyModel
{
    [FutureDate(ErrorMessage = "La date ne peut pas être dans le futur.")]
    public DateTime Date { get; set; }
}
