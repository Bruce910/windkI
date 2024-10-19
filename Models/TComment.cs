﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final10._14.Models;

public partial class TComment
{
    [Key]
    public int FCommentId { get; set; }

    [Required(ErrorMessage = "請選擇貼文")]
    public int FPostId { get; set; }

    [Required(ErrorMessage = "請登入後再留言")]
    public int FUserId { get; set; }

    [Required(ErrorMessage = "留言內容不能為空")]
    [StringLength(500, ErrorMessage = "留言內容不能超過500個字符")]
    [Display(Name = "留言內容")]
    public string FContent { get; set; }

    [Display(Name = "留言時間")]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime FCommentTime { get; set; }

    [ForeignKey("FPostId")]
    public virtual TPost FPost { get; set; }
    [ForeignKey("FUserId")]
    public virtual TPersonMember FUser { get; set; }
}
