# VBnet-Solicitud-de-empleo
Programa basico en VB Net con conexión a base de datos SSMS para la solicitud de empleo

Para integrar el uso de la base de datos se debe instalar **SQL Server Management Studio** donde se almacenara la base de datos y sus respectivas tablas.



## Configuración BBDD

Respecto a la integración de la base de datos lo primero se debe configurar el servidor con el cual se conecta manualmente, buscando la linea 86 de codigo en la que se pondra el Server y se especificara la base de datos.

```
 Dim conexion As New SqlConnection("server=Nombre_Ordenador(O nombre configurado para SSMS)\SQLEXPRESS01; database=BaseEmpleados(Nombre de la base de datos en SSMS) ; integrated security = true")
```

El servidor a introducir debe ser el configurado cuando se ha instalado SSMS (SQL Server Management Studio) y la base de datos puede ser cualquiera que deseeis.

![image](https://user-images.githubusercontent.com/35575917/120360094-acbaa580-c308-11eb-8818-640d82faf6db.png)

Para la creacion de la tabla dejo un fichero SQL, lo podeis abrir con SSMS y os generara la tabla automaticamente en la base de datos que seleccioneis.

https://github.com/alexs1711/VBnet-Solicitud-de-empleo/blob/main/Solicitud%20de%20Empleo/GeneradorTabla.sql

## 

Muchas gracias por leer y espero que este programa haya sido de vuestro agrado, es una pequeña practica que queria subir para quien quiera aprender a como crear un pequeña aplicacion en VB.Net con una conexión a una base de datos.
