﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaDB_Migration.Models
{
  public class LeaveRequest
  {
    [Key]
    public int Id { get; set; }

    [ForeignKey(nameof(Models.Employee.Id))]
    public Employee Employee { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string Description { get; set; }
  }
}
