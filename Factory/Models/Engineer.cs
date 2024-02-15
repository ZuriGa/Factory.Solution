using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "Engineer name is required")]
    public string EngineerName { get; set; }
    public DateTime HireDate { get; set; } = DateTime.Now;

    public List<EngineerMachine> JoinEntities { get; set; }

  }
}