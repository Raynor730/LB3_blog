using System;
using System.Collections.Generic;

namespace LB3_blog;

public partial class User
{
    public int Id { get; set; }

    public string Nikname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Phone { get; set; }

    public DateTime? Birthday { get; set; }
}
