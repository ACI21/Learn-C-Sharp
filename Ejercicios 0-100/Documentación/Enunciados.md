# Enunciados de Ejercicios en C#

## Ejercicios Básicos

### Ejercicio 1: Conteo de patas de invertebrados
Un biólogo está realizando un estudio de distintas especies de invertebrados y necesita una aplicación que le ayude a contabilizar el número de patas que tienen en total todos los animales capturados durante una jornada de trabajo.
Para ello, nos ha solicitado que escribamos una aplicación a la que hay que proporcionar:
- El número de hormigas capturadas (6 patas)
- El número de arañas capturadas (8 patas)
- El número de cochinillas capturadas (14 patas)
La aplicación debe mostrar el número total de patas que poseen todos los animales.

### Ejercicio 3: Gestión de alimentación en una granja
Un granjero necesita calcular si tiene suficiente comida para todos los animales de su granja.
El programa debe:
1. Solicitar al usuario la cantidad total de comida comprada (en kg)
2. Solicitar el número de animales en la granja
3. Calcular los kg de comida por animal
4. Indicar si hay suficiente comida para todos o cuántos kg debe consumir cada animal diariamente

## Ejercicios de Arrays

### Ejercicio: Arrays Dentados
Crear un programa que trabaje con arrays dentados (jagged arrays) de múltiples dimensiones.
El programa debe:
1. Crear un array de 2 tablas dentadas de enteros (array de 3 dimensiones)
2. Solicitar al usuario las dimensiones de cada tabla (número de filas)
3. Para cada fila, pedir el número de elementos que contendrá
4. Rellenar cada posición con números aleatorios entre 1 y 99
5. Mostrar el contenido completo de las tablas en formato legible

### Ejercicio: Sistema de Gestión de un Multicine
Desarrollar un programa para gestionar la venta de entradas y estadísticas de aforo en un multicine.
El sistema debe:
1. Gestionar 3 salas (A, B y C) con diferentes aforos (200, 150 y 125 respectivamente)
2. Permitir 3 sesiones diarias para cada sala
3. Implementar las siguientes funcionalidades:
   - Venta de entradas: permitir la compra de entradas verificando que no se supere el aforo máximo
   - Estadísticas: mostrar una tabla con la ocupación actual de cada sala y sesión
4. Utilizar un array bidimensional para almacenar las ventas (filas=salas, columnas=sesiones)

## Ejercicios Genéricos

### Ejercicio 1: Implementación de una clase genérica para fracciones
Crear una clase genérica llamada Fraccion<T> que permita representar fracciones matemáticas.
La clase debe:
1. Permitir almacenar el numerador y denominador como valores de tipo genérico T
2. Proporcionar propiedades para acceder al numerador y denominador
3. Demostrar el uso de la clase con diferentes tipos numéricos (int, long)

### Ejercicio 2: Implementación de una clase con múltiples tipos genéricos
Crear una clase genérica A<TKey, TValue> que implemente un par clave-valor con tipos genéricos.
La clase debe:
1. Permitir definir dos tipos genéricos diferentes: uno para la clave y otro para el valor
2. Proporcionar propiedades para acceder a la clave y al valor
3. Demostrar el uso de la clase combinando diferentes tipos (ej: int, string)

## Ejercicios de Colecciones BCL

### Ejercicio 1: Operaciones Básicas con Listas en C#
Implementar diferentes operaciones con la clase List<T> de la BCL para manipular colecciones.
El programa debe incluir las siguientes funciones:
1. BorraEnteros: eliminar todas las ocurrencias de un número específico de una lista de enteros
2. Mezcla: combinar dos listas ordenadas de enteros en una sola lista ordenada (merge)
3. ImprimeInverso: mostrar los elementos de una lista de strings en orden inverso desde una posición dada
4. OrdenaCadenas: ordenar alfabéticamente una lista de cadenas
5. Demostrar el uso de todas estas funciones con ejemplos concretos

## Ejercicios de Colecciones Enlazadas

### Ejercicio 2: Tabla ASCII con LinkedList
Crear un programa que genere y muestre una tabla de caracteres ASCII utilizando una lista enlazada.
El programa debe:
1. Implementar una clase CaracterASCII que encapsule un carácter y sus representaciones (decimal, octal y hexadecimal)
2. Crear una LinkedList<CaracterASCII> y llenarla con 240 caracteres aleatorios únicos
3. Insertar los elementos en orden ascendente según su valor numérico
4. Mostrar la lista formateada en columnas con información sobre cada carácter:
   - Valor decimal (DEC)
   - Valor octal (OCT)
   - Valor hexadecimal (HEX)
   - El propio carácter (CAR)
5. Ajustar las dimensiones de la consola para mostrar adecuadamente la tabla

## Ejercicios de Input/Output (IO)

### Ejercicio IO 1: Creación y Lectura de Archivos con FileStream
Crear un programa que demuestre el uso básico de la clase FileStream para operaciones de E/S.
El programa debe:
1. Solicitar al usuario la ruta completa donde crear un archivo
2. Verificar si el directorio existe, y crearlo si no existe
3. Pedir al usuario el contenido que desea escribir en el archivo
4. Crear el archivo y escribir los datos utilizando FileStream
5. Abrir el archivo para lectura y mostrar su contenido byte a byte
6. Implementar manejo de excepciones para gestionar posibles errores

### Ejercicio IO 2: Implementación de un Comando 'cp' para Copiar Archivos
Crear un programa que simule el funcionamiento del comando 'cp' de sistemas Unix.
El programa debe:
1. Recibir dos argumentos por línea de comandos: ruta del archivo origen y ruta del archivo destino
2. Verificar que el archivo de origen exista
3. Verificar que el archivo de destino no exista (para evitar sobrescrituras accidentales)
4. Copiar el contenido del archivo origen al destino utilizando FileStream
5. Implementar la copia mediante un buffer para optimizar el rendimiento
6. Mostrar mensajes apropiados en caso de éxito o error

## Ejercicios de Ficheros

### Ejercicio Fichero 1: Manejo de rutas de archivos con la clase Path
Crear un programa que demuestre el uso de los principales métodos de la clase Path para manipular rutas de archivos.
El programa debe:
1. Ofrecer al usuario la opción de trabajar con rutas absolutas o relativas
2. Mostrar el resultado de aplicar diferentes métodos de la clase Path:
   - GetExtension: obtener la extensión del archivo
   - GetFileName: obtener el nombre del archivo con extensión
   - GetFileNameWithoutExtension: obtener el nombre sin extensión
   - GetDirectoryName: obtener el nombre del directorio
   - GetPathRoot: obtener la raíz de la ruta
   - ChangeExtension: cambiar la extensión del archivo
   - GetFullPath: obtener la ruta completa a partir de una relativa
   - Combine: combinar dos rutas en una sola

### Ejercicio Fichero 2: Gestión de Directorios y Ficheros
Crear un programa para administrar el sistema de archivos mediante operaciones básicas.
El programa debe implementar un menú con las siguientes funcionalidades:
1. Crear Árbol de Directorios: establecer una estructura de carpetas y archivos predefinida
2. Eliminar Directorio: solicitar la ruta y eliminar un directorio (incluyendo su contenido)
3. Eliminar Fichero: solicitar la ruta y eliminar un archivo específico
4. Mostrar Información de Directorio: listar el contenido (archivos y carpetas) de un directorio
5. Mostrar Atributos de Fichero: mostrar los atributos de un archivo específico
El programa debe manejar posibles excepciones y mostrar mensajes informativos

## Ejercicios de Polimorfismo

### Ejercicio 1: Polimorfismo con Sobrecarga de Métodos
Implementar un sistema para calcular el coste de carreras de taxi usando sobrecarga de métodos.
El sistema debe:
1. Utilizar una clase estática Taxi con el método CosteCarrera sobrecargado
2. Permitir calcular el coste básico (kilómetros y tiempo de espera)
3. Permitir aplicar recargos por:
   - Servicio nocturno (incremento porcentual)
   - Día festivo (porcentaje variable según el festivo)
   - Ocupación extra (mascotas u otros elementos que ocupen espacio)
4. Realizar los cálculos respetando una tarifa mínima y teniendo en cuenta la bajada de bandera
5. Demostrar la funcionalidad con diferentes escenarios de uso

## Ejercicios de Excepciones

### Ejercicio Logaritmo 1: Manejo Básico de Excepciones
Crear un programa que calcule el logaritmo en base 10 de un número proporcionado como argumento.
El programa debe:
1. Verificar si se ha proporcionado al menos un argumento en la línea de comandos
2. Comprobar que el argumento sea un número válido utilizando TryParse
3. Validar que el número sea positivo (requisito para calcular logaritmos)
4. Capturar y manejar posibles excepciones:
   - ArgumentException: cuando el número es negativo o cero
   - Otras excepciones que puedan surgir durante el proceso
5. Mostrar mensajes de error adecuados cuando se produzcan excepciones

### Ejercicio Banco: Sistema Bancario con Manejo de Excepciones Personalizadas
Crear un sistema bancario simple que utilice excepciones personalizadas para validar operaciones.
El sistema debe:
1. Implementar la clase NumeroCuenta para validar números de cuenta bancaria
2. Implementar la clase Cuenta que permita operaciones de ingreso y reintegro (retiro)
3. Crear excepciones personalizadas:
   - NumeroCuentaIncorrectoException: cuando el formato del número de cuenta es inválido
   - SaldoInsuficienteException: cuando se intenta retirar más dinero del disponible
4. Demostrar el manejo de excepciones mediante bloques try-catch
5. Mostrar mensajes de error apropiados cuando se capturen las excepciones

## Ejercicios de Objetos

### Ejercicio: Creación y Manipulación de Objetos en C#
Implementar un sistema básico de personajes para demostrar los conceptos de POO.
El ejercicio debe:
1. Crear una clase Personaje con atributos (nombre, edad, raza) y métodos (saludar, atacar)
2. Implementar diferentes tipos de encapsulamiento:
   - Atributos privados con getters/setters personalizados (nombre)
   - Propiedades autoimplementadas (Edad, Raza)
3. Implementar validación en los setters (nombre no puede ser nulo ni "Swiper")
4. Sobrescribir el método Equals para comparar personajes por raza y edad
5. Demostrar la creación y manipulación de objetos en la clase Principal

## Ejercicios Especiales

### Ejercicio: Juego del Ahorcado
Implementar el clásico juego del ahorcado en consola.
El programa debe:
1. Seleccionar aleatoriamente una palabra de un conjunto predefinido
2. Establecer un número aleatorio de vidas (entre 1 y 25)
3. Mostrar la palabra oculta representada por guiones
4. Permitir al jugador adivinar letras de una en una
5. Actualizar la visualización de la palabra a medida que se adivinan letras
6. Reducir las vidas cuando se introduce una letra incorrecta
7. Terminar el juego cuando:
   - Se adivina toda la palabra (victoria)
   - Se agotan todas las vidas (derrota)
8. Dar la opción de jugar otra partida

### Ejercicio: Codificación Especular de Texto
Crear un programa que transforme un texto aplicando varias técnicas de codificación.
El programa debe:
1. Permitir al usuario introducir un texto (terminando con un punto)
2. Aplicar las siguientes transformaciones al texto:
   - Codificación especular: invertir cada palabra del texto, manteniendo el orden de las palabras
   - Codificación de puntuación: reemplazar los caracteres de puntuación (.,;:!¿?¡) con caracteres
     aleatorios del rango ASCII extendido (224-239)
3. Mostrar el texto resultante después de aplicar ambas codificaciones
4. Incluir también un método para eliminar espacios (aunque no se use en la implementación principal) 