# Trabajo Práctico N.º 2

Implementar pruebas automatizadas utilizando NUnit para verificar el funcionamiento de un sistema simple de gestión de productos, aplicando los conceptos de pruebas unitarias y validación de reglas de negocio.

## 1. Desarrollo del sistema

Se deberá desarrollar un sistema sencillo de gestión de productos en C#.

Las clases del sistema deberán estar ubicadas en una carpeta separada de la utilizada para las pruebas.

### Clase Product

Crear una clase llamada Product que represente un producto y contenga las siguientes propiedades:

- `id`: identificador del producto. 
- `name`: nombre del producto.
- `price`: precio base del producto.
- `category`: categoría del producto.

Las categorías permitidas serán `Electrónica` y `Alimentos`.

### Clase ProductManager

Crear una clase llamada ProductManager que permita administrar los productos mediante los siguientes métodos:

- `addProduct`: agrega un producto a una lista interna de productos.
- `calculateTotalPrice`: calcula el precio final de un producto, incluyendo el impuesto correspondiente a su categoría.
- `findProductByName`: busca un producto por su nombre y devuelve la información del producto encontrado. Si no existe un producto con ese nombre, deberá indicar que no se encontró.

## 2. Reglas de negocio

El sistema deberá respetar las siguientes reglas:

1. El precio base de un producto no puede ser negativo. Si se intenta crear o agregar un producto con un precio negativo, la operación deberá rechazarse mediante una excepción.
2. Los productos de la categoría Electrónica tendrán un impuesto del 10 % sobre el precio base.
3. Los productos de la categoría Alimentos tendrán un impuesto del 5 % sobre el precio base.
4. El precio final se calculará sumando al precio base el impuesto correspondiente.
5. Solo se admitirán las categorías indicadas en esta consigna.

> Ejemplos de cálculo:
> - Producto de Electrónica con precio base de $1000: precio final de $1100.
> - Producto de Alimentos con precio base de $1000: precio final de $1050.

## 3. Pruebas automatizadas

Crear un proyecto de pruebas utilizando NUnit y desarrollar pruebas automatizadas para verificar los siguientes comportamientos:

1. Creación de productos: comprobar que un producto se crea correctamente con un identificador, nombre, precio y categoría válidos. [OK]
2. Incorporación de productos: verificar que addProduct agrega correctamente un producto a la lista interna. []
3. Búsqueda de productos: agregar varios productos y comprobar que findProductByName permite encontrar cada uno por su nombre.
4. Producto inexistente: verificar el comportamiento del método de búsqueda cuando no existe un producto con el nombre solicitado.
5. Cálculo para Electrónica: comprobar que calculateTotalPrice aplica correctamente el impuesto del 10 %.
6. Cálculo para Alimentos: comprobar que calculateTotalPrice aplica correctamente el impuesto del 5 %.
7. Validación del precio: comprobar que el sistema rechaza un producto cuyo precio base sea negativo.
8. Validación de categoría: comprobar que el sistema rechaza una categoría distinta de las permitidas.

Se podrán utilizar atributos de NUnit, como [Test] y [TestCase], cuando resulten convenientes para organizar y reutilizar las pruebas.

## 4. Organización del proyecto

El proyecto deberá estar organizado de manera que las clases del sistema estén separadas de las clases de prueba.

> Por ejemplo: 
> - Carpeta ProductSystem: contendrá las clases Product y ProductManager.
> - Carpeta o proyecto ProductSystem.Tests: contendrá las pruebas automatizadas con NUnit.

Las pruebas deberán ejecutarse correctamente y permitir comprobar los resultados obtenidos frente a los resultados esperados.

## 5. Entrega

En el espacio de entrega del aula virtual deberán adjuntar la carpeta completa del proyecto (comprimida) con todos los archivos necesarios para revisar el código y ejecutar las pruebas.

Antes de realizar la entrega, verifiquen que el proyecto pueda abrirse y que las pruebas se ejecuten correctamente.
