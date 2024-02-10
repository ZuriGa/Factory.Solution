using System;
using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }

    public string MachineName { get; set; }

    public string Installed { get; set; }

    public List<MachineEngineer> JoinEntities { get; set; }
  }
}