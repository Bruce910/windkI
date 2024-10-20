﻿using System;
using System.Collections.Generic;

namespace Final10._14.Models;

public partial class TPersonMember
{
    public int FPersonSid { get; set; }

    public string? FMemberId { get; set; }

    public string? FAccount { get; set; }

    public string? FPassword { get; set; }

    public string? FUserName { get; set; }

    public string? FFirstName { get; set; }

    public string? FLastName { get; set; }

    public string? FEmail { get; set; }

    public string? FIdentification { get; set; }

    public DateOnly? FBirthDate { get; set; }

    public string? FSex { get; set; }

    public DateOnly? FRegDate { get; set; }

    public int? FTotalHelpPoint { get; set; }

    public int? FTotalAsset { get; set; }

    public int? FDistrictId { get; set; }

    public string? FStatus { get; set; }

    public int? FPermissions { get; set; }

    public string? FIp { get; set; }

    public byte[]? FMemberImage { get; set; }
}
