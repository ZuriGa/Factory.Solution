using System;
using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    public string EngineerName { get; set; }
    public DateTime HireDate { get; set; } = DateTime.Now;

    public List<MachineEngineer> JoinEntities { get; set; }

  }
}