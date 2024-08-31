using System;
using System.Collections.Generic;

namespace AdventureWorks.Models;

public partial class VEmployeeDepartment
{
    public int BusinessEntityId { get; set; }

    public string? Title { get; set; }

    public string? Suffix { get; set; }

    public string JobTitle { get; set; } = null!;

    public DateOnly StartDate { get; set; }
}
