using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ElectroGest.Models;

public partial class SistemaVentasContext : DbContext
{
    public SistemaVentasContext()
    {
    }

    public SistemaVentasContext(DbContextOptions<SistemaVentasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BackupHistorial> BackupHistorials { get; set; }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<DetalleCompra> DetalleCompras { get; set; }

    public virtual DbSet<DetalleVentum> DetalleVenta { get; set; }

    public virtual DbSet<HistorialPrecioCompra> HistorialPrecioCompras { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<ProductoProveedor> ProductoProveedors { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Venta> Ventas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-DPHO80V;Database=SistemaVentas;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BackupHistorial>(entity =>
        {
            entity.HasKey(e => e.IdBackup).HasName("PK__BackupHi__972F40D7AD2A06ED");

            entity.ToTable("BackupHistorial");

            entity.Property(e => e.FechaBackup).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.NombreArchivo).HasMaxLength(255);
            entity.Property(e => e.Observaciones).HasMaxLength(500);
            entity.Property(e => e.RutaDestino).HasMaxLength(500);
            entity.Property(e => e.TamanoMb)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("TamanoMB");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.BackupHistorials)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__BackupHis__IdUsu__2DE6D218");
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK__Categori__CD54BC5AB0B9776C");

            entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaActualizacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_actualizacion");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clientes__3214EC0720066E9A");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Direccion).HasMaxLength(255);
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_modificacion");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_registro");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Cliente)
                .HasForeignKey<Cliente>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Clientes__Id__5BE2A6F2");
        });

        modelBuilder.Entity<Compra>(entity =>
        {
            entity.HasKey(e => e.IdCompra).HasName("PK__Compra__C4BAA6044E781337");

            entity.ToTable("Compra");

            entity.Property(e => e.IdCompra).HasColumnName("id_compra");
            entity.Property(e => e.FechaCompra)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_compra");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.NumeroFactura)
                .HasMaxLength(50)
                .HasColumnName("numero_factura");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .HasColumnName("observaciones");
            entity.Property(e => e.TotalCompra)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total_compra");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.Compras)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Compra__id_prove__1BC821DD");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Compras)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Compra_Usuario");
        });

        modelBuilder.Entity<DetalleCompra>(entity =>
        {
            entity.HasKey(e => e.IdDetalleCompra).HasName("PK__DetalleC__BD16E2792F318734");

            entity.ToTable("DetalleCompra", tb => tb.HasTrigger("TR_DetalleCompra_ActualizarStock"));

            entity.Property(e => e.IdDetalleCompra).HasColumnName("id_detalle_compra");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.IdCompra).HasColumnName("id_compra");
            entity.Property(e => e.IdProducto).HasColumnName("id_producto");
            entity.Property(e => e.PrecioCompraUnitario)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio_compra_unitario");
            entity.Property(e => e.PrecioVentaCalculado)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio_venta_calculado");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("subtotal");

            entity.HasOne(d => d.IdCompraNavigation).WithMany(p => p.DetalleCompras)
                .HasForeignKey(d => d.IdCompra)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DetalleCo__id_co__1EA48E88");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DetalleCompras)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DetalleCo__id_pr__1F98B2C1");
        });

        modelBuilder.Entity<DetalleVentum>(entity =>
        {
            entity.HasKey(e => e.IdDetalle).HasName("PK__Detalle___4F1332DEA25B436A");

            entity.ToTable("Detalle_Venta");

            entity.Property(e => e.IdDetalle).HasColumnName("id_detalle");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.IdProducto).HasColumnName("id_producto");
            entity.Property(e => e.IdVenta).HasColumnName("id_venta");
            entity.Property(e => e.PrecioUnitario)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio_unitario");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("subtotal");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Detalle_V__id_pr__2739D489");

            entity.HasOne(d => d.IdVentaNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.IdVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Detalle_V__id_ve__2645B050");
        });

        modelBuilder.Entity<HistorialPrecioCompra>(entity =>
        {
            entity.HasKey(e => e.IdHistorial).HasName("PK__Historia__76E6C5028830B006");

            entity.ToTable("HistorialPrecioCompra");

            entity.Property(e => e.IdHistorial).HasColumnName("id_historial");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdProductoProveedor).HasColumnName("id_producto_proveedor");
            entity.Property(e => e.PrecioCompra)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio_compra");

            entity.HasOne(d => d.IdProductoProveedorNavigation).WithMany(p => p.HistorialPrecioCompras)
                .HasForeignKey(d => d.IdProductoProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Historial__id_pr__17F790F9");
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.HasKey(e => e.IdMarca).HasName("PK__Marca__7E43E99E8F70104C");

            entity.Property(e => e.IdMarca).HasColumnName("id_marca");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.FechaActualizacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_actualizacion");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Personas__3214EC07CD1E483F");

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(20);
            entity.Property(e => e.Tipo).HasMaxLength(20);
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__Producto__FF341C0D622E9FED");

            entity.HasIndex(e => e.Sku, "UQ__Producto__DDDF4BE73149E02A").IsUnique();

            entity.Property(e => e.IdProducto).HasColumnName("id_producto");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.CodigoBarras)
                .HasMaxLength(50)
                .HasColumnName("codigo_barras");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaActualizacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_actualizacion");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");
            entity.Property(e => e.IdMarca).HasColumnName("id_marca");
            entity.Property(e => e.ImagenUrl)
                .HasMaxLength(300)
                .HasColumnName("imagen_url");
            entity.Property(e => e.MargenGanancia)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("margen_ganancia");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.PrecioCompra)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio_compra");
            entity.Property(e => e.PrecioVenta)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio_venta");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .HasColumnName("sku");
            entity.Property(e => e.Stock)
                .HasDefaultValue(0)
                .HasColumnName("stock");
            entity.Property(e => e.StockMinimo)
                .HasDefaultValue(5)
                .HasColumnName("stock_minimo");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Producto__id_cat__04E4BC85");

            entity.HasOne(d => d.IdMarcaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdMarca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Producto__id_mar__05D8E0BE");
        });

        modelBuilder.Entity<ProductoProveedor>(entity =>
        {
            entity.HasKey(e => e.IdProductoProveedor).HasName("PK__Producto__2277E40E67DFC7F3");

            entity.ToTable("Producto_Proveedor");

            entity.HasIndex(e => new { e.IdProducto, e.IdProveedor }, "UQ_ProductoProveedor").IsUnique();

            entity.Property(e => e.IdProductoProveedor).HasColumnName("id_producto_proveedor");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.FechaActualizacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_actualizacion");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.IdProducto).HasColumnName("id_producto");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.PrecioCompra)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio_compra");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.ProductoProveedors)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Producto___id_pr__1332DBDC");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.ProductoProveedors)
                .HasForeignKey(d => d.IdProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Producto___id_pr__14270015");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.IdProveedor).HasName("PK__Proveedo__8D3DFE28D4082454");

            entity.HasIndex(e => e.Cuit, "UQ__Proveedo__2CDD9897E35FCABE").IsUnique();

            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Cuit)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cuit");
            entity.Property(e => e.Direccion)
                .HasMaxLength(200)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasColumnName("email");
            entity.Property(e => e.FechaActualizacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_actualizacion");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_creacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Roles__3214EC07FCDF9187");

            entity.HasIndex(e => e.Nombre, "UQ__Roles__75E3EFCF3D154103").IsUnique();

            entity.Property(e => e.Descripcion).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuarios__3214EC07B0AB4118");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_creacion");
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_modificacion");
            entity.Property(e => e.PasswordHash).HasMaxLength(255);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Usuario)
                .HasForeignKey<Usuario>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Usuarios__Id__5629CD9C");

            entity.HasOne(d => d.Rol).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Usuarios__RolId__571DF1D5");
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ventas__3214EC07579F04DD");

            entity.Property(e => e.Descuento)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasDefaultValue("Pendiente");
            entity.Property(e => e.FechaActualizacion).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FechaVenta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MetodoPago).HasMaxLength(50);
            entity.Property(e => e.NumeroFactura).HasMaxLength(50);
            entity.Property(e => e.Observaciones).HasMaxLength(500);
            entity.Property(e => e.Recargo)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalFinal)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Venta)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ventas__ClienteI__60A75C0F");

            entity.HasOne(d => d.Supervisor).WithMany(p => p.VentaSupervisors)
                .HasForeignKey(d => d.SupervisorId)
                .HasConstraintName("FK__Ventas__Supervis__619B8048");

            entity.HasOne(d => d.Vendedor).WithMany(p => p.VentaVendedors)
                .HasForeignKey(d => d.VendedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ventas__Vendedor__5FB337D6");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
