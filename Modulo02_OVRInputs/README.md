# Módulo II · OVRInputs

**Entrada de los mandos Meta Quest Touch con `OVRInput`**

En este módulo aprendemos a leer la entrada de los mandos de Meta Quest (botones, gatillos, joysticks y toques) mediante la API **`OVRInput`** del Meta XR Core SDK, y a usarla para controlar la experiencia.

---

## 🎯 Objetivos

- Conocer la estructura del `OVRCameraRig` y sus anclajes (cabeza y manos).
- Leer botones, gatillos y joysticks con `OVRInput.Get`, `GetDown` y `GetUp`.
- Distinguir entre botones virtuales (`Button`, `Axis1D`, `Axis2D`) y físicos (`RawButton`…).
- Detectar los toques capacitivos (`Touch`, `NearTouch`).
- Obtener la posición y rotación de los mandos.
- Activar la **vibración háptica** con `OVRInput.SetControllerVibration`.
- Implementar una **locomoción** básica con el joystick.

---

## 📖 Contenidos

| Apartado | Contenido |
|---|---|
| **OVRCameraRig** | Tracking space, anclajes, Tracking Origin Type |
| **Mapeo de los mandos** | Botones A/B/X/Y, gatillo índice, gatillo de agarre, joystick, botón Menú |
| **API OVRInput** | Lectura de estados, ejes y toques; mando izquierdo y derecho |
| **Háptica** | Vibración de los mandos con frecuencia, amplitud y duración |
| **Tarea Módulo 2** | Práctica evaluable del módulo |

---

## 📁 Contenido de la carpeta

```
Modulo02_OVRInputs/
├── ProyectosUnity/
│   ├── Example1/                ← ejemplos de clase
│   └── M02_Tarea/               ← tarea evaluable
└── Recursos/
    ├── Scripts/                 ← scripts de lectura de entrada, movimiento, vibración…
    └── Assets/
```

> 📝 *Pendiente de completar con los materiales de la unidad.*
