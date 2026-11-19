# 🚀 Guía de Despliegue e Instalación — Impulsa Store Manizales

Este documento detalla todas las alternativas para desplegar, ejecutar y distribuir **Impulsa Store Manizales** tanto de forma local (offline/escritorio) como en servidores web y plataformas en la nube.

---

## 1. Ejecución Local Inmediata (Sin Instalaciones)

Dado que la solución está desarrollada en **HTML5, CSS3 y Vanilla JavaScript** en un único archivo autónomo:

1. Navega a la carpeta del proyecto.
2. Haz doble clic sobre el archivo `index.html`.
3. Se abrirá automáticamente en cualquier navegador moderno (Microsoft Edge, Google Chrome, Mozilla Firefox, Brave, Safari) con todas las funcionalidades de persistencia `localStorage`, Web Audio API y generación de códigos de barras activas.

---

## 2. Versión Portable Nativa para Windows (.exe y .zip)

Para entregar al usuario final una experiencia de **software de escritorio premium** sin interfaz de navegador visible:

### Contenido del Paquete Portable (`ImpulsaStore_Windows_Portable.zip`)
- `ImpulsaStore.exe`: Ejecutable compilado en C# / .NET Framework que lanza la aplicación en **Modo Aplicación de Escritorio (`--app`)** con dimensiones optimizadas de 1400x900px, eliminando pestañas, barra de direcciones y botones ajenos.
- `Iniciar_Tienda.bat`: Script de inicio rápido de respaldo para cualquier versión de Windows.
- `index.html`: Archivo principal con el código y catálogo completo.
- `README.md`: Documentación esencial.

### Instrucciones para el Usuario
1. Descarga y descomprime `ImpulsaStore_Windows_Portable.zip`.
2. Haz doble clic en `ImpulsaStore.exe`.
3. La boutique se abrirá en una ventana de aplicación dedicada e independiente.

---

## 3. Servidor Local Ligero (Opcional)

Si deseas servir la aplicación a través de la red local (para que otros computadores o celulares conectados al WiFi de la sede El Cable puedan acceder al POS):

### Opción A: Con Python (si está instalado)
```bash
python -m http.server 8080
```
Luego abre en el navegador: `http://localhost:8080` (o desde otro celular `http://IP_DE_TU_PC:8080`).

### Opción B: Con PowerShell (Nativo de Windows)
Ejecuta en una terminal PowerShell:
```powershell
$listener = New-Object System.Net.HttpListener
$listener.Prefixes.Add("http://*:8080/")
$listener.Start()
Write-Host "Servidor escuchando en http://localhost:8080/ ..."
while ($listener.IsListening) {
    $context = $listener.GetContext()
    $response = $context.Response
    $html = [System.IO.File]::ReadAllBytes("$pwd/index.html")
    $response.ContentType = "text/html; charset=utf-8"
    $response.ContentLength64 = $html.Length
    $response.OutputStream.Write($html, 0, $html.Length)
    $response.Close()
}
```

---

## 4. Despliegue en la Nube (Producción 24/7 Gratis)

### Opción 1: GitHub Pages (Recomendado)
Tu proyecto se aloja en el repositorio:  
🔗 **`https://github.com/hebreoel3en1/ImpulsaIA.git`**

1. Sube tu código al repositorio (ver sección 5).
2. En GitHub, ve a la pestaña **Settings** (Configuración) de tu repositorio.
3. En el menú izquierdo, selecciona **Pages**.
4. En **Build and deployment** > **Branch**, selecciona la rama `main` (o `master`) y la carpeta `/ (root)`.
5. Haz clic en **Save** (Guardar).
6. En 1-2 minutos tu tienda estará publicada en:  
   `https://hebreoel3en1.github.io/ImpulsaIA/`

### Opción 2: Vercel
1. Ingresa a [vercel.com](https://vercel.com) e inicia sesión con GitHub.
2. Selecciona **"Add New Project"** e importa el repositorio `hebreoel3en1/ImpulsaIA`.
3. Deja la configuración predeterminada (Framework: *Other*) y haz clic en **Deploy**.
4. Vercel te entregará una URL global con certificado SSL (HTTPS).

### Opción 3: Netlify
1. Ingresa a [netlify.com](https://netlify.com).
2. Arrastra la carpeta de tu proyecto directamente a la sección **"Deploy manually by dragging and dropping"**.
3. En 5 segundos tendrás un enlace público operativo.

---

## 5. Procedimiento Git para Subir los Cambios al Repositorio

Para subir el código actualizado, los manuales y el ejecutable portable a tu repositorio de GitHub:

### Si tienes Git instalado en tu computador:
Abre PowerShell o Git Bash en la carpeta del proyecto y ejecuta:

```bash
# 1. Inicializar repositorio (si aún no está iniciado)
git init

# 2. Configurar la dirección de tu repositorio remoto
git remote add origin https://github.com/hebreoel3en1/ImpulsaIA.git
# (O si ya existía origin: git remote set-url origin https://github.com/hebreoel3en1/ImpulsaIA.git)

# 3. Agregar todos los archivos modificados y nuevos
git add index.html
git add Manual_Tecnico.md
git add Manual_Usuario.md
git add Despliegue.md
git add README.md
git add ImpulsaStore.exe
git add Iniciar_Tienda.bat
git add ImpulsaStore_Windows_Portable.zip

# 4. Crear el commit descriptivo
git commit -m "feat: ampliación catálogo 90 productos premium, modal con marcas y tallas, WCAG 2.2 AA, versión portable y manuales"

# 5. Asegurar rama principal y subir
git branch -M main
git push -u origin main
```

### Si no tienes Git instalado:
Puedes instalarlo rápidamente abriendo PowerShell y ejecutando:
```powershell
winget install --id Git.Git -e --source winget
```
O simplemente entra a tu repositorio en el navegador ([github.com/hebreoel3en1/ImpulsaIA](https://github.com/hebreoel3en1/ImpulsaIA)) y utiliza el botón **"Add file" > "Upload files"** para arrastrar `index.html`, los 3 manuales `.md`, `README.md` y `ImpulsaStore_Windows_Portable.zip`.
