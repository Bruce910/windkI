﻿using System;
using System.Collections.Generic;

namespace Final10._14.Models;

public partial class TOrderDetail
{
    public int FOrderDetailId { get; set; }

    public int FOrderId { get; set; }

    public int? FProductId { get; set; }

    public int? FAmount { get; set; }

    public int? FHelpPoint { get; set; }
}
