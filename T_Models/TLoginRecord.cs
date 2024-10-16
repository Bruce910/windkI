using System;
using System.Collections.Generic;

namespace Final10._14.Models;

public partial class TLoginRecord
{
    public int FLogId { get; set; }

    public string? FMemberId { get; set; }

    public byte[]? FTimestamp { get; set; }

    public string? FIp { get; set; }
}
