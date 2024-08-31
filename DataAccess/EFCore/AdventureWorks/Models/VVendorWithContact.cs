using System;
using System.Collections.Generic;

namespace AdventureWorks.Models;

public partial class VVendorWithContact
{
    public int BusinessEntityId { get; set; }

    public string? Title { get; set; }

    public string? Suffix { get; set; }

    public string? EmailAddress { get; set; }

    public int EmailPromotion { get; set; }
}
