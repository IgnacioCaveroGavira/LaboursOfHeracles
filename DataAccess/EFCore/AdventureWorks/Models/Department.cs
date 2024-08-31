using System;
using System.Collections.Generic;

namespace AdventureWorks.Models;

/// <summary>
/// Lookup table containing the departments within the Adventure Works Cycles company.
/// </summary>
public partial class Department
{
    /// <summary>
    /// Primary key for Department records.
    /// </summary>
    public short DepartmentId { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; } = new List<EmployeeDepartmentHistory>();
}
