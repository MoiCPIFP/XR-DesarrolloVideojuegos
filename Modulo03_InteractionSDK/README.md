# Módulo III · Interaction SDK

**Interacciones con los controladores y manos — Proyecto: Beat Saber**

En este módulo aprendemos a usar **Meta XR Interaction SDK** para crear interacciones con mandos y con seguimiento de manos (*hand tracking*): agarrar objetos, agarrarlos a distancia, apuntar con rayos y pulsar botones. Terminamos aplicándolo todo en un juego de ritmo inspirado en **Beat Saber**.

---

## 🎯 Objetivos

- Configurar un proyecto de Unity para VR (Unity 6 y OpenXR).
- Conocer Interaction SDK y configurar las manos y los mandos con su rig.
- Personalizar el modelo de las manos.
- Crear interacciones de agarre: **HandGrab** y **Distance Grab**.
- Crear retículas fantasma: **Ghost Reticles**, ReticleMesh, ReticleLine y OVRRightHandReticle.
- Crear interacciones con **Ray Interactors** y **HandPokeInteractor**.
- Crear una escena de transición.
- Usar **Grab Pose** y **Snap Interactions**.
- Conocer otras funciones de hand tracking: poses, microgestos, multimodal y Fast Motion Mode.
- Crear un inventario compatible con manos y mandos.
- Desarrollar el juego **Beat Saber** y usar el asset **Ezy-Slice**.

---

## 🛠️ Requisitos

| Elemento | Detalle |
|---|---|
| Unity | **6000.0.66f2 o superior** (Meta recomienda 6.1 o posterior) con Android Build Support |
| Plataforma | *File → Build Profiles* → **Android (Meta Quest)**, compresión de texturas **ASTC** |
| Plugin XR | **OpenXR** (en Windows/Mac/Linux y en Android) |
| SDK | **Meta XR Interaction SDK** o **Meta XR All-in-One SDK** (incluye Meta XR Core SDK) |
| Gafas | Meta Quest 2, Quest 3, Quest 3S o Quest Pro, con el seguimiento de manos activado |

> ⚠️ Los tutoriales antiguos marcan el plugin **Oculus**. Ahora se usa **OpenXR**.
> ⚠️ Desde la v78 del SDK, el esqueleto de mano OVR está obsoleto y se usa el de **OpenXR**. Los IDs de articulación de capturas o scripts antiguos pueden no coincidir.

---

## 📖 Fases del módulo

| Fase | Contenido |
|---|---|
| **1. Preparación del proyecto** | XR Plug-in Management, OpenXR, instalación del SDK, Project Setup Tool (*Fix All* / *Apply All*) |
| **2. Introducción a Interaction SDK** | Ejemplos del SDK, rig con *Add OVR Comprehensive Interaction Rig*, prueba por Link, personalización y *retargeting* de manos (Blender), HandGrab, Distance Grab, retículas, Ray y Poke (con HandPokeLimiter) |
| **3. Configuración del entorno** | Skybox, escena de introducción con botón y escena de transición con OVR Overlay |
| **4. Grab Pose y Snap Interactions** | Hand Grab Pose Recorder, ubicaciones *snap* |
| **5. QuickActions y Building Blocks** | Asistentes de clic derecho, locomoción por teletransporte (TeleportHotspot), Building Blocks, otras funciones de hand tracking y práctica de **microgestos** |
| **6. Inventario** | Inventario anclado a la mano izquierda con *slots*, válido para manos y mandos |
| **7–8. Beat Saber + Ezy-Slice** | Sables y corte de mallas con un plano sobre objetos en la capa `Sliceable` |
| **9. Háptica** | Vibración con `OVRInput.SetControllerVibration` y ampliación con Meta Haptics SDK |
| **10–15. Lógica del juego** | Cubos con dirección y color, reacciones, interfaz, movimiento y muerte de los cubos, generador aleatorio de cubos |

---

## 📁 Contenido de la carpeta

```
Modulo03_InteractionSDK/
├── ProyectosUnity/
│   ├── M03_P01_InteractionSDK/   ← Fases 1–6: rig, agarres, rayos, poke, inventario
│   └── M03_P02_BeatSaber/        ← Fases 7–15: juego completo
└── Recursos/
    ├── Scripts/
    │   ├── VibratorManager.cs    ← vibración de los mandos con duración (singleton)
    │   ├── Cube.cs               ← color, ángulo de corte y movimiento del cubo
    │   └── CubeSpawner.cs        ← generador aleatorio de cubos
    └── Assets/
        ├── Paquetes .unitypackage (prefabs de cubos, sables, inventario…)
        └── Modelos de manos personalizados (FBX)
```

> Los nombres de los proyectos y scripts son orientativos: ajústalos a los que uses en clase.

---

## 📦 Assets externos

| Asset | Uso | Origen |
|---|---|---|
| **Ezy-Slice** | Cortar mallas con un plano (sables) | [github.com/DavidArayan/ezy-slice](https://github.com/DavidArayan/ezy-slice) · licencia MIT |
| **Skybox Volume 2** | Fondo de la escena | Unity Asset Store |
| **RoomEnvironment** | Entorno de pruebas | Ejemplos del Interaction SDK |

Los assets de la Asset Store **no se suben** al repositorio: cada alumno/a debe descargarlos desde su cuenta.

---

## 🔗 Referencias

- [Interaction SDK: Overview](https://developers.meta.com/horizon/documentation/unity/unity-isdk-interaction-sdk-overview/)
- Ejemplos de Meta en GitHub: **Unity-FirstHand** y **Unity-MoveFast**
- Meta VR Academy: *Is My Game a Good Fit for Hands?*
