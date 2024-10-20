﻿using System;
using System.Collections.Generic;

namespace Final10._14.Models;

public partial class TGroupMember
{
    public int FGroupSid { get; set; }

    public string? FMemberId { get; set; }

    public string? FAccount { get; set; }

    public string? FPassword { get; set; }

    public string? FCorporation { get; set; }

    public string? FEmail { get; set; }

    public string? FRepresentName { get; set; }

    public string? FCoLocation { get; set; }

    public string? FUniBusinessNo { get; set; }

    public int? FTotalCapital { get; set; }

    public DateOnly? FRegDate { get; set; }

    public string? FStatus { get; set; }

    public int? FPermissions { get; set; }

    public string? FIp { get; set; }
}
