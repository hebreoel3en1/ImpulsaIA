# Especificación técnica: ImpulsaIA - Gestión de Pequeños Negocios

> Crear un software que permita a pequeños negocios administrar sus ventas, productos e inventarios de forma sencilla, utilizando inteligencia artificial para generar recomendaciones y facilitar la toma de decisiones.

**Alcance**

El sistema permitirá registrar productos, controlar inventarios, gestionar ventas y clientes, consultar ganancias y generar reportes. También contará con un asistente de inteligencia artificial. No incluirá inicialmente facturación electrónica ni aplicaciones móviles.

**Contexto general**

Desarrollar una aplicación web moderna, sencilla y adaptable a celulares y computadores. Utilizar HTML, CSS, JavaScript, React, Node.js y PostgreSQL. Mantener el código organizado, seguro y fácil de entender. El sistema estará dirigido a pequeños comerciantes y emprendedores. Todo debe estar en español. Desarrollar y probar cada módulo paso a paso, explicando el código y su funcionamiento con lenguaje sencillo.

_Generado con SkillNeitor 1.2.0 · 2026-11-09 · 46 ítems · 13 categorías_

## Índice

1. [Producto y descubrimiento](#producto-y-descubrimiento)
2. [UX/UI y accesibilidad](#ux-ui-y-accesibilidad)
3. [Arquitectura y patrones](#arquitectura-y-patrones)
4. [Frontend web](#frontend-web)
5. [Backend y APIs](#backend-y-apis)
6. [Datos y persistencia](#datos-y-persistencia)
7. [IA y asistentes](#ia-y-asistentes)
8. [Seguridad y privacidad](#seguridad-y-privacidad)
9. [DevOps y observabilidad](#devops-y-observabilidad)
10. [Calidad y pruebas](#calidad-y-pruebas)
11. [Documentación y mantenimiento](#documentacion-y-mantenimiento)
12. [Móvil y escritorio](#movil-y-escritorio)
13. [Analítica y negocio](#analitica-y-negocio)

---

# Producto y descubrimiento

_Problema, alcance, usuarios, métricas y priorización._

## Definición del problema y propuesta de valor

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Producto

### Cómo usarlo

Esta skill de producto te ayuda a antes de elegir tecnología, dejar explícito qué problema resuelve el producto, para quién y por qué merece existir. Úsala como guía: Describir el problema en una frase verificable, sin nombrar la solución. Identificar usuario primario, usuario secundario y contexto de uso. Comprueba el resultado con: Existe un documento de una página con problema, usuarios y valor.

### Propósito

Antes de elegir tecnología, dejar explícito qué problema resuelve el producto, para quién y por qué merece existir.

### Lineamientos

- Describir el problema en una frase verificable, sin nombrar la solución.
- Identificar usuario primario, usuario secundario y contexto de uso.
- Documentar alternativas actuales y el coste de no resolverlo.
- Definir una propuesta de valor que pueda contrastarse con evidencia.

### Criterios de aceptación

- [ ] Existe un documento de una página con problema, usuarios y valor.
- [ ] El equipo puede explicar el problema sin mencionar la implementación.
- [ ] Hay al menos una hipótesis falsable y una métrica asociada.

### Antipatrones

- Empezar por el stack o por una lista de pantallas.
- Confundir funcionalidades con problemas de usuario.

### Referencias

- Working Backwards (Amazon)
- Continuous Discovery Habits

## Gestión de requisitos y alcance

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Producto

### Cómo usarlo

Esta skill de producto te ayuda a gestionar cambios de alcance con visibilidad de impacto, decisión explícita y trazabilidad. Úsala como guía: Mantener un registro de requisitos con estado y dueño. Valorar cada cambio por impacto en tiempo, riesgo y calidad. Comprueba el resultado con: Todo cambio relevante tiene decisión registrada.

### Propósito

Gestionar cambios de alcance con visibilidad de impacto, decisión explícita y trazabilidad.

### Lineamientos

- Mantener un registro de requisitos con estado y dueño.
- Valorar cada cambio por impacto en tiempo, riesgo y calidad.
- Separar alcance comprometido de ideas futuras.
- Comunicar decisiones y congelaciones de alcance.

### Criterios de aceptación

- [ ] Todo cambio relevante tiene decisión registrada.
- [ ] El alcance vigente es visible para todo el equipo.
- [ ] Los recortes no se hacen silenciosamente.

### Antipatrones

- Aceptar cambios sin ajustar tiempo o alcance.
- Documentar requisitos en conversaciones privadas.

### Referencias

- Scope creep management
- PRINCE2 principles

## Historias de usuario y criterios de aceptación

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Producto

### Cómo usarlo

Esta skill de producto te ayuda a convertir necesidades en historias pequeñas, verificables y con criterios de aceptación claros. Úsala como guía: Formato: como [rol] quiero [capacidad] para [beneficio]. Añadir criterios de aceptación en formato dado/cuando/entonces. Comprueba el resultado con: Cada historia tiene criterios de aceptación ejecutables.

### Propósito

Convertir necesidades en historias pequeñas, verificables y con criterios de aceptación claros.

### Lineamientos

- Formato: como [rol] quiero [capacidad] para [beneficio].
- Añadir criterios de aceptación en formato dado/cuando/entonces.
- Incluir casos límite, errores y permisos, no solo el camino feliz.
- Mantener cada historia con valor observable y tamaño de iteración.

### Criterios de aceptación

- [ ] Cada historia tiene criterios de aceptación ejecutables.
- [ ] Los casos de error y permisos están cubiertos.
- [ ] Una persona ajena puede validar la historia sin preguntar al autor.

### Antipatrones

- Historias técnicas sin valor visible.
- Criterios ambiguos como "debe funcionar bien".

### Referencias

- User Stories Applied (Mike Cohn)
- Example Mapping

## Métricas de producto y objetivos

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Producto

### Cómo usarlo

Esta skill de producto te ayuda a elegir pocas métricas que informen decisiones y evitar paneles llenos de números sin dueño. Úsala como guía: Definir métrica principal, métricas de soporte y contramétricas. Usar objetivos con resultado esperado y fecha. Comprueba el resultado con: Cada métrica tiene definición y fuente única de verdad.

### Propósito

Elegir pocas métricas que informen decisiones y evitar paneles llenos de números sin dueño.

### Lineamientos

- Definir métrica principal, métricas de soporte y contramétricas.
- Usar objetivos con resultado esperado y fecha.
- Documentar fórmula, fuente y frecuencia de cada métrica.
- Revisar métricas en rituales concretos, no solo acumularlas.

### Criterios de aceptación

- [ ] Cada métrica tiene definición y fuente única de verdad.
- [ ] Hay una contramétrica para evitar optimizaciones dañinas.
- [ ] Existe un ritual periódico de revisión y decisión.

### Antipatrones

- Medir solo vanidad (visitas, descargas).
- Cambiar la definición de una métrica sin versión.

### Referencias

- North Star Metric
- Lean Analytics

## MVP y priorización

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Producto

### Cómo usarlo

Esta skill de producto te ayuda a definir el mínimo producto que valida la hipótesis principal y separar lo urgente de lo importante. Úsala como guía: Identificar el flujo crítico de extremo a extremo que debe funcionar. Priorizar con impacto, confianza, esfuerzo y riesgo. Comprueba el resultado con: El MVP tiene un flujo principal demostrable.

### Propósito

Definir el mínimo producto que valida la hipótesis principal y separar lo urgente de lo importante.

### Lineamientos

- Identificar el flujo crítico de extremo a extremo que debe funcionar.
- Priorizar con impacto, confianza, esfuerzo y riesgo.
- Excluir explícitamente lo que no entra en la primera versión.
- Definir criterios de salida y siguientes incrementos.

### Criterios de aceptación

- [ ] El MVP tiene un flujo principal demostrable.
- [ ] Existe una lista de exclusiones conscientes.
- [ ] Las prioridades son trazables a objetivos de producto.

### Antipatrones

- Llamar MVP a un producto completo.
- Priorizar por quién grita más fuerte.

### Referencias

- The Lean Startup
- RICE prioritization

# UX/UI y accesibilidad

_Experiencia, sistema de diseño, responsive y WCAG._

## Accesibilidad WCAG 2.2 AA

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** UX/UI, Accesibilidad

### Cómo usarlo

Esta skill de UX/UI te ayuda a diseñar y verificar interfaces usables con teclado, lectores de pantalla, contraste y movimiento reducido. Úsala como guía: HTML semántico primero; ARIA solo cuando aporta significado. Foco visible, orden lógico y objetivos táctiles de al menos 24×24 px. Comprueba el resultado con: Toda la app se recorre solo con teclado.

### Propósito

Diseñar y verificar interfaces usables con teclado, lectores de pantalla, contraste y movimiento reducido.

### Lineamientos

- HTML semántico primero; ARIA solo cuando aporta significado.
- Foco visible, orden lógico y objetivos táctiles de al menos 24×24 px.
- Contraste AA: 4.5:1 texto normal y 3:1 texto grande.
- Respetar prefers-reduced-motion y prefers-reduced-transparency.

### Criterios de aceptación

- [ ] Toda la app se recorre solo con teclado.
- [ ] Los modales atrapan y devuelven el foco.
- [ ] Estados y errores se anuncian en regiones vivas.

### Antipatrones

- Usar divs clicables sin rol ni teclado.
- Placeholders como única etiqueta.

### Referencias

- WCAG 2.2
- ARIA Authoring Practices

## Arquitectura de información y navegación

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** UX/UI, Accesibilidad

### Cómo usarlo

Esta skill de UX/UI te ayuda a organizar contenidos y acciones según las tareas del usuario, con rutas predecibles y poca carga cognitiva. Úsala como guía: Agrupar por tareas, no por organigrama interno. Limitar profundidad de navegación y mantener migas cuando aporten. Comprueba el resultado con: El usuario encuentra las tareas principales en dos pasos o menos.

### Propósito

Organizar contenidos y acciones según las tareas del usuario, con rutas predecibles y poca carga cognitiva.

### Lineamientos

- Agrupar por tareas, no por organigrama interno.
- Limitar profundidad de navegación y mantener migas cuando aporten.
- Hacer visible el estado activo y la ubicación actual.
- Validar etiquetas con pruebas de árbol o card sorting.

### Criterios de aceptación

- [ ] El usuario encuentra las tareas principales en dos pasos o menos.
- [ ] La navegación funciona con historial y enlaces profundos.
- [ ] Las etiquetas son comprensibles sin jerga interna.

### Antipatrones

- Menús gigantes sin jerarquía.
- Cambiar la ubicación de acciones entre pantallas.

### Referencias

- Information Architecture (Rosenfeld)
- Nielsen Norman Group

## Diseño responsive y adaptativo

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** UX/UI, Accesibilidad

### Cómo usarlo

Esta skill de UX/UI te ayuda a adaptar la interfaz a tamaños y capacidades reales sin degradar jerarquía ni accesibilidad. Úsala como guía: Diseñar por contenido y tareas, no por dispositivos concretos. Definir breakpoints y comportamientos esperados. Comprueba el resultado con: La app es usable a 320 px, 768 px, 1024 px y zoom 200 %.

### Propósito

Adaptar la interfaz a tamaños y capacidades reales sin degradar jerarquía ni accesibilidad.

### Lineamientos

- Diseñar por contenido y tareas, no por dispositivos concretos.
- Definir breakpoints y comportamientos esperados.
- Evitar scroll horizontal no intencional y tablas inutilizables.
- Probar zoom, orientación y tamaños intermedios.

### Criterios de aceptación

- [ ] La app es usable a 320 px, 768 px, 1024 px y zoom 200 %.
- [ ] Las tablas ofrecen patrón alternativo en móvil.
- [ ] La navegación principal sigue disponible.

### Antipatrones

- Ocultar funciones esenciales en móvil.
- Diseñar solo para el portátil del desarrollador.

### Referencias

- Responsive Web Design
- Container queries

## Formularios y validación UX

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** UX/UI, Accesibilidad

### Cómo usarlo

Esta skill de UX/UI te ayuda a reducir errores y fricción con etiquetas claras, validación útil y conservación del trabajo. Úsala como guía: Etiqueta visible, ayuda contextual y campos agrupados por significado. Validar al salir del campo y al enviar; no interrumpir en cada tecla. Comprueba el resultado con: Los errores se anuncian y reciben foco.

### Propósito

Reducir errores y fricción con etiquetas claras, validación útil y conservación del trabajo.

### Lineamientos

- Etiqueta visible, ayuda contextual y campos agrupados por significado.
- Validar al salir del campo y al enviar; no interrumpir en cada tecla.
- Mensajes que expliquen cómo corregir, junto al campo.
- No perder datos ante errores; permitir deshacer cuando sea posible.

### Criterios de aceptación

- [ ] Los errores se anuncian y reciben foco.
- [ ] Los campos obligatorios se identifican antes de enviar.
- [ ] El formulario funciona con autocompletado y teclado.

### Antipatrones

- Validar solo con color.
- Borrar el formulario tras un fallo de red.

### Referencias

- GOV.UK Design System: Form patterns

## Microcopy y estados vacíos

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** UX/UI, Accesibilidad

### Cómo usarlo

Esta skill de UX/UI te ayuda a usar el texto y los estados vacíos para orientar la siguiente acción y reducir la incertidumbre. Úsala como guía: Cada estado vacío explica qué es la pantalla y qué hacer. Errores con causa, impacto y siguiente paso. Comprueba el resultado con: Todo listado vacío tiene acción sugerida.

### Propósito

Usar el texto y los estados vacíos para orientar la siguiente acción y reducir la incertidumbre.

### Lineamientos

- Cada estado vacío explica qué es la pantalla y qué hacer.
- Errores con causa, impacto y siguiente paso.
- Acciones nombradas por resultado, no por mecanismo.
- Tono consistente y localizable.

### Criterios de aceptación

- [ ] Todo listado vacío tiene acción sugerida.
- [ ] Los errores incluyen recuperación.
- [ ] Los textos evitan culpar al usuario.

### Antipatrones

- "No hay datos" sin contexto.
- Botones "Aceptar" para acciones distintas.

### Referencias

- Mailchimp Content Style Guide
- UX Writing

## Sistema de diseño y tokens

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** UX/UI, Accesibilidad

### Cómo usarlo

Esta skill de UX/UI te ayuda a definir una fuente única de tokens y componentes para que la interfaz evolucione sin inconsistencias. Úsala como guía: Separar tokens primitivos, semánticos y de componente. Versionar componentes con estados, tamaños y accesibilidad. Comprueba el resultado con: Colores, espaciado, radios y tipografía salen de tokens.

### Propósito

Definir una fuente única de tokens y componentes para que la interfaz evolucione sin inconsistencias.

### Lineamientos

- Separar tokens primitivos, semánticos y de componente.
- Versionar componentes con estados, tamaños y accesibilidad.
- Documentar uso, no solo apariencia.
- Mantener ejemplos vivos y pruebas visuales.

### Criterios de aceptación

- [ ] Colores, espaciado, radios y tipografía salen de tokens.
- [ ] Cada componente documenta estados y teclado.
- [ ] No hay valores mágicos duplicados en la UI.

### Antipatrones

- Crear componentes solo para una pantalla.
- Cambiar tokens globales para arreglar un caso local.

### Ejemplo

```css
:root {
  --color-accent: #39f6c8;
  --space-2: 8px;
  --radius-md: 10px;
}
.button { background: var(--color-accent); padding: var(--space-2); border-radius: var(--radius-md); }
```

### Referencias

- Design Tokens Community Group
- Atomic Design

# Arquitectura y patrones

_Estilos arquitectónicos, límites, APIs y decisiones estructurales._

## Diseño de API REST versionada

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Arquitectura, APIs

### Cómo usarlo

Esta skill de arquitectura te ayuda a diseñar recursos, errores y versiones de api que evolucionen sin romper consumidores. Úsala como guía: Recursos en plural, identificadores estables y verbos HTTP correctos. Respuestas de error con código, mensaje y traza. Comprueba el resultado con: El contrato está documentado y probado.

### Propósito

Diseñar recursos, errores y versiones de API que evolucionen sin romper consumidores.

### Lineamientos

- Recursos en plural, identificadores estables y verbos HTTP correctos.
- Respuestas de error con código, mensaje y traza.
- Paginación, filtros y ordenamiento consistentes.
- Versionado explícito y política de deprecación.

### Criterios de aceptación

- [ ] El contrato está documentado y probado.
- [ ] Los errores son predecibles y no filtran datos internos.
- [ ] Los cambios incompatibles tienen nueva versión.

### Antipatrones

- Devolver 200 con errores embebidos.
- Romper contratos sin aviso.

### Ejemplo

```bash
GET /v1/projects?limit=20&cursor=abc
200 OK
{
  "data": [],
  "nextCursor": null
}
```

### Referencias

- API Design Patterns
- Zalando RESTful API Guidelines

## Monolito modular

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Arquitectura, APIs

### Cómo usarlo

Esta skill de arquitectura te ayuda a construir una sola unidad desplegable con límites internos claros, suficiente para la mayoría de productos. Úsala como guía: Definir módulos por dominio y prohibir imports cruzados arbitrarios. Exponer contratos internos explícitos y encapsular persistencia. Comprueba el resultado con: Los módulos no acceden a tablas de otros módulos sin contrato.

### Propósito

Construir una sola unidad desplegable con límites internos claros, suficiente para la mayoría de productos.

### Lineamientos

- Definir módulos por dominio y prohibir imports cruzados arbitrarios.
- Exponer contratos internos explícitos y encapsular persistencia.
- Mantener una sola base de datos con tablas por dominio.
- Preparar extracción futura sin pagar el coste de microservicios prematuros.

### Criterios de aceptación

- [ ] Los módulos no acceden a tablas de otros módulos sin contrato.
- [ ] El despliegue sigue siendo una unidad reproducible.
- [ ] Existe una prueba que detecta dependencias prohibidas.

### Antipatrones

- Monolito con un único paquete global.
- Microservicios por moda.

### Referencias

- Modular Monolith (Kamil Grzybek)
- Shopify monolith

# Frontend web

_Rendering, estado, componentes, PWA e internacionalización._

## Componentes semánticos y accesibles

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Web, JavaScript

### Cómo usarlo

Esta skill de frontend te ayuda a encapsular ui con html semántico, teclado y atributos accesibles desde el propio componente. Úsala como guía: Preferir elementos nativos antes que roles ARIA. Gestionar foco, estados y anuncios en componentes interactivos. Comprueba el resultado con: No hay divs con onClick sin alternativa de teclado.

### Propósito

Encapsular UI con HTML semántico, teclado y atributos accesibles desde el propio componente.

### Lineamientos

- Preferir elementos nativos antes que roles ARIA.
- Gestionar foco, estados y anuncios en componentes interactivos.
- Exponer props claras y evitar efectos ocultos.
- Probar cada componente con teclado y lector.

### Criterios de aceptación

- [ ] No hay divs con onClick sin alternativa de teclado.
- [ ] Los componentes tienen estados hover, focus, disabled y error.
- [ ] Los tests cubren navegación por teclado.

### Antipatrones

- Reinventar select o modal sin accesibilidad.
- Props booleanas contradictorias.

### Referencias

- WAI-ARIA Authoring Practices
- Inclusive Components

## Formularios y validación frontend

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Web, JavaScript

### Cómo usarlo

Esta skill de frontend te ayuda a implementar formularios con validación consistente, accesible y alineada con el servidor. Úsala como guía: Esquema de validación compartido o replicado explícitamente. Errores por campo y error global. Comprueba el resultado con: El servidor vuelve a validar todo.

### Propósito

Implementar formularios con validación consistente, accesible y alineada con el servidor.

### Lineamientos

- Esquema de validación compartido o replicado explícitamente.
- Errores por campo y error global.
- Estados submitting, success y error.
- Evitar doble envío e hidratar valores iniciales.

### Criterios de aceptación

- [ ] El servidor vuelve a validar todo.
- [ ] Los errores son accesibles y enfocables.
- [ ] El formulario no pierde datos al fallar.

### Antipatrones

- Confiar solo en validación cliente.
- Deshabilitar el botón sin explicar por qué.

### Referencias

- HTML constraint validation
- Zod

## Gestión de estado del cliente

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Web, JavaScript

### Cómo usarlo

Esta skill de frontend te ayuda a distinguir estado local, compartido y remoto para evitar fuentes de verdad duplicadas. Úsala como guía: Estado local para UI efímera; store para estado compartido. Caché de servidor con invalidación por evento. Comprueba el resultado con: Cada dato tiene una única fuente de verdad.

### Propósito

Distinguir estado local, compartido y remoto para evitar fuentes de verdad duplicadas.

### Lineamientos

- Estado local para UI efímera; store para estado compartido.
- Caché de servidor con invalidación por evento.
- Flujo unidireccional y acciones explícitas.
- Evitar derivar estado que pueda calcularse.

### Criterios de aceptación

- [ ] Cada dato tiene una única fuente de verdad.
- [ ] No hay actualizaciones impredecibles entre componentes.
- [ ] El estado se puede inspeccionar en desarrollo.

### Antipatrones

- Duplicar datos remotos en varios stores.
- Mutar estado directamente.

### Referencias

- Redux style guide
- Zustand patterns

# Backend y APIs

_Contratos, autenticación, idempotencia, colas y errores._

## Autenticación y autorización

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Backend, APIs

### Cómo usarlo

Esta skill de backend te ayuda a separar identidad de permisos y aplicar autorización en servidor para cada recurso. Úsala como guía: Sesiones seguras, rotación y expiración. RBAC/ABAC con comprobaciones en servidor. Comprueba el resultado con: Cada endpoint valida autenticación y autorización.

### Propósito

Separar identidad de permisos y aplicar autorización en servidor para cada recurso.

### Lineamientos

- Sesiones seguras, rotación y expiración.
- RBAC/ABAC con comprobaciones en servidor.
- No confiar en roles enviados por el cliente.
- Auditar accesos sensibles y revocaciones.

### Criterios de aceptación

- [ ] Cada endpoint valida autenticación y autorización.
- [ ] Hay pruebas de acceso denegado por rol.
- [ ] Los tokens no se guardan en lugares inseguros.

### Antipatrones

- Ocultar botones como control de acceso.
- IDs predecibles sin autorización por recurso.

### Referencias

- OWASP Authentication Cheat Sheet
- OAuth 2.1

## Contratos de API y OpenAPI

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Backend, APIs, OpenAPI

### Cómo usarlo

Esta skill de backend te ayuda a tratar el contrato como producto: documentado, versionado y verificado contra la implementación. Úsala como guía: Especificación OpenAPI como fuente de verdad. Generar clientes, mocks y validaciones desde el contrato. Comprueba el resultado con: La implementación valida contra el contrato.

### Propósito

Tratar el contrato como producto: documentado, versionado y verificado contra la implementación.

### Lineamientos

- Especificación OpenAPI como fuente de verdad.
- Generar clientes, mocks y validaciones desde el contrato.
- Definir errores, paginación y ejemplos.
- Verificar compatibilidad en CI.

### Criterios de aceptación

- [ ] La implementación valida contra el contrato.
- [ ] Los cambios incompatibles se detectan en CI.
- [ ] El contrato incluye ejemplos ejecutables.

### Antipatrones

- Documentar después y a mano.
- Permitir respuestas fuera del esquema.

### Referencias

- OpenAPI 3.1
- Spectral

## Errores, logging y trazabilidad

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Backend, APIs

### Cómo usarlo

Esta skill de backend te ayuda a producir errores accionables y correlacionar logs, métricas y trazas sin filtrar datos sensibles. Úsala como guía: Códigos de error estables y mensajes para usuario. Correlation ID por petición y propagación entre servicios. Comprueba el resultado con: Cada error tiene traza y contexto.

### Propósito

Producir errores accionables y correlacionar logs, métricas y trazas sin filtrar datos sensibles.

### Lineamientos

- Códigos de error estables y mensajes para usuario.
- Correlation ID por petición y propagación entre servicios.
- Logs estructurados con niveles y sampling.
- No registrar secretos ni datos personales.

### Criterios de aceptación

- [ ] Cada error tiene traza y contexto.
- [ ] Los logs permiten reconstruir una petición.
- [ ] Los datos sensibles se redactan.

### Antipatrones

- Loggear objetos completos con tokens.
- Stack traces al usuario final.

### Referencias

- OpenTelemetry
- Google SRE Book

## Idempotencia y reintentos

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Backend, APIs

### Cómo usarlo

Esta skill de backend te ayuda a hacer que operaciones repetidas no dupliquen efectos y que los reintentos sean seguros. Úsala como guía: Clave de idempotencia en mutaciones críticas. Reintentos con backoff exponencial y jitter. Comprueba el resultado con: Reenviar la misma petición no crea duplicados.

### Propósito

Hacer que operaciones repetidas no dupliquen efectos y que los reintentos sean seguros.

### Lineamientos

- Clave de idempotencia en mutaciones críticas.
- Reintentos con backoff exponencial y jitter.
- Distinguir errores reintentables de permanentes.
- Registrar y deduplicar en ventana definida.

### Criterios de aceptación

- [ ] Reenviar la misma petición no crea duplicados.
- [ ] Los reintentos no amplifican fallos.
- [ ] La ventana de idempotencia está documentada.

### Antipatrones

- Reintentar pagos sin clave única.
- Reintentar errores 4xx.

### Referencias

- Stripe idempotency
- AWS retry guidance

# Datos y persistencia

_Modelado, migraciones, transacciones, búsqueda y backups._

## Migraciones de base de datos

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** SQL, SQLite

### Cómo usarlo

Esta skill de datos te ayuda a evolucionar el esquema con migraciones versionadas, reversibles cuando sea posible y probadas. Úsala como guía: Cada migración tiene versión, autor y propósito. Probar en copia de datos reales anonimizados. Comprueba el resultado con: Una base vacía y una existente migran al mismo esquema.

### Propósito

Evolucionar el esquema con migraciones versionadas, reversibles cuando sea posible y probadas.

### Lineamientos

- Cada migración tiene versión, autor y propósito.
- Probar en copia de datos reales anonimizados.
- Separar cambios compatibles de ruptura.
- Planificar rollback o migración compensatoria.

### Criterios de aceptación

- [ ] Una base vacía y una existente migran al mismo esquema.
- [ ] El tiempo de migración está medido.
- [ ] La app tolera versiones adyacentes durante despliegue.

### Antipatrones

- Editar migraciones ya aplicadas.
- Migraciones sin backup.

### Referencias

- Zero-downtime migrations
- Flyway

## Modelo relacional y normalización

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** SQL, SQLite

### Cómo usarlo

Esta skill de datos te ayuda a modelar entidades, relaciones y restricciones que representen el dominio y protejan la integridad. Úsala como guía: Claves primarias estables y foráneas explícitas. Normalizar hasta que duela; desnormalizar con motivo. Comprueba el resultado con: La base impide estados inválidos.

### Propósito

Modelar entidades, relaciones y restricciones que representen el dominio y protejan la integridad.

### Lineamientos

- Claves primarias estables y foráneas explícitas.
- Normalizar hasta que duela; desnormalizar con motivo.
- Restricciones NOT NULL, UNIQUE y CHECK.
- Documentar el modelo y sus invariantes.

### Criterios de aceptación

- [ ] La base impide estados inválidos.
- [ ] Las consultas críticas tienen índice.
- [ ] El modelo se entiende sin preguntar al autor.

### Antipatrones

- Guardar arrays en columnas de texto sin necesidad.
- Sin claves foráneas por pereza.

### Ejemplo

```sql
CREATE TABLE items (
  id TEXT PRIMARY KEY,
  project_id TEXT NOT NULL REFERENCES projects(id),
  title TEXT NOT NULL,
  created_at TEXT NOT NULL
);
```

### Referencias

- SQL Antipatterns
- Use The Index, Luke

## Privacidad y retención de datos

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** SQL, SQLite

### Cómo usarlo

Esta skill de datos te ayuda a minimizar datos, definir retención y permitir exportación y borrado con trazabilidad. Úsala como guía: Recoger solo datos necesarios y con base legal. Definir plazos de retención por tipo. Comprueba el resultado con: Cada campo personal tiene propósito y retención.

### Propósito

Minimizar datos, definir retención y permitir exportación y borrado con trazabilidad.

### Lineamientos

- Recoger solo datos necesarios y con base legal.
- Definir plazos de retención por tipo.
- Implementar exportación y borrado de usuario.
- Anonimizar datos en entornos no productivos.

### Criterios de aceptación

- [ ] Cada campo personal tiene propósito y retención.
- [ ] El borrado se propaga a backups según política.
- [ ] Los logs no conservan PII innecesaria.

### Antipatrones

- Retener todo para siempre.
- Usar datos reales en desarrollo.

### Referencias

- GDPR
- NIST Privacy Framework

## Transacciones y consistencia

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** SQL, SQLite

### Cómo usarlo

Esta skill de datos te ayuda a definir qué operaciones deben ser atómicas y cómo se mantiene la consistencia entre agregados. Úsala como guía: Delimitar transacciones cortas y claras. Entender niveles de aislamiento y sus anomalías. Comprueba el resultado con: No quedan escrituras parciales.

### Propósito

Definir qué operaciones deben ser atómicas y cómo se mantiene la consistencia entre agregados.

### Lineamientos

- Delimitar transacciones cortas y claras.
- Entender niveles de aislamiento y sus anomalías.
- Usar outbox para consistencia entre DB y eventos.
- Diseñar compensaciones para procesos distribuidos.

### Criterios de aceptación

- [ ] No quedan escrituras parciales.
- [ ] Los conflictos de concurrencia están probados.
- [ ] Los procesos multi-paso tienen compensación.

### Antipatrones

- Transacciones que llaman APIs externas.
- Asumir consistencia fuerte entre servicios.

### Referencias

- Designing Data-Intensive Applications
- Transaction isolation levels

# IA y asistentes

_LLM local, RAG, prompts, evaluación y streaming._

## Evaluación de respuestas IA

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Ollama, LLM

### Cómo usarlo

Esta skill de IA te ayuda a medir calidad, fidelidad y seguridad con conjuntos de prueba y criterios explícitos. Úsala como guía: Definir rúbricas y casos de oro. Combinar evaluación automática y revisión humana. Comprueba el resultado con: Hay un set de evaluación reproducible.

### Propósito

Medir calidad, fidelidad y seguridad con conjuntos de prueba y criterios explícitos.

### Lineamientos

- Definir rúbricas y casos de oro.
- Combinar evaluación automática y revisión humana.
- Medir alucinaciones, formato y utilidad.
- Versionar resultados por modelo y prompt.

### Criterios de aceptación

- [ ] Hay un set de evaluación reproducible.
- [ ] Los cambios de modelo se comparan.
- [ ] Los fallos críticos bloquean el despliegue.

### Antipatrones

- Evaluar solo con impresiones.
- Cambiar modelo sin regresión.

### Referencias

- LLM evaluation guide
- Ragas

## Integración con LLM local (Ollama)

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Ollama, LLM

### Cómo usarlo

Esta skill de IA te ayuda a integrar un modelo local con detección de servicio, streaming, cancelación y degradación clara. Úsala como guía: Configurar endpoint y modelo por entorno. Verificar disponibilidad antes de habilitar el chat. Comprueba el resultado con: La app funciona sin Ollama y explica cómo instalarlo.

### Propósito

Integrar un modelo local con detección de servicio, streaming, cancelación y degradación clara.

### Lineamientos

- Configurar endpoint y modelo por entorno.
- Verificar disponibilidad antes de habilitar el chat.
- Streaming con cancelación y timeout.
- No enviar datos a la nube sin consentimiento.

### Criterios de aceptación

- [ ] La app funciona sin Ollama y explica cómo instalarlo.
- [ ] El streaming se puede detener.
- [ ] El modelo y endpoint son configurables.

### Antipatrones

- Bloquear la app si el modelo no está.
- Hardcodear el endpoint.

### Referencias

- Ollama API
- OpenAI-compatible APIs

## Prompt engineering versionado

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Ollama, LLM

### Cómo usarlo

Esta skill de IA te ayuda a tratar prompts y system prompts como artefactos versionados, probados y auditables. Úsala como guía: Guardar prompts con versión y changelog. Separar instrucciones estables de contexto dinámico. Comprueba el resultado con: Cada cambio de prompt tiene versión y motivo.

### Propósito

Tratar prompts y system prompts como artefactos versionados, probados y auditables.

### Lineamientos

- Guardar prompts con versión y changelog.
- Separar instrucciones estables de contexto dinámico.
- Probar con casos representativos y adversariales.
- Limitar longitud y datos sensibles.

### Criterios de aceptación

- [ ] Cada cambio de prompt tiene versión y motivo.
- [ ] Existe un set de pruebas de regresión.
- [ ] El prompt final se puede previsualizar.

### Antipatrones

- Editar prompts en producción sin registro.
- Concatenar contexto sin límite.

### Referencias

- Prompt engineering guide
- Anthropic prompt library

## Seguridad y límites de IA

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Ollama, LLM

### Cómo usarlo

Esta skill de IA te ayuda a defenderse de prompt injection, fuga de contexto y acciones no autorizadas del asistente. Úsala como guía: Tratar contenido recuperado como no confiable. Separar instrucciones de sistema y datos. Comprueba el resultado con: El asistente no ejecuta acciones sin confirmación.

### Propósito

Defenderse de prompt injection, fuga de contexto y acciones no autorizadas del asistente.

### Lineamientos

- Tratar contenido recuperado como no confiable.
- Separar instrucciones de sistema y datos.
- Limitar herramientas y permisos del asistente.
- Filtrar salidas y registrar acciones.

### Criterios de aceptación

- [ ] El asistente no ejecuta acciones sin confirmación.
- [ ] El contenido del usuario no altera reglas del sistema.
- [ ] Las salidas peligrosas se bloquean o marcan.

### Antipatrones

- Dar al LLM acceso directo a disco o shell.
- Confiar en el prompt como control de acceso.

### Referencias

- OWASP LLM Top 10
- Prompt injection

# Seguridad y privacidad

_Amenazas, secretos, saneamiento, cifrado y auditoría._

## Auditoría y logs de seguridad

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Seguridad

### Cómo usarlo

Esta skill de seguridad te ayuda a registrar eventos de seguridad relevantes con integridad, retención y acceso restringido. Úsala como guía: Registrar login, cambios de permisos y acciones sensibles. Incluir actor, acción, recurso, resultado y timestamp. Comprueba el resultado con: Las acciones sensibles son auditables.

### Propósito

Registrar eventos de seguridad relevantes con integridad, retención y acceso restringido.

### Lineamientos

- Registrar login, cambios de permisos y acciones sensibles.
- Incluir actor, acción, recurso, resultado y timestamp.
- Proteger logs contra alteración.
- Definir retención y acceso.

### Criterios de aceptación

- [ ] Las acciones sensibles son auditables.
- [ ] Los logs no contienen secretos.
- [ ] Existe alerta para patrones anómalos.

### Antipatrones

- Logs solo locales y borrables por usuario.
- Auditar sin revisar.

### Referencias

- OWASP Logging Cheat Sheet
- NIST SP 800-92

## Cifrado en tránsito y reposo

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Seguridad

### Cómo usarlo

Esta skill de seguridad te ayuda a proteger datos con tls moderno, cifrado en reposo y gestión segura de claves. Úsala como guía: TLS 1.2+ y HSTS en producción. Cifrado de backups y discos. Comprueba el resultado con: Todo tráfico externo usa TLS.

### Propósito

Proteger datos con TLS moderno, cifrado en reposo y gestión segura de claves.

### Lineamientos

- TLS 1.2+ y HSTS en producción.
- Cifrado de backups y discos.
- Claves separadas de datos y rotables.
- No inventar criptografía propia.

### Criterios de aceptación

- [ ] Todo tráfico externo usa TLS.
- [ ] Los backups están cifrados.
- [ ] Las claves tienen rotación documentada.

### Antipatrones

- Certificados autofirmados en producción.
- Cifrar con clave en el mismo repo.

### Referencias

- OWASP Cryptographic Storage
- Mozilla SSL config

## Gestión de secretos

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Seguridad

### Cómo usarlo

Esta skill de seguridad te ayuda a mantener claves fuera del código y rotarlas con procedimientos claros y auditoría. Úsala como guía: Secretos en gestor dedicado o variables seguras. Nunca en repositorio, logs ni imágenes. Comprueba el resultado con: El escaneo de secretos está en CI.

### Propósito

Mantener claves fuera del código y rotarlas con procedimientos claros y auditoría.

### Lineamientos

- Secretos en gestor dedicado o variables seguras.
- Nunca en repositorio, logs ni imágenes.
- Rotación y revocación documentadas.
- Separar secretos por entorno.

### Criterios de aceptación

- [ ] El escaneo de secretos está en CI.
- [ ] Los secretos se rotan tras incidente.
- [ ] El desarrollador no necesita ver producción.

### Antipatrones

- .env commiteado.
- Secretos en el frontend.

### Referencias

- OWASP Secrets Management
- HashiCorp Vault

## OWASP ASVS y Top 10

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Seguridad

### Cómo usarlo

Esta skill de seguridad te ayuda a usar estándares verificables para autenticación, sesión, validación, criptografía y errores. Úsala como guía: Elegir nivel ASVS adecuado al riesgo. Mapear controles a pruebas concretas. Comprueba el resultado con: Los controles aplicables están implementados.

### Propósito

Usar estándares verificables para autenticación, sesión, validación, criptografía y errores.

### Lineamientos

- Elegir nivel ASVS adecuado al riesgo.
- Mapear controles a pruebas concretas.
- Revisar Top 10 en cada release.
- Documentar excepciones y riesgo aceptado.

### Criterios de aceptación

- [ ] Los controles aplicables están implementados.
- [ ] Hay pruebas automatizadas de los críticos.
- [ ] Las excepciones tienen dueño y fecha.

### Antipatrones

- Cumplimiento de papel sin pruebas.
- Ignorar errores de configuración.

### Referencias

- OWASP ASVS
- OWASP Top 10

## Validación de entradas y rutas

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Seguridad

### Cómo usarlo

Esta skill de seguridad te ayuda a validar forma, tipo y límites de toda entrada, y confinar rutas a directorios permitidos. Úsala como guía: Validar en servidor con esquema. Resolver rutas y verificar que quedan dentro de la raíz. Comprueba el resultado con: Los payloads ../../ se rechazan.

### Propósito

Validar forma, tipo y límites de toda entrada, y confinar rutas a directorios permitidos.

### Lineamientos

- Validar en servidor con esquema.
- Resolver rutas y verificar que quedan dentro de la raíz.
- Rechazar traversal, enlaces simbólicos y nombres reservados.
- Limitar tamaño y profundidad.

### Criterios de aceptación

- [ ] Los payloads ../../ se rechazan.
- [ ] Las entradas fuera de rango fallan con error claro.
- [ ] Los archivos extraídos no escapan del destino.

### Antipatrones

- Confiar en validación del cliente.
- Concatenar rutas sin resolver.

### Referencias

- OWASP Input Validation
- Zip Slip

# DevOps y observabilidad

_CI/CD, contenedores, entornos, telemetría y rollback._

## Despliegue, rollback y migración

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Docker, CI/CD

### Cómo usarlo

Esta skill de DevOps te ayuda a desplegar sin downtime con estrategias progresivas y vuelta atrás ensayada. Úsala como guía: Canary, blue-green o rolling según riesgo. Migraciones compatibles hacia atrás. Comprueba el resultado con: Un despliegue fallido vuelve atrás en minutos.

### Propósito

Desplegar sin downtime con estrategias progresivas y vuelta atrás ensayada.

### Lineamientos

- Canary, blue-green o rolling según riesgo.
- Migraciones compatibles hacia atrás.
- Rollback automatizado por métricas.
- Comunicación y runbook de incidente.

### Criterios de aceptación

- [ ] Un despliegue fallido vuelve atrás en minutos.
- [ ] La migración no rompe la versión anterior.
- [ ] El rollback está probado.

### Antipatrones

- Big bang sin plan.
- Migraciones destructivas en el mismo paso.

### Referencias

- Blue-green deployment
- Feature flags

## Entornos y configuración

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Docker, CI/CD

### Cómo usarlo

Esta skill de DevOps te ayuda a mantener paridad entre desarrollo, staging y producción con configuración explícita. Úsala como guía: Mismos artefactos, distinta configuración. Datos sintéticos en entornos no productivos. Comprueba el resultado con: Staging reproduce producción en lo relevante.

### Propósito

Mantener paridad entre desarrollo, staging y producción con configuración explícita.

### Lineamientos

- Mismos artefactos, distinta configuración.
- Datos sintéticos en entornos no productivos.
- Acceso y secretos separados.
- Documentar diferencias inevitables.

### Criterios de aceptación

- [ ] Staging reproduce producción en lo relevante.
- [ ] No se usan datos reales en desarrollo.
- [ ] La configuración está versionada.

### Antipatrones

- "En mi máquina funciona".
- Cambios manuales en producción.

### Referencias

- The Twelve-Factor App
- Environment parity

## Observabilidad: logs, métricas y trazas

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Docker, CI/CD

### Cómo usarlo

Esta skill de DevOps te ayuda a instrumentar el sistema para responder qué falla, dónde y por qué, con correlación entre señales. Úsala como guía: Logs estructurados con correlation ID. Métricas RED/USE y dashboards por servicio. Comprueba el resultado con: Una petición se sigue de extremo a extremo.

### Propósito

Instrumentar el sistema para responder qué falla, dónde y por qué, con correlación entre señales.

### Lineamientos

- Logs estructurados con correlation ID.
- Métricas RED/USE y dashboards por servicio.
- Trazas distribuidas en rutas críticas.
- Alertas basadas en síntomas de usuario.

### Criterios de aceptación

- [ ] Una petición se sigue de extremo a extremo.
- [ ] Hay alertas de latencia, errores y saturación.
- [ ] Los dashboards tienen dueño.

### Antipatrones

- Solo logs de texto sin contexto.
- Alertas que nadie atiende.

### Referencias

- OpenTelemetry
- Google SRE

# Calidad y pruebas

_Estrategia de pruebas, contratos, E2E, carga y accesibilidad._

## Datos de prueba y fixtures

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Testing

### Cómo usarlo

Esta skill de calidad te ayuda a crear datos representativos, aislados y sin información real, con generación reproducible. Úsala como guía: Factories y seeds versionados. Datos anonimizados o sintéticos. Comprueba el resultado con: Ninguna prueba usa PII real.

### Propósito

Crear datos representativos, aislados y sin información real, con generación reproducible.

### Lineamientos

- Factories y seeds versionados.
- Datos anonimizados o sintéticos.
- Escenarios límite incluidos.
- Limpieza y aislamiento por prueba.

### Criterios de aceptación

- [ ] Ninguna prueba usa PII real.
- [ ] Los datos cubren casos límite.
- [ ] La generación es determinista cuando importa.

### Antipatrones

- Copiar producción a staging.
- Fixtures gigantes sin propósito.

### Referencias

- Faker
- Test data management

## E2E y pruebas de aceptación

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Testing

### Cómo usarlo

Esta skill de calidad te ayuda a automatizar los flujos de usuario que sostienen el negocio, con datos y entorno reproducibles. Úsala como guía: Pocos escenarios, alto valor. Selectores estables y accesibles. Comprueba el resultado con: Los flujos críticos se ejecutan en CI.

### Propósito

Automatizar los flujos de usuario que sostienen el negocio, con datos y entorno reproducibles.

### Lineamientos

- Pocos escenarios, alto valor.
- Selectores estables y accesibles.
- Datos independientes y limpieza.
- Artefactos de fallo: captura, video, traza.

### Criterios de aceptación

- [ ] Los flujos críticos se ejecutan en CI.
- [ ] Los fallos son diagnosticables.
- [ ] Las pruebas no dependen de orden.

### Antipatrones

- E2E para cada detalle visual.
- Selectores por posición DOM.

### Referencias

- Playwright
- Cypress best practices

## Estrategia de pruebas por capas

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Testing

### Cómo usarlo

Esta skill de calidad te ayuda a distribuir pruebas unitarias, integración, contrato y e2e según riesgo y coste de feedback. Úsala como guía: Muchas unitarias rápidas, menos E2E críticas. Cada capa prueba lo que no puede probar la anterior. Comprueba el resultado con: Los flujos críticos tienen E2E.

### Propósito

Distribuir pruebas unitarias, integración, contrato y E2E según riesgo y coste de feedback.

### Lineamientos

- Muchas unitarias rápidas, menos E2E críticas.
- Cada capa prueba lo que no puede probar la anterior.
- Definir qué es crítico y qué se automatiza.
- Medir cobertura de comportamiento, no solo líneas.

### Criterios de aceptación

- [ ] Los flujos críticos tienen E2E.
- [ ] Las pruebas unitarias no dependen de red.
- [ ] La suite falla de forma determinista.

### Antipatrones

- Solo E2E lentas.
- Cobertura alta sin aserciones útiles.

### Referencias

- Test Pyramid
- Practical Test Pyramid

## Pruebas unitarias

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Testing

### Cómo usarlo

Esta skill de calidad te ayuda a probar reglas y funciones puras con casos límite, rápidos y sin infraestructura. Úsala como guía: Nombrar por comportamiento esperado. Incluir límites, errores y casos vacíos. Comprueba el resultado con: Las reglas de negocio tienen pruebas.

### Propósito

Probar reglas y funciones puras con casos límite, rápidos y sin infraestructura.

### Lineamientos

- Nombrar por comportamiento esperado.
- Incluir límites, errores y casos vacíos.
- Evitar mocks excesivos.
- Mantener ejecución por debajo de segundos.

### Criterios de aceptación

- [ ] Las reglas de negocio tienen pruebas.
- [ ] Los casos límite están cubiertos.
- [ ] Las pruebas no dependen del orden.

### Antipatrones

- Probar getters triviales.
- Mocks que replican la implementación.

### Referencias

- Test Desiderata
- xUnit patterns

# Documentación y mantenimiento

_README, ADRs, API, runbooks y manual de usuario._

## Documentación de API

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Markdown, OpenAPI

### Cómo usarlo

Esta skill de documentación te ayuda a publicar contratos navegables, ejemplos y errores, generados desde la especificación. Úsala como guía: OpenAPI como fuente de verdad. Ejemplos de request/response y errores. Comprueba el resultado con: La documentación se genera del contrato.

### Propósito

Publicar contratos navegables, ejemplos y errores, generados desde la especificación.

### Lineamientos

- OpenAPI como fuente de verdad.
- Ejemplos de request/response y errores.
- Autenticación, paginación y límites.
- Versionado y changelog.

### Criterios de aceptación

- [ ] La documentación se genera del contrato.
- [ ] Los ejemplos se validan.
- [ ] Hay guía de migración entre versiones.

### Antipatrones

- Documentación manual desincronizada.
- Ocultar errores y límites.

### Referencias

- OpenAPI
- Redoc

## Manual de usuario y changelog

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Markdown

### Cómo usarlo

Esta skill de documentación te ayuda a explicar el producto a usuarios finales y comunicar cambios de forma comprensible. Úsala como guía: Guía por tareas y capturas actualizadas. Changelog con impacto y migración. Comprueba el resultado con: Las tareas principales están documentadas.

### Propósito

Explicar el producto a usuarios finales y comunicar cambios de forma comprensible.

### Lineamientos

- Guía por tareas y capturas actualizadas.
- Changelog con impacto y migración.
- Búsqueda y ayuda contextual.
- Accesibilidad de la documentación.

### Criterios de aceptación

- [ ] Las tareas principales están documentadas.
- [ ] Cada release tiene changelog.
- [ ] Las capturas coinciden con la versión.

### Antipatrones

- Changelog de commits.
- Manual sin versión.

### Referencias

- Keep a Changelog
- Semantic Versioning

## README y guía de inicio

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Markdown

### Cómo usarlo

Esta skill de documentación te ayuda a permitir que una persona nueva entienda, instale y ejecute el proyecto sin ayuda informal. Úsala como guía: Qué es, para quién y qué resuelve. Requisitos, instalación y comandos básicos. Comprueba el resultado con: Un nuevo desarrollador arranca siguiendo el README.

### Propósito

Permitir que una persona nueva entienda, instale y ejecute el proyecto sin ayuda informal.

### Lineamientos

- Qué es, para quién y qué resuelve.
- Requisitos, instalación y comandos básicos.
- Configuración, tests y troubleshooting.
- Enlaces a documentación profunda.

### Criterios de aceptación

- [ ] Un nuevo desarrollador arranca siguiendo el README.
- [ ] Los comandos están probados.
- [ ] Las variables de entorno están documentadas.

### Antipatrones

- README desactualizado.
- Suposiciones de conocimiento interno.

### Referencias

- Make a README
- Diátaxis

# Móvil y escritorio

_Apps multiplataforma, shells de escritorio, updates y sync._

## Actualizaciones y distribución

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Mobile

### Cómo usarlo

Esta skill de móvil y escritorio te ayuda a publicar versiones instalables, portables y actualizaciones con integridad verificable. Úsala como guía: Versionado semántico y artefactos por plataforma. Firma de código cuando sea posible. Comprueba el resultado con: Cada release tiene artefactos y checksums.

### Propósito

Publicar versiones instalables, portables y actualizaciones con integridad verificable.

### Lineamientos

- Versionado semántico y artefactos por plataforma.
- Firma de código cuando sea posible.
- Canales estable/beta y notas.
- Checksums y verificación de descarga.

### Criterios de aceptación

- [ ] Cada release tiene artefactos y checksums.
- [ ] La instalación limpia funciona.
- [ ] La actualización conserva datos.

### Antipatrones

- Releases sin notas.
- Artefactos no reproducibles.

### Referencias

- Semantic Versioning
- electron-builder

## Shell de escritorio (Electron/Tauri)

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Mobile, Electron, Tauri

### Cómo usarlo

Esta skill de móvil y escritorio te ayuda a construir una app de escritorio segura, actualizable y con integración nativa mínima. Úsala como guía: Contexto aislado y API preload mínima. Ventana, atajos, bandeja y diálogos nativos. Comprueba el resultado con: El renderer no tiene acceso a Node.

### Propósito

Construir una app de escritorio segura, actualizable y con integración nativa mínima.

### Lineamientos

- Contexto aislado y API preload mínima.
- Ventana, atajos, bandeja y diálogos nativos.
- Actualizaciones firmadas y rollback.
- Empaquetado por plataforma.

### Criterios de aceptación

- [ ] El renderer no tiene acceso a Node.
- [ ] La app recuerda tamaño y estado.
- [ ] La actualización no corrompe datos.

### Antipatrones

- nodeIntegration true por comodidad.
- Auto-update sin firma.

### Referencias

- Electron security
- Tauri security

# Analítica y negocio

_Eventos, facturación, experimentación, soporte y legal._

## Legal, términos y licencias

**Prioridad:** should · **Estado:** aprobado · **Tecnologías:** Analytics

### Cómo usarlo

Esta skill de negocio te ayuda a definir términos, privacidad y licencias de dependencias coherentes con el producto. Úsala como guía: Términos y privacidad versionados. Licencias de terceros y atribuciones. Comprueba el resultado con: Las licencias se revisan en CI.

### Propósito

Definir términos, privacidad y licencias de dependencias coherentes con el producto.

### Lineamientos

- Términos y privacidad versionados.
- Licencias de terceros y atribuciones.
- Límites de responsabilidad y uso aceptable.
- Consentimientos y cookies cuando apliquen.

### Criterios de aceptación

- [ ] Las licencias se revisan en CI.
- [ ] La política coincide con la práctica.
- [ ] Los cambios legales se comunican.

### Antipatrones

- Copiar términos de otra empresa.
- Ignorar licencias copyleft.

### Referencias

- SPDX
- Open Source Licenses
