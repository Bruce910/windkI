﻿using System;
using System.Collections.Generic;

namespace Final10._14.Models;

public partial class TPost
{
    public int FPostId { get; set; }

    public string? FUserId { get; set; }

    public string? FUserName { get; set; }

    public string? FPostContent { get; set; }

    public int? FLikes { get; set; }

    public byte[]? FTimestamp { get; set; }

    public string? FMemberType { get; set; }

    public int? FParentCommentId { get; set; }

    public byte[]? FFinStatement { get; set; }
}
