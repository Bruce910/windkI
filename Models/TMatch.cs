using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Final10._14.Models;

public partial class TMatch
{
    [DisplayName("媒合單號")]
    public int FMatchId { get; set; }

    [DisplayName("求助單號")]
    public int? FHelpId { get; set; }

    [DisplayName("會員編號")]
    public string? FMemberId { get; set; }

    [DisplayName("時間")]
    public DateTime? FMatchDateTime { get; set; }

    [DisplayName("點數")]
    public int? FPoint { get; set; }

    [DisplayName("狀態")]
    public int? FMatchStatus { get; set; }

    [DisplayName("評分")]
    public int? FGrade { get; set; }

    [DisplayName("評分時間")]
    public DateTime? FGradeDateTime { get; set; }

    [DisplayName("留言")]
    public string? FMessage { get; set; }

    

}
