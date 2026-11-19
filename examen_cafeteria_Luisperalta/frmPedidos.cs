using System.Globalization;

namespace examen_cafeteria_Luisperalta
{
    public partial class frmPedidos : Form
    {
        private const decimal RECARGO_GRANDE = 25.00m;
        private const decimal RECARGO_PORCION_EXTRA = 30.00m;
        private const decimal PORCENTAJE_DESCUENTO_FRECUENTE = 0.10m;
        private const decimal COSTO_EMPAQUE_LLEVAR = 20.00m;
        private const decimal TASA_ITBIS = 0.18m;

        private const int ANCHO_CANT = 6;
        private const int ANCHO_PRODUCTO = 24;
        private const int ANCHO_PRECIO = 10;
        private const int ANCHO_TOTAL = 12;

        private readonly CultureInfo _culturaRD = new CultureInfo("es-DO");
        private decimal _subtotal = 0.00m;

        public frmPedidos()
        {
            InitializeComponent();
        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {
            ConfigurarEncabezado();
            ReiniciarTodo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string producto = txtProducto.Text.Trim();
            if (string.IsNullOrWhiteSpace(producto))
            {
                MessageBox.Show("Debe digitar el nombre del producto.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProducto.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text.Trim(), NumberStyles.Number, _culturaRD, out decimal precioDigitado) &&
                !decimal.TryParse(txtPrecio.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out precioDigitado))
            {
                MessageBox.Show("Debe digitar un precio unitario válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }

            if (precioDigitado < 0)
            {
                MessageBox.Show("El precio no puede ser negativo.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }

            int cantidad = (int)nudCantidad.Value;
            bool esGrande = rbtGrande.Checked;
            bool llevaExtra = chkPorcionExtra.Checked;

            decimal precioUnitario = CalcularPrecioUnitario(precioDigitado, esGrande, llevaExtra);
            decimal totalLinea = precioUnitario * cantidad;

            string etiquetaTamano = esGrande ? "Grande" : "Normal";
            string detalleProducto = $"{producto} ({etiquetaTamano})";

            string lineaFormateada = FormatearLineaPedido(cantidad, detalleProducto, precioUnitario, totalLinea);
            lstPedido.Items.Add(lineaFormateada);

            _subtotal += totalLinea;
            lblSubtotal.Text = FormatearMoneda(_subtotal);

            ReiniciarControlesProducto();
            txtProducto.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (lstPedido.Items.Count == 0 || _subtotal <= 0m)
            {
                MessageBox.Show("Agregue al menos un producto al pedido antes de calcular el total.",
                    "Pedido vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal descuento = chkFrecuente.Checked
                ? Math.Round(_subtotal * PORCENTAJE_DESCUENTO_FRECUENTE, 2, MidpointRounding.AwayFromZero)
                : 0.00m;

            decimal empaque = rbtLlevar.Checked ? COSTO_EMPAQUE_LLEVAR : 0.00m;

            decimal baseImponible = _subtotal - descuento + empaque;
            decimal itbis = Math.Round(baseImponible * TASA_ITBIS, 2, MidpointRounding.AwayFromZero);
            decimal totalPagar = baseImponible + itbis;

            lblSubtotal.Text = FormatearMoneda(_subtotal);
            lblDescuento.Text = FormatearMoneda(descuento);
            lblEmpaque.Text = FormatearMoneda(empaque);
            lblItbis.Text = FormatearMoneda(itbis);
            lblTotal.Text = FormatearMoneda(totalPagar);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ReiniciarTodo();
            txtCliente.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea salir de la aplicación?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }

        private decimal CalcularPrecioUnitario(decimal precioBase, bool esGrande, bool llevaExtra)
        {
            decimal unitario = precioBase;
            if (esGrande)
            {
                unitario += RECARGO_GRANDE;
            }
            if (llevaExtra)
            {
                unitario += RECARGO_PORCION_EXTRA;
            }
            return unitario;
        }

        private string FormatearLineaPedido(int cantidad, string producto, decimal precioUnitario, decimal totalLinea)
        {
            string colCant = cantidad.ToString().PadRight(ANCHO_CANT);
            string colProd = TruncarSiExcede(producto, ANCHO_PRODUCTO).PadRight(ANCHO_PRODUCTO);
            string colPrecio = precioUnitario.ToString("0.00", CultureInfo.InvariantCulture).PadLeft(ANCHO_PRECIO);
            string colTotal = totalLinea.ToString("0.00", CultureInfo.InvariantCulture).PadLeft(ANCHO_TOTAL);

            return $"{colCant}{colProd}{colPrecio}{colTotal}";
        }

        private void ConfigurarEncabezado()
        {
            string hCant = "Cant".PadRight(ANCHO_CANT);
            string hProd = "Producto".PadRight(ANCHO_PRODUCTO);
            string hPrecio = "Precio".PadLeft(ANCHO_PRECIO);
            string hTotal = "Total".PadLeft(ANCHO_TOTAL);

            lblEncabezado.Font = new Font("Consolas", 9.5F, FontStyle.Bold);
            lblEncabezado.Text = $"{hCant}{hProd}{hPrecio}{hTotal}";
        }

        private void ReiniciarControlesProducto()
        {
            txtProducto.Clear();
            txtPrecio.Clear();
            nudCantidad.Value = 1;
            rbtNormal.Checked = true;
            chkPorcionExtra.Checked = false;
        }

        private void ReiniciarTodo()
        {
            txtCliente.Clear();
            dtpFecha.Value = DateTime.Today;
            chkFrecuente.Checked = false;

            ReiniciarControlesProducto();

            rbtLocal.Checked = true;
            lstPedido.Items.Clear();

            _subtotal = 0.00m;
            LimpiarResultados();
        }

        private void LimpiarResultados()
        {
            string cero = FormatearMoneda(0.00m);
            lblSubtotal.Text = cero;
            lblDescuento.Text = cero;
            lblEmpaque.Text = cero;
            lblItbis.Text = cero;
            lblTotal.Text = cero;
        }

        private string FormatearMoneda(decimal monto)
        {
            return $"RD$ {monto.ToString("0.00", CultureInfo.InvariantCulture)}";
        }

        private static string TruncarSiExcede(string texto, int maxLongitud)
        {
            if (string.IsNullOrEmpty(texto) || texto.Length <= maxLongitud)
                return texto ?? string.Empty;

            return texto.Substring(0, maxLongitud);
        }
    }
}