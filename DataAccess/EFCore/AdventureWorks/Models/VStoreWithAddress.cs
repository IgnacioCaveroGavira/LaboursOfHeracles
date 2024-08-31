using System;
using System.Collections.Generic;

namespace AdventureWorks.Models;

public partial class VStoreWithAddress
{
    public int BusinessEntityId { get; set; }

    public string AddressLine1 { get; set; } = null!;

    public string? AddressLine2 { get; set; }

    public string City { get; set; } = null!;

    public string PostalCode { get; set; } = null!;
}
