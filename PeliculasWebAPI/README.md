# Resumen de la sección 9: Escenarios Avanzados
___

1. __Funciones Escalares.__
2. __Funciones con Valores de Tabla.__
3. __Columnas Calculadas.__
4. __Secuencias.__
5. __Conflicto de Concurrencia por Campo.__

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

Son definidas por el usuario que envés de devolver un escalar retorna un conjunto de resultados, es decir, filas y columnas

Vamos a definir una vista pero como una función definia por el usuario, creamos una migración. 

![funcionVTmigration](/PeliculasWebAPI/images/funcionesValoresTabla%20migration.png)

En nuestro `ApplicationDBContext.cs` definimos las siguiente código para usar la función que creamos. 

        /* Para usar la función definida por el usuario */
        modelBuilder.Entity<PeliculaConteos>()
                    .HasNoKey()
                    .ToTable(name: null);

        modelBuilder.HasDbFunction(() => PeliculaConteo(0));

Ademá de definir una función que devolverá lo que queremos. 

![funcionDbContext](/PeliculasWebAPI/images/funcionesValoresTabla%20dbContext.png)

En nuestro `PeliculasController.cs` definimos un nuevo `endpoint` de tipo `GET` que nos devolverá la función que definimos. 

![peliculaControllFVT](/PeliculasWebAPI/images/peliculasConteo%20FuncionVT.png)

Al probar el `endpoint` obtenemos un status `200`.

![resultFVT](/PeliculasWebAPI/images/funcionesValoresTabla%20Result.PNG)

#### Columnas Calculadas

Nos permiten automatizar el llenado de las columnas con el resultado de alguna operación, existen dos tipos de columnas calculadas: 

- Las que guardan el valor final en la columna. 
- Las que no la hacen, calcula su valor en base a su consulta, sin embargo esta operación puede consumir tiempo de ejecución. 

Por ejemplo, si queremos agregar una columna de Total y Cantidad a nuestra entidad `FacturaDetalle.cs`. 

![facturaDetalle](/PeliculasWebAPI/images/FacturaDetalle.png)

Al hacer su configuración, usamos el método `HasComputedColumnSql()` donde guardaremos el valor en la columna calculada. 

![FacturaDetalleConfig](/PeliculasWebAPI/images/FacturaDetalleConfig.png)

Hacemos la migración. 

![migracionFacturaDetalle](/PeliculasWebAPI/images/TotalCalculadoMigracion.png)

Creamos un nuevo `endpoint` en nuestro `FacturaController.cs` de tipo `GET` el cual nos traerá la información de un registro con la columna que agregamos. 

![facturaController](/PeliculasWebAPI/images/FacturaDetalleController.png)

Al probar, obtenemos un status `200` con el resultado esperado. 

![columnCalcResult](/PeliculasWebAPI/images/Columnas%20Calculadas%20Result.PNG)

#### Secuencias

Si queremos agregar una columna de sencuencia que permita tener valores de tipo _id_ usamos la forma secuencia. 

Supongamos que queremos tener una secuencia de factura, modificamos nuestra `Factura.cs` donde agremos una nueva columna que tendrá la secuencia.

![facturaSencuencia](/PeliculasWebAPI/images/facturaSecuencia.png)

En nuestro `ApplicationDBContext.cs` agregamos la siguiente línea el cual va mapear la secuencia hacia el esquema. 

    /* Creamos la secuencia numero de factura */
    modelBuilder.HasSequence<int>("NumFactura", "factura");

Modificamos nuestro `FacturaConfig.cs` para agregar la línea:

    builder.Property(f => f.NumFactura)
            .HasDefaultValueSql("NEXT VALUE FOR factura.NumFactura");

El cual va asignar el siguiente valor para la columna _NumFactura_ de tipo secuencia. 

Hacemos nuestra migración y empujamos los cambios hacia la Base de Datos. 

![migracionSecuencia](/PeliculasWebAPI/images/migracionSecuencia.png)

Al actualizar nuestra Base de Datos, vemos reflejado los cambios. 

![facturaBD](/PeliculasWebAPI/images/NumFactura%20Result.PNG)

#### Conflicto de Concurrencia por Campo
