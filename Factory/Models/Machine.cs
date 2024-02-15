using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "Machine name is required")]
    public string MachineName { get; set; }
    [Required(ErrorMessage = "Installation date is required")]
    public string Installed { get; set; }

    public List<EngineerMachine> JoinEntities { get; set; }
  }
}