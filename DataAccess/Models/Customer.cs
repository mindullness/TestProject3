﻿using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Customer
{
    public long Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Role { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string? CustomerAddress { get; set; }

    public long CustomerPhone { get; set; }
}
