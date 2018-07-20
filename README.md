#Estructura DDD:

#0.Api:


Esta capa es la que se encarga de gestionar las entradas externas de nuestra aplicación, y gestionar las acciones necesarias dependiendo del código.

**En esta capa estarian:**

- **Controllers:** Puntos de entrada que sera accesibles desde el exterior.

- **Sql:** Carpeta que contiene todos los versionados de las tablas.

#1.Application:


Aquí es donde se encarga de gestionar el negocio. Todo lo que seria cambiar de modelos para enviar a otras capas, o por ejemplo realizar calculos. 

**En esta capa encontraremos:**

- **Service.Contracts:** Interface, donde se veran todos los metodos que implementara nuestro service.

- **Service.Dto:** Modelo base, es decir los datos que seran recibidos de la web api externa.

- **Services:** Se encargara, de los calculos y gestionarlos hacia donde sea necesario.. "Domain.. Infrastructure.." 

#2.Domain
Esta capa es tranversal entre application e infrastructure. En ella se encuentran las entidades, en algunas ocasiones es utilizado para mappear antes de ir cambiar de capa.

#3.Infrastructure
Es la única capa capaz de interactuar con la BBDD, a demás de contener sus propio repositorio que es donde gestionara las llamadas a la base de datos. Las interfaces "contracts", donde esta especificado los metodos del repository. Como en las capas anteriores, tambien contiene un modelo "DataModel" que vendria siendo el modelo exacto de la base de datos.


![dddvueling](https://user-images.githubusercontent.com/37305728/43024733-6ca8515e-8c6f-11e8-904a-3d8e287e3ccc.png)

