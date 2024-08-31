using System;
using System.Collections.Generic;

namespace AdventureWorks.Models;

public partial class VStateProvinceCountryRegion
{
    public int StateProvinceId { get; set; }

    public string StateProvinceCode { get; set; } = null!;

    public int TerritoryId { get; set; }

    public string CountryRegionCode { get; set; } = null!;
}
