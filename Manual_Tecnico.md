# 📘 Manual Técnico de Arquitectura — Impulsa Store Manizales

> **Versión del Sistema**: 2.5.0 Premium Edition  
> **Diseño**: Neumorfismo Senior (Soft UI) + WCAG 2.2 AA  
> **Pila Tecnológica**: HTML5 Semántico, CSS3 Puro con Variables Custom, JavaScript Vanilla (ES6+), Web Audio API, JsBarcode.  
> **Patrón de Arquitectura**: Single Page Application (SPA) reactiva basada en Modelo de Estado Unificado y Persistencia Local sin Frameworks.

---

## 1. Resumen Ejecutivo y Especificaciones Técnicas

Impulsa Store Manizales es una solución de comercio electrónico, vitrina interactiva y Terminal de Punto de Venta (POS) diseñada para operar de forma 100% offline y autónoma. No requiere Node.js, npm, bundlers ni servidores backend para su funcionamiento esencial.

| Dimensión | Especificación Técnica |
|---|---|
| **Paradigma** | SPA (Single Page Application) sin recarga, navegación por display swap (`.page.active`). |
| **Estilo Visual** | Soft UI Neumorphic Design con doble sombra proyectada e invertida (`--shadow-raised` / `--shadow-inset`) y efecto Clay 3D (`--shadow-clay`). |
| **Accesibilidad** | Cumplimiento WCAG 2.2 Nivel AA. Filtros SVG para 4 variantes de daltonismo, interlineado dinámico, escala de fuentes (hasta 140%), modo TDAH/Dislexia y reducción de animaciones. |
| **Volumen de Datos** | Catálogo ampliado de **~90 productos premium** distribuidos en 8 marcas y 8 categorías. |
| **Persistencia** | `localStorage` del navegador bajo esquema JSON estructurado con migración automática no destructiva. |
| **Logística Local** | Mapeo de **24 barrios oficiales de Manizales** clasificados en 5 zonas con tarifas y tiempos dinámicos. |
| **Inteligencia Artificial** | Asistente Local (**SkillNeitor IA**) con motor de reglas y **18 parámetros configurables**. |

---

## 2. Modelo de Estado Global (`estado`)

La aplicación implementa un almacén de estado centralizado similar a Redux o Vuex, pero encapsulado en un objeto nativo plano:

```javascript
const estado = {
  auth: {
    isLoggedIn: true,
    usuario: 'Johan',
    rol: 'Administrador Boutique'
  },
  productos: [], // Array de ~90 objetos de producto
  ventas: [],    // Historial transaccional con auditoría de despacho
  carrito: [],   // Carrito activo de la terminal POS
  ultimoTicket: null,
  config: {
    negocio: "Impulsa Store Manizales — Sneakers & Streetwear",
    direccion: "Cra 23 #65-12, Sector El Cable, Manizales, Caldas",
    propietario: "Johan",
    moneda: "COP", // 'COP' | 'USD' | 'EUR'
    stockMin: 5,
    tarifaDomicilio: 5000,
    paleta: "clasico", // 'clasico' | 'azul' | 'gris' | 'arena' | 'menta' | 'oscuro'
    tema: "light",
    audio: true,
    bordes: "clasico",
    daltonismo: "normal", // 'protanopia' | 'deuteranopia' | 'tritanopia' | 'acromatopsia'
    tamanoTexto: "normal", // 'normal' | 'grande' | 'extra' | 'extra-xl'
    espaciadoLineas: "1.5", // '1.2' | '1.5' | '1.8'
    grosorFuente: "400",    // '400' | '500' | '600' | '700'
    resaltarEnlaces: false,
    reducirAnimaciones: false,
    clayMode: false,
    altoContraste: false,
    customBg: "#e0e5ec",
    customAccent: "#4d7cfe",
    customAccent2: "#00b894"
  }
};
```

### Funciones de Persistencia
- `safeGetStorage(key, fallback)`: Lee de `localStorage` con captura de excepciones (`try/catch`) y deserialización JSON segura.
- `safeSetStorage(key, data)`: Serializa y escribe en `localStorage`.
- `guardar()`: Función atómica que sincroniza las 4 claves principales:
  - `impulsa_auth`
  - `impulsa_productos`
  - `impulsa_ventas`
  - `impulsa_config`

---

## 3. Catálogo Premium (`CATALOGO_PREMIUM`) y Migración Transparente

### Estructura de Cada Producto
Cada ítem del catálogo implementa la siguiente firma canónica:

```typescript
interface Producto {
  id: number;              // Identificador único numérico (101 a 190)
  sku: string;             // Código SKU único (ej: "SKU-MNZ-001")
  nombre: string;          // Nombre comercial completo
  marca: string;           // 'Nike' | 'Hugo Boss' | 'Under Gold' | 'Off-White' | 'Adidas' | 'Puma' | 'New Balance' | 'Genérica'
  categoria: string;       // Una de las 8 categorías oficiales
  genero: string;          // 'Hombre' | 'Mujer' | 'Unisex'
  tallas: string[];        // Array de tallas disponibles (ej: ['38', '39', '40', '41'] o ['S', 'M', 'L'])
  costo: number;           // Costo de compra en COP (moneda base)
  precio: number;          // Precio de venta sugerido al público
  stock: number;           // Cantidad física disponible en bodega El Cable
  descripcion: string;     // Ficha técnica, material y corte
  imagen: string;          // URL de imagen real en alta definición (Unsplash con parámetros optimizados)
  destacado: boolean;      // Booleano para vitrina de dashboard
  vendidos: number;        // Contador para insignia 🔥 Trending
  activo: boolean;         // Estado comercial
  creadoEn: number;        // Timestamp Epoch
}
```

### Algoritmo de Migración Transparente (`migrarCatalogoPremium()`)
El sistema garantiza que los datos preexistentes del usuario no se destruyan ni se dupliquen:

1. **Inspección de SKUs**: Construye un `Set` con los `sku` ya existentes en `estado.productos`.
2. **Enriquecimiento de Campos Faltantes**: Si un producto preexistente no tenía `marca`, `genero`, `tallas` o `destacado`, el algoritmo deduce los valores según su nombre y categoría, evitando inconsistencias en renderizado.
3. **Fusión sin Duplicados**: Recorre `CATALOGO_PREMIUM` e inserta únicamente aquellos productos cuyo `sku` no figure en el `Set`.
4. **Persistencia Inmediata**: Si se agregaron productos o se enriquecieron campos, llama a `guardar()` y actualiza badges.

---

## 4. Sistema de Diseño Neumórfico (Soft UI 3D)

### Variables CSS y Física de Luz
El Neumorfismo se basa en simular una fuente de luz cenital izquierda a 45 grados:

```css
:root {
  --bg: #e0e5ec;
  --bg-dark: #d1d9e6;
  --bg-light: #ffffff;
  --border-color: rgba(163, 177, 198, 0.35);

  /* Sombras extruidas (Raised) */
  --shadow-raised: 8px 8px 16px #bec8d6, -8px -8px 16px #ffffff;
  --shadow-raised-sm: 4px 4px 8px #bec8d6, -4px -4px 8px #ffffff;
  --shadow-raised-lg: 12px 12px 24px #bec8d6, -12px -12px 24px #ffffff;

  /* Sombras deprimidas/hundidas (Inset / Debossed) */
  --shadow-inset: inset 4px 4px 8px #bec8d6, inset -4px -4px 8px #ffffff;
  --shadow-inset-sm: inset 2px 2px 5px #bec8d6, inset -2px -2px 5px #ffffff;

  /* Efecto Clay 3D */
  --shadow-clay: 6px 6px 12px rgba(0,0,0,0.08), -6px -6px 12px rgba(255,255,255,0.65);
}
```

### Microinteracciones
- `.btn:active`: Combina sombra deprimida `box-shadow: var(--shadow-inset-sm)` con una contracción háptica `transform: translateY(1px) scale(0.99)`.
- `.nav-item:hover`: Desplazamiento lateral suave `transform: translateX(3px)` con elevación `var(--shadow-raised-sm)`.
- `.prod-card:hover`: Elevación tridimensional y sombra plástica Clay suave.
- `:focus-visible`: Resalte estricto con `outline: 2px solid var(--accent); outline-offset: 2px;` para navegación 100% por teclado.

---

## 5. Accesibilidad Avanzada (WCAG 2.2 AA)

1. **Filtros SVG de Daltonismo**: Inyectados en el DOM como matrices de color `<feColorMatrix>`:
   - Protanopia (`#filter-protanopia`)
   - Deuteranopia (`#filter-deuteranopia`)
   - Tritanopia (`#filter-tritanopia`)
   - Acromatopsia (`#filter-acromatopsia`)
2. **Escala Tipográfica**: Soporta 4 niveles:
   - Normal: 16px
   - Grande: 18px (112%)
   - Muy Grande: 20px (125%)
   - Extra XL: 22.4px (140%)
3. **Control de Interlineado**: Clases dinámicas `body.line-height-1-2`, `1-5`, `1-8`.
4. **Control de Peso de Fuente**: Clases dinámicas `body.font-weight-400`, `500`, `600`, `700`.
5. **Modo TDAH / Dislexia**: Contorno perimetral continuo en todos los elementos interactivos (`body.resaltar-enlaces`).
6. **Reducción de Movimiento**: Regla universal `body.reducir-animaciones * { animation: none !important; transition: none !important; }`.

---

## 6. Módulo de Audio Neumórfico (`SoundService`)

Utiliza el sintetizador de frecuencia Web Audio API para generar retroalimentación auditiva sin archivos externos de sonido:
- `playClick()`: Onda senoidal corta a 800Hz con decaimiento en 40ms.
- `playSuccess()`: Progresión armónica ascendente (523Hz Do a 659Hz Mi) para cobros y registros exitosos.
- `playAlert()`: Onda cuadrada disonante a 220Hz para advertencias de stock o validación.
- Conmutable desde la barra superior y persistente en `estado.config.audio`.

---

## 7. Logística Geográfica de Manizales (`ZONAS_MANIZALES`)

Mapea 24 sectores de Manizales y Villamaría con tarifas y tiempos computados desde la sede principal en **El Cable (Cra 23 #65-12)**:
- **Zonas**: Oriente, Sur, Centro, Occidente y Conurbación (Villamaría).
- **Regla de Promoción**: Envíos **GRATIS ($0 COP)** automáticos cuando el subtotal del pedido supera los `$150.000 COP`.
- **Countdown**: Temporizador de cuenta regresiva hacia las 8:00 PM para la ventana de despacho en el día.

---

## 8. Arquitectura de SkillNeitor (Asistente IA Local)

El Asistente Inteligente no depende de servidores externos ni APIs de pago. Funciona localmente mediante un motor de inferencia contextual con **18 parámetros configurables**:

| # | Parámetro | Valor por Defecto | Propósito Técnico |
|---|---|---|---|
| 1 | `nombre` | `"SkillNeitor IA Store"` | Identificador formal del módulo |
| 2 | `version` | `"2.5.0-Release"` | Versión de compilación del motor |
| 3 | `rol` | `"Asesor Senior de Moda Urbana & Logística"` | Definición de rol conversacional |
| 4 | `promptSistema` | Directiva de negocio | Guía de respuestas e inventario |
| 5 | `temperatura` | `0.7` | Factor de variabilidad lingüística |
| 6 | `maxTokens` | `500` | Límite de longitud de respuesta |
| 7 | `contextoOffline` | `true` | Modo autónomo sin dependencias externas |
| 8 | `umbralEnvioGratis`| `150000` | Regla financiera para subsidio de flete |
| 9 | `margenMinimoAlerta`| `35%` | Alerta de rentabilidad comercial |
| 10 | `umbralStockCritico`| `5` | Disparador de alerta de reposición |
| 11 | `politicaGarantiaDias`| `15` | Regla para cambios de talla en tienda |
| 12 | `sedeCentral` | `"El Cable, Manizales (Cra 23 #65-12)"`| Punto de origen logístico |
| 13 | `barriosCoberturaOficial`| `24` | Universo de barrios validados |
| 14 | `tiempoBufferDespachoMinutos`| `10` | Tiempo base de empaque y alistamiento |
| 15 | `colorBurbujaBot` | `"#4d7cfe"` | Token de diseño para mensajes del bot |
| 16 | `colorTextoBot` | `"#ffffff"` | Contraste de texto en mensajes del bot |
| 17 | `colorBurbujaUser`| `"var(--bg-card)"` | Token neumórfico para mensajes de usuario |
| 18 | `sonidoInteraccion`| `true` | Señal acústica sincronizada con SoundService |
