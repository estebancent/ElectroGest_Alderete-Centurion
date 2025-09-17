using System;
using System.Collections.Generic;

namespace ElectroGest.Models;

public partial class Persona
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public string Tipo { get; set; } = null!;

    public int? Dni { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual Usuario? Usuario { get; set; }
}
