# C# WinForm
## _Control de Inventarios_
[Manual](https://github.com/Tvkaes/Concept-WinForms/blob/main/Proyecto%20Final.pdf)

Proyecto en c# con WinForms de un sistema de control de inventarios e Inicio de sesion donde se podra registrar Productos y visualizarlos en una tabla y en una grafica , se tendra en cuenta hacer dentro de este apartado un punto de venta pero por el momento solo sera el control de inventarios


## Características

- Registro de Cuentas e Inicio de Sesion 
- Altas,Bajas,Consulta de Productos
- Modificacion de Informacio del Usuario
- Graficacion de Datos
- Utilizacion de Firebase

### ToDo
 - Punto de Venta
 - Generar Reportes PDF
 - Redundancias en GridView
 - Enlistar datos en GridView
 - Mejora de Diseño

En este proyecto se utlizo la libreria de [Firebase](https://firebase.google.com) en C# llamada Firesharp y Mediante los WinForms hacer las peticiones a la base datos.

## Firebase
**Firebase** se trata de una plataforma móvil creada por **Google**, cuya principal función es desarrollar y facilitar la creación de apps de elevada calidad de una forma rápida, con el fin de que se pueda aumentar la base de usuarios y ganar más dinero. La plataforma está subida en la nube y está disponible para diferente plataformas como iOS, Android y web. Contiene diversas funciones para que cualquier desarrollador pueda combinar y adaptar la plataforma a medida de sus necesidades.

#### Instalar Firesharp
**Instalacion via Nugget**
```sh
//**Install v2**
Install-Package FireSharp

//**Install v1**
Install-Package FireSharp -Version 1.1.0
```
##### Documentacion 
[Firesharp Documentacion](https://github.com/ziyasal/FireSharp)


## Material Skin v2.0
Dentro de este proyecto es estuvo utilizando la libreria de MaterialSkin que nos brinda diferentes componentes al WinForms con un mejor diseño y mas editables haciendo una mejor vista y atraccion al usuario

#### instalacion de Material Skinv 2.0
**Instalacion Via Nugget**
```sh
Install-Package MaterialSkin.2 -Version 2.1.4
```
##### Documentacion 
mas sobre el uso de [MaterialSkin](https://github.com/IgnaceMaes/MaterialSkin)
#### Imagenes

![alt tag](https://res.cloudinary.com/dlhdg8qoy/image/upload/v1620285158/Proyecto/unknown.png)

*Ejemplo Crudo del inicio de sesion que tendra en la interfaz*

![alt tag](https://res.cloudinary.com/dlhdg8qoy/image/upload/v1620285166/Proyecto/unknown1.png)

*Tambien podras registrarte sin uso de correo o si se llega a ocupar esta abierto a facil editar*

![alt tag](https://res.cloudinary.com/dlhdg8qoy/image/upload/v1620285166/Proyecto/unknown2.png)

*El dashboard que se utiliza se pretende que sea practico y facil de entender y de leer.* **ToDo**

![alt tag](https://res.cloudinary.com/dlhdg8qoy/image/upload/v1620285778/Proyecto/Captura.png)

*Este apartado del dashboard esta dirigido a la configuracion de Apariencia del interfaz y la configuracion de cuenta e informacion*
