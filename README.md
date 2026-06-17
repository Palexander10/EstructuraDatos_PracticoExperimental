🏥 Agenda de Turnos Clínicos - Estructura de Datos

Práctica Experimental N.° 01: Identificación de tipos de datos  
Institución: Universidad Estatal Amazónica (UEA)  
Asignatura: Estructura de Datos  
Este repositorio contiene una aplicación de consola desarrollada en C# que simula el sistema de agendamiento de una clínica. El proyecto fue diseñado para aplicar y demostrar el dominio práctico de la Programación Orientada a Objetos (POO) y el uso eficiente de estructuras de datos estáticas (registros y matrices).

Características del Sistema
El sistema cumple con los siguientes requerimientos operativos:
Registro de Turnos: Permite asignar a un paciente un día de la semana y una franja horaria específica, validando que el espacio no esté previamente ocupado para evitar colisiones.
Reportería Visual (Agenda): Despliega en consola un "mapa" completo de la semana laboral (matriz bidimensional), indicando gráficamente qué horarios están libres y cuáles están ocupados.
Búsqueda y Filtrado: Permite buscar el turno de un paciente utilizando su número de cédula, devolviendo el día, la hora y la especialidad requerida.

🛠️ Estructuras de Datos Utilizadas
Para resolver la problemática planteada, se implementaron las siguientes estructuras:Registros (struct): Se implementó la estructura Paciente para agrupar atributos de distintos tipos de datos primitivos (Cédula, Nombre, Especialidad) bajo una sola entidad lógica. Esto optimiza el uso de la memoria (Stack) al manipular valores directamente.
Matrices Bidimensionales ([,]): Se utilizó un arreglo bidimensional de objetos Turno[5, 8] para representar la semana laboral (5 días, 8 horas diarias). Esto permite un acceso directo y de tiempo constante a cualquier franja horaria.

💻 Tecnologías y Herramientas
Lenguaje: C# (.NET)
Paradigma: Programación Orientada a Objetos (POO)
Entorno de Desarrollo: Visual Studio Code / Terminal de Windows
Control de Versiones: Git & GitHub

⚙️ Instrucciones de Ejecución
Para ejecutar este proyecto de forma local, asegúrate de tener instalado el SDK de .NET.

1. Clona este repositorio en tu máquina local:Bashgit clone https://github.com/tu-usuario/AgendaTurnosClinica.git

2. Navega hasta el directorio del proyecto:
   ```bash
   cd AgendaTurnosClinica
3. Compila y ejecuta la aplicación:dotnet run
---

## 🤖 Uso de Inteligencia Artificial

Como parte de las directrices de la práctica[cite: 1], se utilizó el agente de Inteligencia Artificial **Gemini** como asistente de desarrollo. 
* **Porcentaje de código generado/asistido:** ~20%
* **Descripción del uso:** El agente fue utilizado para la validación de la sintaxis en la declaración de matrices en C#, estructuración del menú interactivo por consola y revisión de la lógica para el algoritmo de búsqueda iterativa.

---

## 👨‍💻 Autor

* **Pablo Alexander Ramón Mosquera**
* Estudiante de la carrera de Tecnologías de la Información.