using System;
using System.Collections.Generic;

namespace AdventureWorks.Models;

/// <summary>
/// Companies from whom Adventure Works Cycles purchases parts or other goods.
/// </summary>
public partial class Vendor
{
    /// <summary>
    /// Primary key for Vendor records.  Foreign key to BusinessEntity.BusinessEntityID
    /// </summary>
    public int BusinessEntityId { get; set; }

    /// <summary>
    /// 1 = Superior, 2 = Excellent, 3 = Above average, 4 = Average, 5 = Below average
    /// </summary>
    public byte CreditRating { get; set; }

    /// <summary>
    /// Vendor URL.
    /// </summary>
    public string? PurchasingWebServiceUrl { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    public DateTime ModifiedDate { get; set; }

    public virtual BusinessEntity BusinessEntity { get; set; } = null!;

    public virtual ICollection<ProductVendor> ProductVendors { get; set; } = new List<ProductVendor>();

    public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; } = new List<PurchaseOrderHeader>();
}
