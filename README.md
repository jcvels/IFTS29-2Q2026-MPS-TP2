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

- `ProductSystem`: biblioteca con las clases `Product` y `ProductManager`.
- `ProductSystem.Tests`: pruebas automatizadas con NUnit.
- `ProductSystem.sln`: solución que reúne ambos proyectos.

### Ejecución

```bash
  dotnet test ProductSystem.csproj
```

### Test Implementados

1. Creación de productos: comprobar que un producto se crea correctamente con un identificador, nombre, precio y categoría válidos. `OK`
2. Incorporación de productos: verificar que addProduct agrega correctamente un producto a la lista interna. `OK`
3. Búsqueda de productos: agregar varios productos y comprobar que findProductByName permite encontrar cada uno por su nombre. `OK`
4. Producto inexistente: verificar el comportamiento del método de búsqueda cuando no existe un producto con el nombre solicitado. `OK`
5. Cálculo para Electrónica: comprobar que calculateTotalPrice aplica correctamente el impuesto del 10 %. `OK`
6. Cálculo para Alimentos: comprobar que calculateTotalPrice aplica correctamente el impuesto del 5 %. `OK`
7. Validación del precio: comprobar que el sistema rechaza un producto cuyo precio base sea negativo. `OK`
8. Validación de categoría: comprobar que el sistema rechaza una categoría distinta de las permitidas. `OK`
