﻿using System;
using System.Collections.Generic;

namespace Final10._14.Models;

public partial class TProduct
{
    public int FProductId { get; set; }

    public int FProductCategoryId { get; set; }

    public int? FSponsorId { get; set; }

    public string? FProductName { get; set; }

    public string? FDescription { get; set; }

    public int? FSales { get; set; }

    public int? FStock { get; set; }

    public int? FUnitlHelpPoint { get; set; }

    public int? FStatus { get; set; }
}
