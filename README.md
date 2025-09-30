# orbital2

**orbital2** es un juego top-down desarrollado en Unity, enfocado en arquitectura escalable, modularidad y patrones de diseño avanzados. El objetivo es construir sistemas robustos, editor-friendly y fácilmente mantenibles para prototipos y producción.

---

## 🎯 Objetivos del proyecto

- Aplicar patrones de diseño como **Factory**, **Builder** y **Prototype** para sistemas de enemigos.
- Integrar backend con **Node.js** y **MongoDB** usando `UnityWebRequest`.
- Optimizar jerarquía de escenas y prefabs para claridad y extensibilidad.
- Documentar decisiones técnicas para revisión y presentación.

---

## 🧠 Patrones de diseño implementados

### 🏭 Factory Pattern
- **Uso**: Instanciación dinámica de enemigos desde prefabs configurables.
- **Ventaja**: Permite agregar nuevos tipos sin modificar el código base.
- **Ejemplo**: `EnemyFactory.Create(EnemyType.Bomber)`

### 🧱 Builder Pattern
- **Uso**: Configuración paso a paso de enemigos con stats, AI y visuales.
- **Ventaja**: Separación clara entre construcción y representación.
- **Ejemplo**: `EnemyBuilder.WithHealth(100).WithAI(Aggressive).Build()`

### 🧬 Prototype Pattern
- **Uso**: Clonado de enemigos base para variaciones rápidas.
- **Ventaja**: Evita duplicación de lógica, útil para variantes con tweaks.
- **Ejemplo**: `EnemyPrototype.CloneWithSpeed(1.5f)`

---

## 🧩 Estructura del proyecto


---

## 🌐 Integración con backend

- **Tecnologías**: Node.js + MongoDB
- **Método**: `UnityWebRequest` para enviar/recibir datos del jugador.
- **Estado**: En desarrollo, con pruebas de conexión y parsing JSON.

---

## 🛠️ Configuración del entorno

1. Unity 2022.3+ con URP.
2. Clonar el repositorio:
   ```bash
   git clone https://github.com/EnzoJDeMarchi/orbital2.git