🧩 Kata TDD – Conversor de Números Romanos
📖 Descripción

Esta kata tiene como objetivo practicar Desarrollo Guiado por Pruebas (TDD) implementando un conversor de números romanos en el lenguaje de tu elección.
El reto consiste en crear una función que convierta números enteros (arábigos) en su representación romana y viceversa (opcional).

🎯 Objetivos de la Kata

Practicar el ciclo Red → Green → Refactor del TDD.

Diseñar pruebas unitarias efectivas.

Mantener un código limpio, legible y extensible.

Familiarizarse con la lógica de conversión de números romanos.

🧪 Reglas de Conversión
|Decimal	|Romano
|1	|I
|4	|IV
|5	|V
|9	|IX
|10	|X
|40	|XL
|50	|L
|90	|XC
|100	|C
|400	|CD
|500	|D
|900	|CM
|1000	|M

Los números romanos se escriben combinando estos símbolos, de mayor a menor valor, sin repetir un símbolo más de tres veces seguidas.

Ejemplos:

3 → III

8 → VIII

14 → XIV

44 → XLIV

944 → CMXLIV

🧰 Requerimientos

Lenguaje: (elige uno: C#, Java, Python, JavaScript, etc.)

Framework de pruebas: (por ejemplo, xUnit, JUnit, pytest, Jest, etc.)

🚦 Pasos sugeridos (TDD)

✳️ Escribir una prueba que falle (por ejemplo, convertir 1 → I).

✅ Escribir el código mínimo para que pase la prueba.

🔁 Refactorizar el código sin romper las pruebas.

➕ Agregar una nueva prueba (por ejemplo, 4 → IV) y repetir el ciclo.

Repite este proceso hasta cubrir todos los casos relevantes.

Ejemplo de uso (si ya está implementado)

> roman 44
XLIV

> roman --from XLIV
44
