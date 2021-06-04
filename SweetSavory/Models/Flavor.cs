using System.Collections.Generic;
using System.Collections;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SweetSavoryTreats.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }

    public virtual ApplicationUser User { get; set; }
    
    [Display(Name="Flavor Id")]
    public int FlavorId { get; set; }

    [Display(Name="Flavor Name")]
    public string FlavorName { get; set; }

    public virtual ICollection<FlavorTreat> JoinEntities { get; set; }
  }
}