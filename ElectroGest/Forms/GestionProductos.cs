using ElectroGest.Datas;
using ElectroGest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectroGest.Forms
{
    public partial class GestionProductos : Form
    {
        private RepositoriosCategorias _repositorio;
        private readonly RepositorioProductos _repositorioProducto;
        private readonly RepositorioProductos _repositorioProductoActualizado;
        private readonly RepositoriosCategorias _repositorioCategoria;
        private readonly RepositoriosMarcas _repositorioMarca;

        private int? idSeleccionado = null;
        private Usuario _usuario;
        public GestionProductos()
        {
            InitializeComponent();
            //para form agregar editar
            _repositorio = new RepositoriosCategorias();
            _repositorioProducto = new RepositorioProductos();
            _repositorioProductoActualizado = new RepositorioProductos();
            //par busqueda filtro
            _repositorioCategoria = new RepositoriosCategorias();
            _repositorioMarca = new RepositoriosMarcas();



        }

        private void GestionProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarMarcas();
            CargarCategorias();
            // ActualizarEstadoBotones();

            CargarCategoriasFiltros();
            CargarMarcasFiltros();
            // CargarProductosFiltrados();
            //  picProducto.SizeMode = PictureBoxSizeMode.CenterImage;

        }
        private void CargarProductosFiltrados()
        {
            try
            {
                string termino = txtBusquedaProducto.Text.Trim();
                int? idCategoria = comboBoxCategoria.SelectedIndex >= 0 ? (int?)comboBoxCategoria.SelectedValue : null;
                int? idMarca = comboBoxMarca.SelectedIndex >= 0 ? (int?)comboBoxMarca.SelectedValue : null;

                var productos = _repositorioProducto.BuscarProductos(termino, idCategoria, idMarca)
                      .Select(p => new
                      {
                          p.IdProducto,
                          p.CodigoBarras,
                          p.Sku,
                          p.Nombre,
                          p.Descripcion,
                          p.Stock,
                          p.PrecioCompra,
                          p.PrecioVenta,
                          p.MargenGanancia,
                          ImagenUrl = p.ImagenUrl ?? "",
                          Categoria = p.IdCategoriaNavigation != null ? p.IdCategoriaNavigation.Nombre : "Sin categoría",
                          Marca = p.IdMarcaNavigation != null ? p.IdMarcaNavigation.Nombre : "Sin marca",
                          Activo = p.Activo == true,
                          FechaCreacion = p.FechaCreacion?.ToString("dd/MM/yyyy HH:mm") ?? "",
                          FechaActualizacion = p.FechaActualizacion?.ToString("dd/MM/yyyy HH:mm") ?? ""
                      })
                    .ToList();
                lblTitulo.Text = "Filtros de Productos Aplicados";
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = productos;

                // Renombrar encabezados
                dgvProductos.Columns["IdProducto"].HeaderText = "ID";
                dgvProductos.Columns["CodigoBarras"].HeaderText = "Codigo";
                dgvProductos.Columns["Sku"].HeaderText = "Extracto";
                dgvProductos.Columns["Nombre"].HeaderText = "Nombre";
                dgvProductos.Columns["Descripcion"].HeaderText = "Descripción";
                dgvProductos.Columns["PrecioCompra"].HeaderText = "Precio Compra";
                dgvProductos.Columns["PrecioVenta"].HeaderText = "Precio Venta";
                dgvProductos.Columns["MargenGanancia"].HeaderText = "Margen %";
                dgvProductos.Columns["Categoria"].HeaderText = "Categoría";
                dgvProductos.Columns["Marca"].HeaderText = "Marca";
                // Mostrar la columna de imagen (opcionalmente podés ocultarla)
                dgvProductos.Columns["ImagenUrl"].HeaderText = "Imagen URL";
                dgvProductos.Columns["ImagenUrl"].Visible = false;
                dgvProductos.Columns["Activo"].HeaderText = "Activo";
                dgvProductos.Columns["FechaCreacion"].HeaderText = "Creación";
                dgvProductos.Columns["FechaActualizacion"].HeaderText = "Última actualización";


                // Ajustes visuales
                dgvProductos.Columns["Descripcion"].Width = 200;

                dgvProductos.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar productos: " + ex.Message);
            }
        }

        private void CargarCategoriasFiltros()
        {
            try
            {
                var categorias = _repositorioCategoria.ObtenerTodasCategorias()
                    .OrderBy(c => c.Nombre)
                    .ToList();

                comboBoxCategoria.DataSource = categorias;
                comboBoxCategoria.DisplayMember = "Nombre";
                comboBoxCategoria.ValueMember = "IdCategoria";
                comboBoxCategoria.SelectedIndex = -1; // Ninguna seleccionada al iniciar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }

        private void CargarMarcasFiltros()
        {
            try
            {
                var marcas = _repositorioMarca.ObtenerTodasMarcas()
                    .OrderBy(m => m.Nombre)
                    .ToList();

                comboBoxMarca.DataSource = marcas;
                comboBoxMarca.DisplayMember = "Nombre";
                comboBoxMarca.ValueMember = "IdMarca";
                comboBoxMarca.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar marcas: " + ex.Message);
            }
        }

        public void CargarProductos()
        {
            try
            {
                var productos = _repositorioProducto.ObtenerTodos()
                    .Select(p => new
                    {
                        p.IdProducto,
                        p.CodigoBarras,
                        p.Sku,
                        p.Nombre,
                        p.Descripcion,
                        p.Stock,
                        p.PrecioCompra,
                        p.PrecioVenta,
                        p.MargenGanancia,
                        ImagenUrl = p.ImagenUrl ?? "",
                        Categoria = p.IdCategoriaNavigation != null ? p.IdCategoriaNavigation.Nombre : "Sin categoría",
                        Marca = p.IdMarcaNavigation != null ? p.IdMarcaNavigation.Nombre : "Sin marca",
                        Activo = p.Activo == true,
                        FechaCreacion = p.FechaCreacion?.ToString("dd/MM/yyyy HH:mm") ?? "",
                        FechaActualizacion = p.FechaActualizacion?.ToString("dd/MM/yyyy HH:mm") ?? ""
                    })
                    .ToList();
                lblTitulo.Text = "Registrar nuevo producto";
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = productos;

                // Renombrar encabezados
                dgvProductos.Columns["IdProducto"].HeaderText = "ID";
                dgvProductos.Columns["CodigoBarras"].HeaderText = "Codigo";
                dgvProductos.Columns["Sku"].HeaderText = "Extracto";
                dgvProductos.Columns["Nombre"].HeaderText = "Nombre";
                dgvProductos.Columns["Descripcion"].HeaderText = "Descripción";
                dgvProductos.Columns["PrecioCompra"].HeaderText = "Precio Compra";
                dgvProductos.Columns["PrecioVenta"].HeaderText = "Precio Venta";
                dgvProductos.Columns["MargenGanancia"].HeaderText = "Margen %";
                dgvProductos.Columns["Categoria"].HeaderText = "Categoría";
                dgvProductos.Columns["Marca"].HeaderText = "Marca";
                // Mostrar la columna de imagen (opcionalmente podés ocultarla)
                dgvProductos.Columns["ImagenUrl"].HeaderText = "Imagen URL";
                dgvProductos.Columns["ImagenUrl"].Visible = false;
                dgvProductos.Columns["Activo"].HeaderText = "Activo";
                dgvProductos.Columns["FechaCreacion"].HeaderText = "Creación";
                dgvProductos.Columns["FechaActualizacion"].HeaderText = "Última actualización";


                // Ajustes visuales
                dgvProductos.Columns["Descripcion"].Width = 200;
                //dgvProductos.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                // Refrescar para asegurar que se renderice
                dgvProductos.Refresh();

                // Limpiar selección inicial

                this.BeginInvoke(new Action(() => dgvProductos.ClearSelection()));
                dgvProductos.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvProductos.Rows[e.RowIndex];

            idSeleccionado = Convert.ToInt32(row.Cells["IdProducto"].Value);

            tbNombre.Text = row.Cells["Nombre"].Value?.ToString() ?? "";
            tbCodProd.Text = row.Cells["CodigoBarras"].Value?.ToString() ?? "";
            tbDescripcion.Text = row.Cells["Descripcion"].Value?.ToString() ?? "";
            tbPrecioCompra.Text = row.Cells["PrecioCompra"].Value?.ToString() ?? "";
            tbPrecioVenta.Text = row.Cells["PrecioVenta"].Value?.ToString() ?? "";
            tbMargen.Text = row.Cells["MargenGanancia"].Value?.ToString() ?? "";

            // ✅ Cargar la URL de imagen desde la celda
            txtUrlImagen.Text = row.Cells["ImagenUrl"].Value?.ToString() ?? "";

            // 🔹 Mostrar imagen (usa tu método CargarImagenProducto)
            CargarImagenProducto(txtUrlImagen.Text);

            // 🔹 Cargar combos
            comboBoxCategorias.SelectedIndex = comboBoxCategorias.FindStringExact(row.Cells["Categoria"].Value?.ToString());
            comboBoxMarcas.SelectedIndex = comboBoxMarcas.FindStringExact(row.Cells["Marca"].Value?.ToString());

            // 🔹 Check activo
            checkActivo.Checked = Convert.ToBoolean(row.Cells["Activo"].Value);
            //stock
            int stock = Convert.ToInt32(row.Cells["Stock"].Value ?? 0);
            lblStock.Text = stock > 0 ? $"Stock disponible: {stock}" : "Sin stock";
            lblStock.ForeColor = stock > 0 ? Color.DarkGreen : Color.Red;

            // 🔹 Control de botones
            btnEditar.Enabled = true;
            btnEliminar.Enabled = checkActivo.Checked;
            btnAgregar.Enabled = false;
            btnLimpiar.Enabled = true;
            lblTitulo.Text = "Editar producto seleccionado";
        }


        private void CargarImagenProducto(string url)
        {
            try
            {
                // 🔹 Configuramos el modo de ajuste visual
                picProducto.SizeMode = PictureBoxSizeMode.Zoom;

                if (string.IsNullOrWhiteSpace(url))
                {

                    picProducto.Image = Properties.Resources.icons8_producto_100;
                }
                else if (File.Exists(url))
                {
                    picProducto.Image = Image.FromFile(url);
                }
                else if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
                {
                    using (var client = new System.Net.WebClient())
                    {
                        var data = client.DownloadData(url);
                        using (var ms = new MemoryStream(data))
                        {
                            picProducto.Image = Image.FromStream(ms);
                        }
                    }
                }
                else
                {

                    picProducto.Image = Properties.Resources.icons8_producto_100;
                }
            }
            catch
            {
                // picProducto.SizeMode = PictureBoxSizeMode.CenterImage;
                picProducto.Image = Properties.Resources.icons8_producto_100;
            }
        }



        private void ActualizarEstadoBotones()
        {
            bool haySeleccion = dgvProductos.CurrentRow != null;

            btnAgregar.Enabled = !haySeleccion;
            btnEditar.Enabled = haySeleccion;
            btnEliminar.Enabled = haySeleccion;
            btnLimpiar.Enabled = haySeleccion;

            // tbPrecioCompra.Enabled = haySeleccion;
            // tbPrecioVenta.Enabled = haySeleccion;
            // tbMargen.Enabled = haySeleccion;
            checkActivo.Enabled = haySeleccion;

            lblTitulo.Text = haySeleccion ? "Editar producto seleccionado" : "Registrar nuevo producto";
        }

        private void CargarMarcas()
        {
            using (var context = new SistemaVentasContext())
            {
                var marcas = context.Marcas
                    .Where(m => m.Activo == true) // Solo marcas activas
                    .OrderBy(m => m.Nombre)
                    .ToList();

                comboBoxMarcas.DataSource = marcas;
                comboBoxMarcas.DisplayMember = "Nombre";  // lo que se muestra
                comboBoxMarcas.ValueMember = "IdMarca";   // valor interno
                comboBoxMarcas.SelectedIndex = -1;        // sin selección inicial
            }
        }

        private void CargarCategorias()
        {
            using (var context = new SistemaVentasContext())
            {
                var categorias = context.Categorias
                    .Where(c => c.Activo == true)
                    .OrderBy(c => c.Nombre)
                    .ToList();

                if (categorias.Any())
                {
                    comboBoxCategorias.DataSource = categorias;
                    comboBoxCategorias.DisplayMember = "Nombre";
                    comboBoxCategorias.ValueMember = "IdCategoria";
                    comboBoxCategorias.SelectedIndex = -1;
                }
                else
                {
                    comboBoxCategorias.DataSource = null;
                    comboBoxCategorias.Items.Clear();
                    comboBoxCategorias.Items.Add("No hay categorías habilitadas");
                    comboBoxCategorias.SelectedIndex = 0;
                    comboBoxCategorias.Enabled = false;
                }
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                // --- VALIDACIONES PREVIAS ---
                if (string.IsNullOrWhiteSpace(tbNombre.Text))
                {
                    MessageBox.Show("⚠️ El campo 'Nombre' es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbNombre.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbDescripcion.Text))
                {
                    MessageBox.Show("⚠️ El campo 'Descripcion' es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbDescripcion.Focus();
                    return;
                }

                //if (string.IsNullOrWhiteSpace(tbPrecioCompra.Text))
                //{
                //  MessageBox.Show("⚠️ Debe ingresar el precio de compra.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //tbPrecioCompra.Focus();
                //return;
                //}

                //if (!decimal.TryParse(tbPrecioCompra.Text, out decimal precioCompra) || precioCompra <= 0)
                //{
                //MessageBox.Show("⚠️ El precio de compra debe ser un número válido mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // tbPrecioCompra.Focus();
                //  return;
                //}

                //if (string.IsNullOrWhiteSpace(tbMargen.Text))
                //{
                //MessageBox.Show("⚠️ Debe ingresar el margen de ganancia (%).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //tbMargen.Focus();
                //  return;
                //}

                // if (!decimal.TryParse(tbMargen.Text, out decimal margenGanancia))
                //{
                //  MessageBox.Show("⚠️ El margen de ganancia debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //tbMargen.Focus();
                //return;
                //}

                if (comboBoxCategorias.SelectedValue == null)
                {
                    MessageBox.Show("⚠️ Debe seleccionar una categoría.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBoxCategorias.Focus();
                    return;
                }

                if (comboBoxMarcas.SelectedValue == null)
                {
                    MessageBox.Show("⚠️ Debe seleccionar una marca.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBoxMarcas.Focus();
                    return;
                }
                var producto = new Producto
                {
                    Nombre = tbNombre.Text.Trim(),
                    Descripcion = tbDescripcion.Text.Trim(),
                    ImagenUrl = txtUrlImagen.Text.Trim() == "" ? null : txtUrlImagen.Text.Trim(),
                    PrecioCompra = decimal.Parse(tbPrecioCompra.Text == "" ? "0" : tbPrecioCompra.Text),
                    PrecioVenta = decimal.Parse(tbPrecioVenta.Text == "" ? "0" : tbPrecioVenta.Text),
                    MargenGanancia = decimal.Parse(tbMargen.Text == "" ? "0" : tbMargen.Text),
                    IdCategoria = (int)comboBoxCategorias.SelectedValue,
                    IdMarca = (int)comboBoxMarcas.SelectedValue,
                    Activo = true
                };

                _repositorioProducto.Agregar(producto);
                MessageBox.Show("Producto agregado correctamente");
                LimpiarCampos();
                CargarProductos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
                var inner = ex.InnerException?.Message ?? "(sin detalles internos)";
                MessageBox.Show("Error al agregar producto:\n" + ex.Message + "\n\nDetalle interno:\n" + inner);
                MessageBox.Show($"ID Categoria: {comboBoxCategorias.SelectedValue}, ID Marca: {comboBoxMarcas.SelectedValue}");
            }


        }
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                ofd.Title = "Seleccionar imagen del producto";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 📂 1. Crear carpeta interna donde se guardarán las imágenes
                        string carpetaDestino = Path.Combine(Application.StartupPath, "img\\Productos");
                        Directory.CreateDirectory(carpetaDestino);

                        // 🧾 2. Copiar la imagen seleccionada dentro de esa carpeta
                        string nombreArchivo = Path.GetFileName(ofd.FileName);
                        string rutaDestino = Path.Combine(carpetaDestino, nombreArchivo);

                        // Si el archivo ya existe, se reemplaza
                        File.Copy(ofd.FileName, rutaDestino, true);

                        // 🖼️ 3. Mostrar la imagen y guardar la ruta en el textbox
                        txtUrlImagen.Text = rutaDestino;
                        picProducto.Image = Image.FromFile(rutaDestino);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarProductosFiltrados();
        }
        private void tbPrecioCompra_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnAgregaMarca_Click(object sender, EventArgs e)
        {
            FormMarca formMarca = new FormMarca();

            // Mostramos el formulario como modal
            DialogResult resultado = formMarca.ShowDialog();

            // Si el usuario guardó una marca, actualizamos la lista o textbox
            //  if (resultado == DialogResult.OK)
            //{
            //  CargarMarcas(); // función que refresca las marcas disponibles
            //}
        }
        // En FormProductos, al abrir FormCategorias
        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario FrmCategoria
            //  FormCategoria formCategoria = new FormCategoria();

            var formCategorias = new FormCategoria();
            formCategorias.CategoriasActualizadas += FormCategorias_CategoriasActualizadas;
            DialogResult resultado = formCategorias.ShowDialog();

            // Si el usuario guardó una categoría, refrescar la lista de categorías
            if (resultado == DialogResult.OK)
            {
                CargarCategorias(); // Método que actualiza el ComboBox o TextBox de categorías
            }
        }
        // Manejador del evento
        private void FormCategorias_CategoriasActualizadas(object sender, EventArgs e)
        {
            CargarComboBoxCategorias(); // Función que refresca el ComboBox
        }

        private void CargarComboBoxCategorias()
        {
            var categorias = _repositorio.ObtenerCategoriasActivas(); // Solo activas

            if (categorias != null && categorias.Any())
            {
                comboBoxCategorias.Enabled = true;
                comboBoxCategorias.DataSource = categorias;
                comboBoxCategorias.DisplayMember = "Nombre";
                comboBoxCategorias.ValueMember = "IdCategoria";
                comboBoxCategorias.SelectedIndex = -1;
            }
            else
            {
                comboBoxCategorias.DataSource = null;
                comboBoxCategorias.Items.Clear();
                comboBoxCategorias.Items.Add("No hay categorías habilitadas");
                comboBoxCategorias.SelectedIndex = 0;
                comboBoxCategorias.Enabled = false; // opcional
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un producto para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxCategorias.SelectedValue == null || comboBoxMarcas.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar una categoría y una marca.", "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var producto = new Producto
                {
                    IdProducto = idSeleccionado.Value,
                    Nombre = tbNombre.Text.Trim(),
                    Descripcion = tbDescripcion.Text.Trim(),
                    ImagenUrl = string.IsNullOrWhiteSpace(txtUrlImagen.Text) ? null : txtUrlImagen.Text.Trim(),
                    PrecioCompra = decimal.Parse(string.IsNullOrWhiteSpace(tbPrecioCompra.Text) ? "0" : tbPrecioCompra.Text),
                    PrecioVenta = decimal.Parse(string.IsNullOrWhiteSpace(tbPrecioVenta.Text) ? "0" : tbPrecioVenta.Text),
                    MargenGanancia = decimal.Parse(string.IsNullOrWhiteSpace(tbMargen.Text) ? "0" : tbMargen.Text),
                    IdCategoria = (int)comboBoxCategorias.SelectedValue,
                    IdMarca = (int)comboBoxMarcas.SelectedValue,
                    Activo = checkActivo.Checked
                };

                _repositorioProducto.Actualizar(producto);
                MessageBox.Show("Producto actualizado correctamente ✅");
                CargarProductos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el producto: " + ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == null) return;

            var producto = _repositorioProducto.ObtenerPorId(idSeleccionado.Value);
            if (producto == null) return;

            bool nuevoEstado = (bool)!producto.Activo;
            string accion = nuevoEstado ? "activar" : "desactivar";

            if (MessageBox.Show($"¿Desea {accion} el producto '{producto.Nombre}'?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _repositorioProducto.CambiarEstado(producto.IdProducto, nuevoEstado);
                MessageBox.Show($"Producto {accion}do correctamente.");
                LimpiarCampos();
                CargarProductos();
            }
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                LimpiarCampos();
                return;
            }

            var fila = dgvProductos.SelectedRows[0];
            idSeleccionado = Convert.ToInt32(fila.Cells["IdProducto"].Value);

            tbNombre.Text = fila.Cells["Nombre"].Value?.ToString();
            tbDescripcion.Text = fila.Cells["Descripcion"].Value?.ToString();
            tbPrecioCompra.Text = fila.Cells["PrecioCompra"].Value?.ToString();
            tbPrecioVenta.Text = fila.Cells["PrecioVenta"].Value?.ToString();
            tbMargen.Text = fila.Cells["MargenGanancia"].Value?.ToString();
            txtUrlImagen.Text = fila.Cells["ImagenUrl"].Value?.ToString();

            // Seleccionar categoría y marca en los ComboBox
            comboBoxCategorias.SelectedIndex = comboBoxCategorias.FindStringExact(fila.Cells["Categoria"].Value?.ToString());
            comboBoxMarcas.SelectedIndex = comboBoxMarcas.FindStringExact(fila.Cells["Marca"].Value?.ToString());

            checkActivo.Checked = (bool)fila.Cells["Activo"].Value;

            // Mostrar imagen si existe
            string url = txtUrlImagen.Text;
            picProducto.ImageLocation = string.IsNullOrEmpty(url) ? null : url;

            ActualizarEstadoBotones();
        }
     
        private void LimpiarCampos()
        {
            idSeleccionado = 0;

            tbCodProd.Enabled = false;
            tbNombre.Clear();
            tbCodProd.Clear();
            tbDescripcion.Clear();
            tbPrecioCompra.Clear();
            tbPrecioVenta.Clear();
            tbMargen.Clear();
            txtUrlImagen.Clear();

            picProducto.Image = null;        // Quita cualquier imagen cargada
            picProducto.ImageLocation = null; // Limpia la ruta asociada
            picProducto.SizeMode = PictureBoxSizeMode.CenterImage;
            picProducto.Image = Properties.Resources.icons8_producto_100;

            comboBoxCategorias.SelectedIndex = -1;
            comboBoxMarcas.SelectedIndex = -1;
            checkActivo.Checked = false;

            dgvProductos.ClearSelection();

            // Estado de botones
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = true;
            btnLimpiar.Enabled = false;

            lblTitulo.Text = "Registrar nuevo producto";
        }


        private void btnCompras_Click(object sender, EventArgs e)
        {
            var formCompras = new FormRegistrarCompra();

            // 🔔 Nos suscribimos al evento
            formCompras.ProductosActualizados += FormCompras_ProductosActualizados;



            formCompras.ShowDialog();
        }

        //  Manejador del evento
  
        private void FormCompras_ProductosActualizados(object sender, EventArgs e)
        {
            RefrescarLista(); // Recarga la lista de productos
        }

        public void RefrescarLista()
        {
            RefrescarLista(_repositorioProducto);
        }

        public void RefrescarLista(RepositorioProductos _repositorioProducto)
        {
            _repositorioProducto = new RepositorioProductos(); // Nuevo contexto
            CargarProductos(); // Trae datos frescos desde BD
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            CargarProductosFiltrados();
        }
        private void txtBusquedaProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtBusquedaProducto.Text.Length >= 2 || txtBusquedaProducto.Text.Length == 0)
                CargarProductosFiltrados();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtBusquedaProducto.Clear();
            comboBoxCategoria.SelectedIndex = -1;
            comboBoxMarca.SelectedIndex = -1;
            CargarProductosFiltrados();

            lblTitulo.Text = "Registrar nuevo producto";
        }
        // ✅ Función que calcula el precio de venta
        private decimal CalcularPrecioVenta()
        {
            // Validamos que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(tbPrecioCompra.Text) || string.IsNullOrWhiteSpace(tbMargen.Text))
            {
                MessageBox.Show("Ingresá el precio de compra y el margen de ganancia.");
                return 0;
            }

            // Convertimos los valores
            if (!decimal.TryParse(tbPrecioCompra.Text, out decimal precioCompra))
            {
                MessageBox.Show("El precio de compra no es válido.");
                return 0;
            }

            if (!decimal.TryParse(tbMargen.Text, out decimal margen))
            {
                MessageBox.Show("El margen de ganancia no es válido.");
                return 0;
            }

            // 🧮 Cálculo: precio venta = compra + (compra * margen / 100)
            decimal precioVenta = precioCompra + (precioCompra * (margen / 100));

            // Mostramos el resultado en el TextBox de venta
            tbPrecioVenta.Text = precioVenta.ToString("0.00");

            return precioVenta;
        }

        private void btnPrecioVenta_Click(object sender, EventArgs e)
        {
            CalcularPrecioVenta();
        }

    }
}