using System;
using System.Collections.Generic;

namespace AdventureWorks.Models;

/// <summary>
/// Lookup table of customer purchase reasons.
/// </summary>
public partial class SalesReason
{
    /// <summary>
    /// Primary key for SalesReason records.
    /// </summary>
    public int SalesReasonId { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    public DateTime ModifiedDate { get; set; }

    public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; } = new List<SalesOrderHeaderSalesReason>();
}
