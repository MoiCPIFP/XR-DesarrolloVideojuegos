# 🥽 Desarrollo de Realidad Virtual y Aumentada

Repositorio del módulo **Desarrollo de Realidad Virtual y Aumentada** del **Curso de Especialización en Desarrollo de Videojuegos y Realidad Virtual**.

Aquí se recogen los proyectos de Unity, scripts y recursos desarrollados durante el curso para **Meta Quest** con el **Meta XR SDK**.

---

## 📋 Requisitos

| Elemento | Versión / detalle |
|---|---|
| **Unity** | `6000.x LTS` *(indicar versión exacta usada en el curso)* |
| **Módulos de Unity** | Android Build Support (+ OpenJDK y Android SDK & NDK Tools) |
| **Meta XR SDK** | Meta XR All-in-One SDK `vXX` *(indicar versión)* |
| **Dispositivo** | Meta Quest (modo desarrollador activado) |
| **Software adicional** | Meta Quest Link / Meta Horizon Link, Meta Quest Developer Hub |
| **Control de versiones** | Git + Git LFS |

> ⚠️ Todos los proyectos usan **la misma versión de Unity y del SDK**. Abrir un proyecto con otra versión puede provocar errores o actualizaciones no deseadas.

---

## 📁 Estructura del repositorio

```
XR-DesarrolloVideojuegos/
├── README.md
├── .gitignore
├── .gitattributes
│
├── 00_Introduccion/
│   ├── ProyectosUnity/
│   └── Recursos/
│       ├── Scripts/
│       └── Assets/
│
├── Modulo01_ConfiguracionEntorno/
│   ├── ProyectosUnity/
│   └── Recursos/
│       ├── Scripts/
│       └── Assets/
│
├── Modulo02_OVRInputs/
├── Modulo03_InteractionSDK/
├── Modulo04_RealidadMixta/
└── Modulo05_MultiusuarioOptimizacion/
```

Cada módulo contiene:

- **`ProyectosUnity/`** → un proyecto de Unity por práctica o ejemplo del capítulo.
- **`Recursos/Scripts/`** → scripts C# reutilizables creados durante el módulo.
- **`Recursos/Assets/`** → modelos, materiales, prefabs y paquetes `.unitypackage` para reutilizar en otros proyectos.
- **`README.md`** → descripción del módulo, objetivos y lista de prácticas.

---

## 📚 Contenidos

| Carpeta | Módulo | Contenidos principales |
|---|---|---|
| `00_Introduccion` | **Introducción** | Presentación del módulo, introducción a la XR (VR, AR, MR), inventario de dispositivos Meta Quest |
| `Modulo01_ConfiguracionEntorno` | **I. Configuración del entorno** | Instalación de Unity y módulos Android, modo desarrollador en Quest, instalación del Meta XR SDK, Project Setup Tool, primera build |
| `Modulo02_OVRInputs` | **II. OVRInputs** | Cámara `OVRCameraRig`, lectura de botones, gatillos y joysticks con `OVRInput`, vibración háptica, locomoción básica |
| `Modulo03_InteractionSDK` | **III. Interaction SDK** | Interacciones de agarre (*grab*), pulsación (*poke*), rayos (*ray*), seguimiento de manos y UI en VR |
| `Modulo04_RealidadMixta` | **IV. Realidad Mixta** | Passthrough, comprensión de escena (MR Utility Kit), anclajes espaciales, interacción con el entorno real |
| `Modulo05_MultiusuarioOptimizacion` | **V. Multiusuario y optimización** | Experiencias compartidas en red, anclajes compartidos, rendimiento en Quest, profiling y buenas prácticas de optimización |

---

## 🚀 Cómo usar este repositorio

### 1. Clonar

```bash
git lfs install
git clone https://github.com/TU_USUARIO/XR-DesarrolloVideojuegos.git
```

### 2. Abrir un proyecto

1. Abre **Unity Hub** → **Add** → **Add project from disk**.
2. Selecciona la carpeta del proyecto, por ejemplo `Modulo02_OVRInputs/ProyectosUnity/NombreProyecto`.
3. La primera apertura tarda unos minutos: Unity regenera la carpeta `Library`.
4. En **File → Build Settings** comprueba que la plataforma es **Android**.

### 3. Probar en las gafas

- **Con Quest Link:** conecta las gafas al PC y pulsa *Play* en Unity.
- **Build en el dispositivo:** conecta las gafas por USB → **File → Build And Run**.

### 4. Reutilizar recursos

Importa los paquetes de `Recursos/Assets` desde Unity con **Assets → Import Package → Custom Package**.

---

## 📝 Convenciones

- **Nombres de carpetas y proyectos:** sin espacios ni tildes (`M02_P01_ControlesBasicos`).
- **Proyectos:** `MXX_PYY_Descripcion` → `M03_P02_AgarreObjetos`.
- **Scripts:** PascalCase y en un namespace por módulo (`namespace XRCurso.Modulo03`).
- **Builds:** se generan en la carpeta `Builds/` del proyecto, que **no se sube** al repositorio.
- **Commits:** mensajes descriptivos en español (`M02: añadir vibración háptica al gatillo`).

---

## 🏷️ Versiones por capítulo

Al finalizar cada módulo se crea una etiqueta con el estado final del código:

```bash
git tag                 # ver etiquetas disponibles
git checkout M02-fin    # ir al estado final del Módulo II
git checkout main       # volver a la versión actual
```

---

## 🔗 Documentación de referencia

- [Meta XR SDK para Unity – Documentación oficial](https://developers.meta.com/horizon/documentation/unity/)
- [Interaction SDK](https://developers.meta.com/horizon/documentation/unity/unity-isdk-interaction-sdk-overview/)
- [Manual de Unity](https://docs.unity3d.com/Manual/index.html)

---

## 👤 Autoría

**Profesor:** *Moisés Martínez Gutiérrez*
**Centro:** *CPIFP Alan Turing*
**Curso académico:** 2026/2027

> Material docente para uso educativo dentro del Curso de Especialización en Desarrollo de Videojuegos y Realidad Virtual.
