using System;
using System.Collections.Generic;

namespace Final10._14.Models;

public partial class TOrder
{
    public int FOrderId { get; set; }

    public string? FMemberId { get; set; }

    public int? FTotalHelpPoint { get; set; }

    public int? FStatus { get; set; }

    public DateTime? FOrderTime { get; set; }

    public int? FExecStatus { get; set; }

    public DateTime? FBeginTime { get; set; }

    public DateTime? FFinishTime { get; set; }

    public byte[]? FProof { get; set; }
}
