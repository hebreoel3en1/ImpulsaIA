# 🛍️ Manual de Usuario — Impulsa Store Manizales

> **Boutique de Moda Urbana, Sneakers & Streetwear**  
> **Sede Principal**: Cra 23 #65-12, Sector El Cable, Manizales, Caldas.  
> **Cobertura**: 24 Barrios de Manizales y Villamaría.

---

## 1. Acceso al Sistema

Para ingresar a la terminal comercial:
1. Abre el archivo `index.html` en tu navegador o haz doble clic en `ImpulsaStore.exe` / `Iniciar_Tienda.bat`.
2. En la pantalla de bienvenida neumórfica:
   - **Usuario**: `Johan` (o `admin`)
   - **Contraseña**: `1234`
   - O presiona el botón **"⚡ Ingreso Rápido (1-Clic)"** para entrar de forma instantánea sin escribir.
3. El sistema emitirá un sonido de bienvenida y te situará en el **Dashboard Principal**.

---

## 2. Pantalla Principal (Dashboard)

El Dashboard te ofrece una vista panorámica en tiempo real:
- **Banner de Manizales**: Muestra el estado operativo de los despachos locales y el **Contador Regresivo de Envío Gratis**, que te indica cuánto tiempo queda antes del corte de las 8:00 PM para despachos en el mismo día.
- **Tarjetas KPI**:
  - 💰 **Ingresos Brutos**: Facturación total acumulada.
  - 📈 **Pedidos Despachados**: Número total de órdenes entregadas.
  - 👟 **Prendas en Catálogo**: Total de referencias registradas.
  - 🏷️ **Margen Promedio**: Rentabilidad global estimada sobre costos.
- **Vitrina Destacada en Sede El Cable**: Muestra una selección exclusiva de **hasta 8 prendas y sneakers marcados como destacados**, con insignias de marca, stock en bodega y botón directo **"Ver todo →"** para ir al catálogo completo.

---

## 3. Catálogo de Moda & Filtros por Marca

Accede mediante el menú lateral en **👟 Catálogo**:
- **Buscador Universal**: Escribe el nombre de la prenda, un SKU (ej: `SKU-MNZ-010`), o palabras clave como "hoodie", "panda", "retro".
- **Filtro de Categorías**: Permite aislar:
  - Tenis & Sneakers Nike
  - Conjuntos & Sudaderas
  - Camisetas & Polos
  - Pantalones & Jeans
  - Hoodies & Chaquetas
  - Gorras & Accesorios
  - **Conjuntos Deportivos** (NUEVO)
  - **Streetwear Premium** (NUEVO)
- **Filtro de Marcas Oficiales**: Filtra por:
  - **Nike** (Air Force 1, Dunk, Air Jordan 1/4, Tech Fleece, Dri-FIT)
  - **Hugo Boss** (Polos piqué, gorras bordadas gold, bermudas chino)
  - **Under Gold** (Camisetas oversize boxy, hoodies heavy terry, cargo pants)
  - **Off-White** (Hoodies flechas diagonales, camisetas "FOR WALKING", Out of Office)
  - **Adidas** (Forum Low, Samba OG, Campus 00s, track tops)
  - **Puma** (Suede Classic XXI, Slipstream, Downtown)
  - **New Balance** (550, 9060, 574)
  - **Genérica** (Conjuntos deportivos y prendas multimarca)
- **Insignias en Tarjetas**:
  - **Marca**: Visible en la esquina superior derecha de la foto.
  - **🔥 Trending**: Visible automáticamente en prendas que registran ventas.
  - **Botón Quick-Add (+)**: Agrega la prenda al pedido actual con 1 clic.

---

## 4. Crear o Editar Prendas (Modal Rediseñado)

Para agregar o modificar un artículo:
1. Haz clic en **➕ Agregar Prenda** (en catálogo o inventario) o en el ícono de lápiz ✏️ de cualquier tarjeta.
2. Completa los datos en el modal neumórfico:
   - **SKU**: Código de referencia comercial (generado automáticamente).
   - **Categoría de Moda**: Elige entre las 8 opciones. Al cambiar de categoría, el sistema te sugerirá tallas de calzado o de ropa de forma automática.
   - **Marca Oficial**: Selecciona la casa diseñadora (Nike, Hugo Boss, Under Gold, Off-White, etc.).
   - **Género**: Unisex, Hombre o Mujer.
   - **Nombre de la Prenda**: Nombre comercial descriptivo.
   - **Tallas Disponibles (Pills)**: Haz clic en las píldoras interactivas (ej. 38, 39, 40, 41 para tenis; o S, M, L, XL para buzos) para encenderlas o apagarlas.
   - **⭐ Destacado en vitrina**: Activa esta casilla si deseas que la prenda aparezca en el Dashboard principal.
   - **Costo de Compra (COP)** y **Precio de Venta (COP)**: El sistema calculará el **margen de ganancia estimado** en tiempo real.
   - **Stock en Bodega**: Cantidad disponible en la sede El Cable.
   - **Fotografía**: Puedes pegar una URL de alta definición de Unsplash o subir una foto local desde tu equipo.
3. Presiona **Guardar Prenda**.

---

## 5. Terminal Punto de Venta (POS) & Despacho Manizales

En la sección **⚡ Ventas**:
1. **Armar el Pedido**: Haz clic sobre los productos en la cuadrícula izquierda para añadirlos a la comanda. Ajusta cantidades con los botones `+` y `-`.
2. **Modalidad de Entrega**:
   - **🏬 Retiro en Sede El Cable**: Costo de envío $0.
   - **🛵 Domicilio en Manizales**: Despliega la lista de **24 barrios oficiales**.
     - Selecciona el barrio de destino (ej: *Palermo*, *Chipre*, *La Sultana*, *Milán*, *La Enea*, *Villamaría*).
     - El sistema indicará el **tiempo estimado en minutos** y la **tarifa base de transporte**.
     - 🎁 **Promoción Automática**: Si el subtotal de prendas supera los **$150.000 COP**, el flete se convertirá automáticamente en **¡GRATIS ($0)!**.
3. **Datos del Cliente**: Ingresa nombre, teléfono y dirección de entrega.
4. **Forma de Pago & Vueltas**:
   - Selecciona **Efectivo**, **Nequi / Bancolombia QR**, o **Tarjeta Débito/Crédito**.
   - En efectivo, digita el monto con el que paga el cliente; la caja calculará las vueltas exactas que debe llevar el mensajero.
5. **Confirmar Venta**:
   - El sistema reproducirá un sonido de éxito con Web Audio API.
   - Se abrirá la tirilla térmica de **80mm con código de barras generado por JsBarcode**.
   - Puedes hacer clic en **📲 Enviar por WhatsApp** para enviar el resumen del pedido directamente al chat del comprador con un mensaje ya redactado.
   - O presionar **🖨️ Imprimir Recibo**.

---

## 6. Asistente IA Local (SkillNeitor)

En la pestaña **🤖 Asistente IA**:
- Puedes formular preguntas en lenguaje natural sobre marcas, inventario, precios o rutas.
- **Botones de Preguntas Rápidas**:
  - 🔥 *Off-White*: Consulta las referencias de alta costura disponibles.
  - 🎩 *Hugo Boss*: Conoce el stock de polos y gorras bordadas.
  - 👑 *Under Gold*: Muestra las camisetas oversize y hoodies boxy.
  - 👟 *Más vendidos*: Detecta el producto estrella del histórico de ventas.
  - ⏱️ *Domicilio Palermo*: Consulta tiempos y tarifas saliendo desde El Cable.
  - ⚠️ *Stock crítico*: Te alerta si hay tallas con existencias bajas (≤ 5 uds).
  - 💰 *Ganancia neta*: Resume el balance financiero de tu negocio.

---

## 7. Configuración, Paletas & Preferencias Visuales

En **⚙️ Configuración**:
- **Paletas Neumórficas**: Elige entre 6 temas cromáticos con 1 clic:
  - 🏛️ *Clásico SENA* (`#e0e5ec`)
  - ❄️ *Azul Suave* (`#e8edf3`)
  - 📄 *Gris Neutro* (`#ebecf0`)
  - 🌾 *Arena Caldense* (`#ede8e1`)
  - 🍃 *Menta Fresca* (`#e2ece9`)
  - 🌙 *Modo Oscuro* (`#1e222d`)
- **Extrusión 3D en Vivo**: Usa los selectores de color hexadecimal para modificar el fondo y los acentos en tiempo real.
- **Simulador y Preferencias Visuales (Accesibilidad WCAG 2.2 AA)**:
  - **Escala de Texto**: Normal, Grande, Muy Grande y **Extra XL (140%)**.
  - **Espaciado entre Líneas**: Compacto (1.2), Estándar (1.5) y Amplio (1.8 para dislexia).
  - **Grosor de Fuente**: 400 (Regular), 500 (Medium), 600 (Semibold), 700 (Bold).
  - **Efecto Clay 3D**: Activa una suave sombra plástica en las tarjetas.
  - **Resaltar enlaces y botones**: Delineado de alto contraste para personas con TDAH o baja visión.
  - **Reducir animaciones**: Desactiva transiciones para personas sensibles al movimiento.
  - **Símbolo de Moneda**: Cambia entre COP, USD y EUR con formato internacional.
- **Copias de Seguridad**:
  - 📤 *Descargar Respaldo JSON*: Guarda todas tus ventas y productos en un archivo en tu computador.
  - 📥 *Restaurar JSON*: Carga un archivo de respaldo previo sin complicaciones.
  - 🔄 *Cargar Catálogo Premium*: Restaura las ~90 referencias oficiales con fotografías reales HD.
