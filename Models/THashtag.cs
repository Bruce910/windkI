using System;
using System.Collections.Generic;

namespace Final10._14.Models;

public partial class THashtag
{
    public int FHashTagSid { get; set; }

    public string? FHashTag { get; set; }

    public int? FPostId { get; set; }

    public string? FUserId { get; set; }

    public string? FMemberType { get; set; }
}
