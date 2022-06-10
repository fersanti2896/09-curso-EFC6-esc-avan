# Resumen de la sección 9: Escenarios Avanzados
___

1. __Funciones Escalares.__
2. __Funciones con Valores de Tabla.__

#### Funciones Escalares

Una función definida por el usuario es una función en nuestra Base de Datos el cual podemos usar para encapsular funcionalidad, pero solo para consultas no se puede modificar la Base de Datos. 

El resultante de esta función puede ser un escalar o un conjunto de resultado. 

Para este ejemplo, creamos dos funciones escalares, la primera para calcular la suma de los costos de las ordenes de una factura y la segunda el promedio de dichos costos. 

Primero creamos una data en nuestro `SeedingFacturas.cs`. 

![seedingFacturas](/PeliculasWebAPI/images/seedingFacturas.png)

Creamos la migración para que empuje los cambios hacia la Base de Datos, de la misma forma, creamos una segunda migración limpia el cual vamos a definir Funciones SQL. 

![migracionFuncion](/PeliculasWebAPI/images/migracionFuncionesDefinidas.png)

La primera forma de definir una función por usuario, es a través de nuestro DbContext, en este caso en `ApplicationDbContext.cs`.

![primerFormaDbContext](/PeliculasWebAPI/images/facturaSumaDbContext.png)

La segunda forma es a través de una clase que va ser definida de igual forma en el DbContext con la línea: 

    /* Registro de Clase Auxiliar de Funciones Definidas por el Usuario */
    Escalares.RegistrarFunciones(modelBuilder);

Nuestra entidad `Escalares.cs`.

![escalares](/PeliculasWebAPI/images/escalares.png)

Finalmente vamos a crear un `endpoint` de tipo `GET` en nuestro `FacturaController.cs` el cual implementa las funciones que hicimos. 

![facturaGet](/PeliculasWebAPI/images/FacturaController%20FuncionesDefinidas.png)

Probamos nuestro `endpoint` y tenemos como resultado un status `200`.

![result](/PeliculasWebAPI/images/funcionesDefinidas%20Result.PNG)

Desde nuestra terminal vemos el query SQL que se ejecutó.

![resultCmd](/PeliculasWebAPI/images/funcionesDefinidas%20Result%20cmd.PNG)

#### Funciones con Valores de Tabla