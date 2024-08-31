using System;
using System.Collections.Generic;

namespace AdventureWorks.Models;

public partial class VIndividualCustomer
{
    public int BusinessEntityId { get; set; }

    public string? Title { get; set; }

    public string? Suffix { get; set; }

    public string? EmailAddress { get; set; }

    public int EmailPromotion { get; set; }

    public string AddressLine1 { get; set; } = null!;

    public string? AddressLine2 { get; set; }

    public string City { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public string? Demographics { get; set; }
}
