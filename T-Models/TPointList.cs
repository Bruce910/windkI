using System;
using System.Collections.Generic;

namespace Final10._14.Models;

public partial class TPointList
{
    public int FPointListId { get; set; }

    public string? FMemberId { get; set; }

    public int? FMatchId { get; set; }

    public int? FOrderId { get; set; }

    public int? FSourse { get; set; }

    public DateTime? FRecordTime { get; set; }
}
