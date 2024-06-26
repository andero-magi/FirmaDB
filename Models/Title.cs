﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirmaDB_Migration.Models
{
  public class Title
  {
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string Name { get; set; }

    [ForeignKey(nameof(Employee.Id))]
    public int EmployeeId { get; set; }
  }
}
