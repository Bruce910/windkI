﻿using System;
using System.Collections.Generic;

namespace Final10._14.Models;

public partial class TMessage
{
    public int FMessid { get; set; }

    public string? FSid { get; set; }

    public string? FRid { get; set; }

    public string? FMessContent { get; set; }

    public byte[]? FTimestamp { get; set; }
}
