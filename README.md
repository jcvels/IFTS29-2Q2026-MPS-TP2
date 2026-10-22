---
Institucion: IFTS19 - INSTITUTO DE FORMACIÓN TÉCNICA SUPERIOR N° 29
Materia: Metodología de Pruebas de Sistemas
Alumno: Jorge Pauvels
Fecha: 2026-10-21
--- 

# Trabajo Práctico 2: Pruebas sobre sistema de gestión de productos

Solución en C# para un sistema simple de gestión de productos incluyendo pruebas unitarias con NUnit.

> **ATENCION**  
> Verificar que el valor de `TargetFramework` en `ProductSystem.csproj` coincida con la versión instalada de `.net` en el sistema.


## Carpetas

- `ProductSystem`: clases `Product` y `ProductManager`.
- `ProductSystem.Tests`: pruebas automatizadas con NUnit.

## Ejecución

```bash
  dotnet test ProductSystem.csproj
```

## Test

|Nombre                               |Descripción                                                                                                                          |Estado |
|---                                  |---                                                                                                                                  |---|
|`CreatesProduct__WithValidData`      |Creación de productos: comprobar que un producto se crea correctamente con un identificador, nombre, precio y categoría válidos.     |`DONE`|
|`AddProduct_WithValidProduct`        |Incorporación de productos: verificar que addProduct agrega correctamente un producto a la lista interna.                            |`DONE`|
|`FindProductByName_WithExistingName` |Búsqueda de productos: agregar varios productos y comprobar que findProductByName permite encontrar cada uno por su nombre.          |`DONE`|
|`FindProductByName_WithUnknownName`  |Producto inexistente: verificar el comportamiento del método de búsqueda cuando no existe un producto con el nombre solicitado.      |`DONE`|
|`CalculateTotalPrice_ForElectronics` |Cálculo para Electrónica: comprobar que calculateTotalPrice aplica correctamente el impuesto del 10 %.                               |`DONE`|
|`CalculateTotalPrice_ForFood`        |Cálculo para Alimentos: comprobar que calculateTotalPrice aplica correctamente el impuesto del 5 %.                                  |`DONE`|
|`CreatesProduct__WithNegativePrice`  |Validación del precio: comprobar que el sistema rechaza un producto cuyo precio base sea negativo.                                   |`DONE`|
|`CreatesProduct__WithInvalidCategory`|Validación de categoría: comprobar que el sistema rechaza una categoría distinta de las permitidas.                                  |`DONE`|
