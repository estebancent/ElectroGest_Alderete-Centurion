using System;
using System.Collections.Generic;

namespace ElectroGest.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public int RolId { get; set; }

    public string PasswordHash { get; set; } = null!;

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public bool? Activo { get; set; }

    public virtual Persona IdNavigation { get; set; } = null!;

    public virtual Role Rol { get; set; } = null!;

    public virtual ICollection<Venta> VentaSupervisors { get; set; } = new List<Venta>();

    public virtual ICollection<Venta> VentaVendedors { get; set; } = new List<Venta>();
}
