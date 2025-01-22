# Unity Movimientos

### 1. PlayerController.cs
Este script gestiona el movimiento del jugador, las interacciones con objetos del juego y el cambio de cámaras.

#### Componentes Clave:
- **Variables Públicas**:
  - `speed`: Controla la velocidad de movimiento del jugador.
  - `countText`: Elemento de interfaz que muestra la puntuación del jugador.
  - `winTextObject`: Elemento de interfaz que se activa cuando el jugador gana.
  - `Bloqueo`: Un GameObject que no permite acceder al nivel 2 hasta que no alcancemos la puntuacion necesaria.
  - `mainCamera` y `thirdPersonCamera`: Cámaras para diferentes perspectivas.
  
#### Métodos Clave:
- `Start()`: Inicializa variables, establece la cámara inicial y oculta el texto de victoria.
- `FixedUpdate()`: Aplica fuerzas para mover al jugador según la orientación de la cámara activa.
- `Update()`: Gestiona el cambio de cámara (tecla `C`) y nos permite dar un salto (tecla `R`).
- `OnMove(InputValue)`: Actualiza los valores de entrada para el movimiento.
- `OnTriggerEnter(Collider)`: Gestiona las interacciones con objetos del juego:
  - `PickUp`: Incrementa la puntuación y desactiva el objeto.
  - `Void`: Respawnea al jugador.
  - `duck`: Mueve al jugador a una posición elevada.
- `SmoothMove(Vector3, Vector3, float)`: Corrutina que interpola la posición del jugador hacia una posicion.
- `SetCountText()`: Actualiza y muestra la puntuación actual, activando el texto de victoria si se alcanza una puntuación especificada.

---

### 2. CameraController1st.cs
Controla una cámara en primera persona que sigue al jugador y tambien puede rotar.

#### Componentes Clave:
- **Variables Públicas**:
  - `player`: El GameObject del jugador al que sigue la cámara.
  - `moveSpeed`: Velocidad de rotación de la cámara.

#### Métodos Clave:
- `Start()`: Inicializa el desplazamiento entre la cámara y el jugador.
- `LateUpdate()`: Actualiza la posición de la cámara y permite la rotación usando las teclas del teclado numérico (`4` y `6`).

---

### 3. CameraController.cs
Un controlador de cámara en tercera persona que mantiene una distancia fija respecto al jugador.

#### Componentes Clave:
- **Variables Públicas**:
  - `player`: El GameObject del jugador al que sigue la cámara.

#### Métodos Clave:
- `Start()`: Calcula el desplazamiento inicial entre la cámara y el jugador.
- `LateUpdate()`: Actualiza la posición de la cámara para mantenerse a la misma distancia del jugador.

---

## Controles
- **Movimiento**: Controlado por los mapeos de entrada en `PlayerController.cs`.
- **Cambio de Cámara**: Presiona `C` para alternar entre la cámara principal y la de tercera persona.
- **Reiniciar Posición**: Presiona `R` para hacer subir al jugador.
- **Rotación de Cámara en Primera Persona**: Usa `Keypad4` y `Keypad6` para rotar a la izquierda y derecha.

