using System;
using System.Collections.Generic;

namespace Final10._14.Models;

public partial class TSponsor
{
    public int FSponsorId { get; set; }

    public string? FSponsorName { get; set; }

    public int? FSponsorCategoryId { get; set; }

    public string? FAddress { get; set; }

    public string? FPhone { get; set; }

    public decimal? FCapital { get; set; }

    public string? FIntroduction { get; set; }

    public int? FStatus { get; set; }
}
