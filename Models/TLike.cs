﻿using System;
using System.Collections.Generic;

namespace Final10._14.Models;

public partial class TLike
{
    public int FLikesSid { get; set; }

    public string? FUserId { get; set; }

    public string? FPostId { get; set; }

    public string? FTimestamp { get; set; }
}
