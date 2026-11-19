# Cafetería El Buen Sabor — Sistema de Pedidos (`examen_cafeteria_luisperalta`)

## 1. Nombre y matrícula
- **Nombre:** Luis Miguel Peralta Sánchez
- **Matrícula:** 2024-1259

## 2. Descripción del programa
Aplicación de escritorio en C# Windows Forms con un único formulario (`frmPedidos`) para registrar pedidos de la cafetería El Buen Sabor, calcular totales por línea, acumular subtotal y calcular descuento por cliente frecuente, cargo por empaque para llevar, ITBIS (18%) y total a pagar en RD$.

## 3. Datos de entrada
- Nombre del cliente (`txtCliente`) y casilla de cliente frecuente (`chkFrecuente`).
- Fecha del pedido (`dtpFecha`).
- Producto (`txtProducto`), precio unitario digitado (`txtPrecio`) y cantidad de `1` a `20` (`nudCantidad`).
- Tamaño: `Normal` (`rbtNormal`) o `Grande` (`rbtGrande`, +RD$25).
- Porción extra (`chkPorcionExtra`, +RD$30).
- Servicio: `Consumir en local` (`rbtLocal`) o `Para llevar` (`rbtLlevar`, +RD$20).

## 4. Proceso
1. **Precio unitario:** precio digitado + `RD$25.00` (si es Grande) + `RD$30.00` (si lleva porción extra).
2. **Total de línea:** precio unitario × cantidad, agregado a `lstPedido` con fuente `Consolas` y anchos de columna `6, 24, 10, 12`.
3. **Subtotal:** suma acumulada de todas las líneas agregadas al pedido.
4. **Descuento:** `10%` del subtotal si `chkFrecuente` está marcado.
5. **Empaque:** `RD$20.00` una sola vez por pedido si `rbtLlevar` está seleccionado.
6. **Base imponible:** subtotal − descuento + empaque.
7. **ITBIS:** `18%` de la base imponible.
8. **Total a pagar:** base imponible + ITBIS.

## 5. Salida
- Encabezado de columnas en `lblEncabezado` y detalle de líneas en `lstPedido`.
- Resultados en formato `RD$ 0.00` en `lblSubtotal`, `lblDescuento`, `lblEmpaque`, `lblItbis` y `lblTotal`.
- Caso de prueba (María Pérez, frecuente, Sándwich 180 cant. 2 Grande = 410.00, Jugo 120 cant. 1 con porción extra = 150.00, para llevar): Subtotal `RD$ 560.00`, Descuento `RD$ 56.00`, Empaque `RD$ 20.00`, Base `524.00`, ITBIS `RD$ 94.32`, Total `RD$ 618.32`.

## 6. Capturas de pantalla del programa en ejecución
<img width="921" height="538" alt="image" src="https://github.com/user-attachments/assets/fe9a5845-9887-4351-8e71-88584a5aa32b" />
