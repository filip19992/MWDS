using System;
using System.Collections.Generic;

namespace APP.Model;

public partial class Attendence
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public string Name { get; set; } = null!;

    public string? Image { get; set; }
}
