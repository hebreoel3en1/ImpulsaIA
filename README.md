# 👟 Impulsa Store Manizales — Sistema de Gestión, POS & E-Commerce Neumórfico

> **Proyecto de Gestión de Pequeños Negocios & Moda Urbana Premium**  
> **Sede Física**: Cra 23 #65-12, Sector El Cable, Manizales, Caldas (Eje Cafetero).  
> **Repositorio Oficial de Entrega**: [https://github.com/hebreoel3en1/ImpulsaIA.git](https://github.com/hebreoel3en1/ImpulsaIA.git)  
> **Usuario de Referencia Tablero**: `geniolokot9` / `hebreoel3en1`

---

## 🏆 Cumplimiento de los 7 Puntos del Tablero de Evaluación

| # | Criterio del Tablero | Estado | Evidencia y Ubicación |
|---|---|:---:|---|
| **1** | **Repositorio en GitHub** | ✅ Cumplido | Repositorio oficial configurado en `https://github.com/hebreoel3en1/ImpulsaIA.git` con control de versiones Git. |
| **2** | **Módulo / Skill "SkillNeitor"** | ✅ Cumplido | Asistente IA Local en `page-ia` respaldado por `SKILL_NEITOR_CONFIG` con **18 parámetros configurables** (UI, UX, reglas comerciales, prompts, barrios). |
| **3** | **Documentación Git con "GitNeitor"** | ✅ Cumplido | Explicación detallada del flujo de ramas, commits atómicos y metodología GitNeitor en este `README.md`. |
| **4** | **3 Manuales de Presentación** | ✅ Cumplido | `Manual_Tecnico.md`, `Manual_Usuario.md` y `Despliegue.md` generados como documentos independientes de nivel Senior. |
| **5** | **Versión Portable Windows** | ✅ Cumplido | Ejecutable nativo `ImpulsaStore.exe` (compilado en C# / .NET) + `Iniciar_Tienda.bat` + empaquetado en `ImpulsaStore_Windows_Portable.zip`. |
| **6** | **Catálogo Ampliado (~90 items)** | ✅ Cumplido | 90 prendas y sneakers premium con marcas (Nike, Hugo Boss, Under Gold, Off-White, Adidas, Puma, New Balance), tallas pills y fotos Unsplash reales. |
| **7** | **Accesibilidad WCAG 2.2 AA & Soft UI** | ✅ Cumplido | Filtros SVG daltonismo, interlineado, escala de texto Extra XL (140%), modo TDAH/Dislexia, reducción de movimiento y paletas neumórficas vivas. |

---

## 🤖 1. SkillNeitor: Motor de Inteligencia Artificial Local (18 Parámetros)

El módulo **SkillNeitor** fue concebido como una función de IA de alto rendimiento que opera 100% en el cliente, eliminando latencia de red y costos por token de APIs en la nube. Considera de forma integral la experiencia de usuario (UI), la accesibilidad (UX) y el ciclo de compilación:

```javascript
const SKILL_NEITOR_CONFIG = {
  // 1. Identidad y Prompts del Asistente
  nombre: "SkillNeitor IA Store",
  version: "2.5.0-Release",
  rol: "Asesor Senior de Moda Urbana & Logística Manizales",
  promptSistema: "Experto en calzado urbano, streetwear, control de stock y despacho en Manizales.",

  // 2. Parámetros de Inferencia y Modelo
  temperatura: 0.7,
  maxTokens: 500,
  contextoOffline: true,

  // 3. Reglas de Negocio Comercial y Auditoría
  umbralEnvioGratis: 150000,
  margenMinimoAlerta: 35,
  umbralStockCritico: 5,
  politicaGarantiaDias: 15,

  // 4. Georreferenciación y Despacho Local
  sedeCentral: "El Cable, Manizales (Cra 23 #65-12)",
  barriosCoberturaOficial: 24,
  tiempoBufferDespachoMinutos: 10,

  // 5. Tokens UI/UX, Audio y Accesibilidad
  colorBurbujaBot: "#4d7cfe",
  colorTextoBot: "#ffffff",
  colorBurbujaUser: "var(--bg-card)",
  sonidoInteraccion: true
};
```

### Capacidades del Motor SkillNeitor
- **Reconocimiento Semántico de Marcas**: Responde con existencias reales al consultar por *"Off-White"*, *"gorras Hugo Boss"*, *"camisetas Under Gold"* o *"tenis Nike"*.
- **Georreferenciación de 24 Barrios**: Calcula tiempos y tarifas saliendo desde El Cable hacia Palermo, Chipre, La Sultana, Malabar, Villamaría, etc.
- **Auditoría Financiera en Tiempo Real**: Computa facturación bruta, costos de inventario y margen neto real global.
- **Alertas de Stock Crítico**: Detecta modelos con 5 o menos unidades en bodega para reposición inmediata.

---

## 🐙 2. GitNeitor: Flujo de Gestión y Documentación en Git

Para asegurar trazabilidad, reproducibilidad y calidad de código de nivel Senior, se aplicó la disciplina **GitNeitor**:

```
[Main Branch]
     │
     ├── 1. feat(catalog): creación de catálogo premium ~90 productos (Nike, Boss, Under Gold, Off-White)
     ├── 2. feat(modal): rediseño de modal con select de marca, pills de tallas y toggle destacado
     ├── 3. feat(a11y): preferencias visuales WCAG 2.2 AA (Extra XL, interlineado, modo TDAH)
     ├── 4. feat(neumorphism): elevación clay 3D, microinteracciones táctiles y countdown a 8pm
     ├── 5. feat(skillneitor): módulo IA con 18 parámetros y reconocimiento de marcas de lujo
     ├── 6. build(portable): compilación de ImpulsaStore.exe y release portable ZIP para Windows
     └── 7. docs: manual técnico, manual de usuario y guía de despliegue en producción
```

### Comandos de Sincronización con el Repositorio Remoto
```bash
git remote add origin https://github.com/hebreoel3en1/ImpulsaIA.git
git add .
git commit -m "feat: entrega completa tablero - catalogo 90 productos, skillneitor, soft ui y release portable"
git branch -M main
git push -u origin main
```

---

## 📚 3. Manuales de Presentación

Encuentra la documentación técnica y de operación detallada en los siguientes archivos independientes:

1. [📘 Manual_Tecnico.md](file:///c:/Users/johan/OneDrive/Desktop/ImpulsaIA%20-%20Gesti%C3%B3n%20de%20Peque%C3%B1os%20Negocios%20johan/Manual_Tecnico.md): Arquitectura SPA, modelo de estado `estado`, ciclo de vida del `localStorage`, Web Audio API, JsBarcode y especificación técnica de SkillNeitor.
2. [🛍️ Manual_Usuario.md](file:///c:/Users/johan/OneDrive/Desktop/ImpulsaIA%20-%20Gesti%C3%B3n%20de%20Peque%C3%B1os%20Negocios%20johan/Manual_Usuario.md): Guía ilustrada para el administrador de boutique y cajero: cobros, cálculo de vueltas, selector de barrios en Manizales, envío de recibos por WhatsApp y cambio de paletas cromáticas.
3. [🚀 Despliegue.md](file:///c:/Users/johan/OneDrive/Desktop/ImpulsaIA%20-%20Gesti%C3%B3n%20de%20Peque%C3%B1os%20Negocios%20johan/Despliegue.md): Instrucciones para ejecución offline, uso de la versión portable `ImpulsaStore.exe`, servidor local en PowerShell y publicación gratuita en GitHub Pages / Vercel.

---

## 📦 4. Versión Portable para Windows

Para ejecutar la boutique en Windows sin depender de la interfaz tradicional del navegador:
1. Descarga el paquete comprimido `ImpulsaStore_Windows_Portable.zip`.
2. Extrae su contenido en cualquier carpeta o memoria USB.
3. Ejecuta `ImpulsaStore.exe` o `Iniciar_Tienda.bat`.
4. La tienda se abrirá en una ventana nativa de escritorio (1400x900) con aceleración gráfica completa.

---

## 🎨 5. Catálogo Premium (~90 Artículos)

Organizado bajo estrictos estándares de la moda urbana contemporánea con precios realistas en Pesos Colombianos (COP):
- **Nike (30 items)**: Air Force 1, Dunk Low Retro Panda, Air Jordan 1 Chicago, Air Jordan 4 Military Black / Bred, Air Max 90/97/270, Cortez Classic, Blazer Mid '77, Conjuntos Tech Fleece (Negro y Gris), Hoodies Club Fleece, Camisetas Dri-FIT y pantalones cargo.
- **Hugo Boss (12 items)**: Polos piqué Paddy (blanco, navy y gold edition), gorras con bordado en hilo de alta densidad, bermudas chino stretch, joggers athleisure y chaquetas bomber.
- **Under Gold (14 items)**: Camisetas oversize heavyweight boxy (240g), hoodies de felpa francesa pesada (450g), pantalones cargo multi-pocket, baggy denim y pecheras tácticas.
- **Off-White (12 items)**: Hoodies con flechas diagonales y pintura Caravaggio, camisetas *"FOR WALKING"*, sneakers Out of Office con tag de seguridad zip-tie y cinturón industrial amarillo.
- **Conjuntos Deportivos (10 items)**: Tracksuits cortavientos reflectivos para el clima de Manizales, conjuntos seamless leggings + top, biker shorts y chándals retro tricot.
- **Adidas, Puma, New Balance (12 items)**: Adidas Forum Low, Samba OG, Campus 00s; Puma Suede Classic XXI, Slipstream; New Balance 550, 9060 y 574.

---

## ♿ 6. Accesibilidad Web (WCAG 2.2 Nivel AA)

- **Filtros SVG de Daltonismo**: Protanopia, Deuteranopia, Tritanopia y Acromatopsia activos sin alterar la estructura del DOM.
- **Simulador y Preferencias Visuales**:
  - Escala de texto en 4 niveles (Normal, Grande, Muy Grande, **Extra XL a 140%**).
  - Interlineado ajustable (1.2, 1.5, **1.8 para dislexia**).
  - Grosor de fuente conmutable (400, 500, 600, **700 bold**).
  - Toggle **"Resaltar enlaces y botones"** (delineado continuo de alto contraste para TDAH).
  - Toggle **"Reducir animaciones"** (desactiva transiciones y rebotes).
  - Selector de moneda internacional (COP, USD, EUR) formateado mediante `Intl.NumberFormat`.
- **Navegación 100% por Teclado**: Todo botón, tarjeta o píldora cuenta con `:focus-visible` con anillo de contraste de 2px.

---

## 🏢 Identidad Comercial
- **Razón Social**: Impulsa Store Manizales — Sneakers & Streetwear Boutique
- **Sede Física**: Cra 23 #65-12, Sector El Cable, Manizales, Caldas, Colombia
- **Responsable**: Johan
- **Credenciales Demo**: Usuario: `Johan` | Clave: `1234`
