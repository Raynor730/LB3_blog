using System;
using System.Collections.Generic;

namespace LB3_blog;

public partial class Post
{
    public int Id { get; set; }

    public int? IdUser { get; set; }

    public string? TIrle { get; set; }

    public string? Content { get; set; }

    public DateTime? DateOfPublication { get; set; }

    public virtual User? IdUserNavigation { get; set; }
}
