using System.Collections.Generic;
using System.Collections;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SweetSavoryTreats.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }

    public virtual ApplicationUser User { get; set; }

    [Display(Name="Treat Id")]
    public int TreatId { get; set; }

    [Display(Name="Treat Name")]
    public string TreatName { get; set; }

    public virtual ICollection<FlavorTreat> JoinEntities { get; set; }
  }
}
