using System;
using System.Collections.Generic;

namespace Final10._14.Models;

public partial class THelpMessageRecord
{
    public int FMessageRecord { get; set; }

    public int? FHelpId { get; set; }

    public string? FContent { get; set; }

    public DateTime? FSendDate { get; set; }

    public int? FPublicOrNot { get; set; }
}
