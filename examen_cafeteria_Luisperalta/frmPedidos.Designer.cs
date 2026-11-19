namespace examen_cafeteria_Luisperalta
{
    partial class frmPedidos
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtCliente;
        private DateTimePicker dtpFecha;
        private CheckBox chkFrecuente;
        private TextBox txtProducto;
        private TextBox txtPrecio;
        private NumericUpDown nudCantidad;
        private GroupBox grpTamano;
        private RadioButton rbtNormal;
        private RadioButton rbtGrande;
        private CheckBox chkPorcionExtra;
        private GroupBox grpServicio;
        private RadioButton rbtLocal;
        private RadioButton rbtLlevar;
        private Label lblEncabezado;
        private ListBox lstPedido;
        private Label lblSubtotal;
        private Label lblDescuento;
        private Label lblEmpaque;
        private Label lblItbis;
        private Label lblTotal;
        private Button btnAgregar;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtCliente = new TextBox();
            this.dtpFecha = new DateTimePicker();
            this.chkFrecuente = new CheckBox();
            this.txtProducto = new TextBox();
            this.txtPrecio = new TextBox();
            this.nudCantidad = new NumericUpDown();
            this.grpTamano = new GroupBox();
            this.rbtNormal = new RadioButton();
            this.rbtGrande = new RadioButton();
            this.chkPorcionExtra = new CheckBox();
            this.grpServicio = new GroupBox();
            this.rbtLocal = new RadioButton();
            this.rbtLlevar = new RadioButton();
            this.lblEncabezado = new Label();
            this.lstPedido = new ListBox();
            this.lblSubtotal = new Label();
            this.lblDescuento = new Label();
            this.lblEmpaque = new Label();
            this.lblItbis = new Label();
            this.lblTotal = new Label();
            this.btnAgregar = new Button();
            this.btnCalcular = new Button();
            this.btnLimpiar = new Button();
            this.btnSalir = new Button();

            Label lblTitCliente = new Label { Text = "Cliente:", Location = new System.Drawing.Point(20, 22), AutoSize = true };
            Label lblTitFecha = new Label { Text = "Fecha:", Location = new System.Drawing.Point(20, 82), AutoSize = true };
            Label lblTitProducto = new Label { Text = "Producto:", Location = new System.Drawing.Point(20, 115), AutoSize = true };
            Label lblTitPrecio = new Label { Text = "Precio:", Location = new System.Drawing.Point(20, 148), AutoSize = true };
            Label lblTitCantidad = new Label { Text = "Cantidad:", Location = new System.Drawing.Point(20, 181), AutoSize = true };

            Label lblTitSubtotal = new Label { Text = "Subtotal", Location = new System.Drawing.Point(430, 315), AutoSize = true };
            Label lblTitDescuento = new Label { Text = "Descuento", Location = new System.Drawing.Point(430, 342), AutoSize = true };
            Label lblTitEmpaque = new Label { Text = "Empaque", Location = new System.Drawing.Point(430, 369), AutoSize = true };
            Label lblTitItbis = new Label { Text = "ITBIS (18%)", Location = new System.Drawing.Point(430, 396), AutoSize = true };
            Label lblTitTotal = new Label { Text = "TOTAL A PAGAR", Location = new System.Drawing.Point(430, 430), AutoSize = true, Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold) };

            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.grpTamano.SuspendLayout();
            this.grpServicio.SuspendLayout();
            this.SuspendLayout();

            // txtCliente
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Location = new System.Drawing.Point(95, 19);
            this.txtCliente.Size = new System.Drawing.Size(230, 23);

            // chkFrecuente
            this.chkFrecuente.Name = "chkFrecuente";
            this.chkFrecuente.Text = "Cliente frecuente";
            this.chkFrecuente.Location = new System.Drawing.Point(20, 48);
            this.chkFrecuente.AutoSize = true;

            // dtpFecha
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Format = DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(95, 78);
            this.dtpFecha.Size = new System.Drawing.Size(140, 23);

            // txtProducto
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Location = new System.Drawing.Point(95, 112);
            this.txtProducto.Size = new System.Drawing.Size(230, 23);

            // txtPrecio
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Location = new System.Drawing.Point(95, 145);
            this.txtPrecio.Size = new System.Drawing.Size(120, 23);

            // nudCantidad
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Minimum = 1;
            this.nudCantidad.Maximum = 20;
            this.nudCantidad.Value = 1;
            this.nudCantidad.Location = new System.Drawing.Point(95, 179);
            this.nudCantidad.Size = new System.Drawing.Size(70, 23);

            // grpTamano
            this.grpTamano.Text = "Tamaño";
            this.grpTamano.Location = new System.Drawing.Point(20, 215);
            this.grpTamano.Size = new System.Drawing.Size(165, 85);

            this.rbtNormal.Name = "rbtNormal";
            this.rbtNormal.Text = "Normal";
            this.rbtNormal.Checked = true;
            this.rbtNormal.Location = new System.Drawing.Point(12, 24);
            this.rbtNormal.AutoSize = true;

            this.rbtGrande.Name = "rbtGrande";
            this.rbtGrande.Text = "Grande (+RD$25)";
            this.rbtGrande.Location = new System.Drawing.Point(12, 50);
            this.rbtGrande.AutoSize = true;

            this.grpTamano.Controls.Add(this.rbtNormal);
            this.grpTamano.Controls.Add(this.rbtGrande);

            // chkPorcionExtra
            this.chkPorcionExtra.Name = "chkPorcionExtra";
            this.chkPorcionExtra.Text = "Porción extra (+RD$30)";
            this.chkPorcionExtra.Location = new System.Drawing.Point(20, 310);
            this.chkPorcionExtra.AutoSize = true;

            // grpServicio
            this.grpServicio.Text = "Servicio";
            this.grpServicio.Location = new System.Drawing.Point(200, 215);
            this.grpServicio.Size = new System.Drawing.Size(205, 85);

            this.rbtLocal.Name = "rbtLocal";
            this.rbtLocal.Text = "Consumir en local";
            this.rbtLocal.Checked = true;
            this.rbtLocal.Location = new System.Drawing.Point(12, 24);
            this.rbtLocal.AutoSize = true;

            this.rbtLlevar.Name = "rbtLlevar";
            this.rbtLlevar.Text = "Para llevar (+RD$20)";
            this.rbtLlevar.Location = new System.Drawing.Point(12, 50);
            this.rbtLlevar.AutoSize = true;

            this.grpServicio.Controls.Add(this.rbtLocal);
            this.grpServicio.Controls.Add(this.rbtLlevar);

            // btnAgregar
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Text = "Agregar al pedido";
            this.btnAgregar.Location = new System.Drawing.Point(430, 19);
            this.btnAgregar.Size = new System.Drawing.Size(390, 34);
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // lblEncabezado
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Location = new System.Drawing.Point(430, 68);
            this.lblEncabezado.Size = new System.Drawing.Size(390, 20);
            this.lblEncabezado.Font = new System.Drawing.Font("Consolas", 9.5F, System.Drawing.FontStyle.Bold);

            // lstPedido
            this.lstPedido.Name = "lstPedido";
            this.lstPedido.Location = new System.Drawing.Point(430, 92);
            this.lstPedido.Size = new System.Drawing.Size(390, 205);
            this.lstPedido.Font = new System.Drawing.Font("Consolas", 9.5F);
            this.lstPedido.HorizontalScrollbar = true;

            // Labels de totales
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Location = new System.Drawing.Point(680, 315);
            this.lblSubtotal.Size = new System.Drawing.Size(140, 20);
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Location = new System.Drawing.Point(680, 342);
            this.lblDescuento.Size = new System.Drawing.Size(140, 20);
            this.lblDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblEmpaque.Name = "lblEmpaque";
            this.lblEmpaque.Location = new System.Drawing.Point(680, 369);
            this.lblEmpaque.Size = new System.Drawing.Size(140, 20);
            this.lblEmpaque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblItbis.Name = "lblItbis";
            this.lblItbis.Location = new System.Drawing.Point(680, 396);
            this.lblItbis.Size = new System.Drawing.Size(140, 20);
            this.lblItbis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Location = new System.Drawing.Point(680, 428);
            this.lblTotal.Size = new System.Drawing.Size(140, 24);
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            // Botones inferiores
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Text = "Calcular total";
            this.btnCalcular.Location = new System.Drawing.Point(20, 415);
            this.btnCalcular.Size = new System.Drawing.Size(120, 38);
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Text = "Nuevo pedido";
            this.btnLimpiar.Location = new System.Drawing.Point(150, 415);
            this.btnLimpiar.Size = new System.Drawing.Size(120, 38);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Text = "Salir";
            this.btnSalir.Location = new System.Drawing.Point(280, 415);
            this.btnSalir.Size = new System.Drawing.Size(120, 38);
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // frmPedidos
            this.ClientSize = new System.Drawing.Size(845, 480);
            this.Text = "Cafetería El Buen Sabor - Pedidos";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.Controls.Add(lblTitCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.chkFrecuente);
            this.Controls.Add(lblTitFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(lblTitProducto);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(lblTitPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(lblTitCantidad);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.grpTamano);
            this.Controls.Add(this.chkPorcionExtra);
            this.Controls.Add(this.grpServicio);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.lstPedido);
            this.Controls.Add(lblTitSubtotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(lblTitDescuento);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(lblTitEmpaque);
            this.Controls.Add(this.lblEmpaque);
            this.Controls.Add(lblTitItbis);
            this.Controls.Add(this.lblItbis);
            this.Controls.Add(lblTitTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);

            this.Load += new System.EventHandler(this.frmPedidos_Load);

            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.grpTamano.ResumeLayout(false);
            this.grpTamano.PerformLayout();
            this.grpServicio.ResumeLayout(false);
            this.grpServicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}