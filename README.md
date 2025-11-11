# 🚀 orbital2

**orbital2** es un juego top-down desarrollado en Unity, enfocado en arquitectura escalable, modularidad y patrones de diseño avanzados. El objetivo es construir sistemas robustos, editor-friendly y fácilmente mantenibles para prototipos y producción.

---

## 🎯 Objetivos del proyecto

- Aplicar patrones de diseño como **Factory**, **Builder**, **Prototype** y **Observer** para sistemas de enemigos, balas y vida.
- Optimizar jerarquía de escenas y prefabs para claridad y extensibilidad.
- Documentar decisiones técnicas para revisión académica y presentación profesional.
- (En desarrollo) Integrar backend con **Node.js** y **MongoDB** usando `UnityWebRequest`.

---

## 🧠 Patrones de diseño implementados

### 🏭 Factory
- **Uso**: Instanciación dinámica de enemigos y balas desde prefabs configurables.
- **Ventaja**: Permite agregar nuevos tipos sin modificar el código base.
- **Ejemplo**: `BulletFactory.Create(BulletType.Fireball)`

### 🧱 Builder
- **Uso**: Configuración paso a paso de enemigos con stats, AI y visuales.
- **Ventaja**: Separación clara entre construcción y representación.
- **Ejemplo**: `EnemyBuilder.WithHealth(100).WithAI(Aggressive).Build()`

### 🧬 Prototype
- **Uso**: Clonado de balas desde ScriptableObjects.
- **Ventaja**: Evita duplicación de lógica, útil para variantes con tweaks.
- **Ejemplo**: `bulletPrototype.Clone()`

### 🧪 Observer
- **Uso**: Notificación de cambios de vida del jugador a UI, sonido y lógica externa.
- **Ventaja**: Desacopla la lógica de vida de los sistemas que reaccionan.
- **Ejemplo**: `OnHealthChanged?.Invoke(currentHealth)`

---

## 📁 Estructura del proyecto

- `Assets/`: Scripts, prefabs, escenas y recursos del juego.
- `ProjectSettings/`: Configuración del proyecto Unity.
- `Packages/`: Dependencias y configuración de paquetes.
- `.gitignore`: Evita subir carpetas como `Library/`, `Logs/`, `UserSettings/`.
- `README.md`: Documentación del proyecto.
- `orbitaltopdown.sln`: Solución para Visual Studio.

---

## 🌐 Integración con backend (en desarrollo)

- **Tecnologías**: Node.js + MongoDB
- **Método**: `UnityWebRequest` para enviar/recibir datos del jugador.
- **Estado**: En pruebas de conexión y parsing JSON.

---

## 🛠️ Configuración del entorno

1. Unity 2022.3+ con URP.
2. Clonar el repositorio:
   ```bash
   git clone https://github.com/EnzoJDeMarchi/programacion.git