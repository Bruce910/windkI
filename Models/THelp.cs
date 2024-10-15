using System;
using System.Collections.Generic;

namespace Final10._14.Models;

public partial class THelp
{
    public int FHelpId { get; set; }

    public string? FMemberId { get; set; }

    public int? FMemberType { get; set; }

    public string? FName { get; set; }

    public string? FPhone { get; set; }

    public string? FNid { get; set; }

    public int? FTaxId { get; set; }

    public int? FDistrictId { get; set; }

    public string? FHelpDescribe { get; set; }

    public int? FHelpClassId { get; set; }

    public int? FHelpSkillId { get; set; }

    public int? FHelpStatus { get; set; }

    public DateTime? FMfdDate { get; set; }

    public DateTime? FExpDate { get; set; }
}
