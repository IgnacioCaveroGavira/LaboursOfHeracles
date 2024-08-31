using System;
using System.Collections.Generic;

namespace AdventureWorks.Models;

public partial class VEmployeeDepartmentHistory
{
    public int BusinessEntityId { get; set; }

    public string? Title { get; set; }

    public string? Suffix { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }
}
