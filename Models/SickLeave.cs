﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaDB_Migration.Models
{
  public class SickLeave
  {
    [Key]
    public int Id { get; set; }

    [ForeignKey(nameof(Employee.Id))]
    public int EmployeeId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int Days { get; set; }

    public string Description { get; set; }
  }
}
