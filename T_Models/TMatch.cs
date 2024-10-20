﻿using System;
using System.Collections.Generic;

namespace Final10._14.Models;

public partial class TMatch
{
    public int FMatchId { get; set; }

    public int? FHelpId { get; set; }

    public string? FMemberId { get; set; }

    public DateTime? FMatchDateTime { get; set; }

    public int? FPoint { get; set; }

    public int? FMatchStatus { get; set; }

    public int? FGrade { get; set; }

    public DateTime? FGradeDateTime { get; set; }

    public string? FMessage { get; set; }
}
