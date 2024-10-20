﻿using System;
using System.Collections.Generic;

namespace Final10._14.Models;

public partial class TComment
{
    public int FCommentId { get; set; }

    public int? FPostId { get; set; }

    public string? FUserId { get; set; }

    public string? FContent { get; set; }

    public DateOnly? FCratedAt { get; set; }

    public DateOnly? FUpdateAt { get; set; }
}
