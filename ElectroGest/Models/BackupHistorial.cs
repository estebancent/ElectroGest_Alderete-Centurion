using System;
using System.Collections.Generic;

namespace ElectroGest.Models;

public partial class BackupHistorial
{
    public int IdBackup { get; set; }

    public string NombreArchivo { get; set; } = null!;

    public string RutaDestino { get; set; } = null!;

    public DateTime? FechaBackup { get; set; }

    public int? IdUsuario { get; set; }

    public decimal? TamanoMb { get; set; }

    public string? Observaciones { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
