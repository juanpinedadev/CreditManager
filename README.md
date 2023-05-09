# CreditManager

![GitHub license](https://img.shields.io/github/license/juanpinedadev/CreditManager?style=plastic)
![GitHub size](https://img.shields.io/github/repo-size/juanpinedadev/CreditManager?style=plastic)
![GitHub commit-activity](https://img.shields.io/github/commit-activity/w/juanpinedadev/CreditManager?style=plastic)
![Languages](https://img.shields.io/github/languages/count/juanpinedadev/CreditManager?style=plastic)
![SQL Server](https://img.shields.io/badge/SQL%20Server-2017-red/CreditManager?style=plastic)
![C#](https://img.shields.io/badge/-C%23-68217A?style=plastic&logo=c-sharp&logoColor=white)

CreditManager es una aplicación de gestión de créditos que utiliza C# y SQL Server. La aplicación está diseñada en una arquitectura en capas, lo que permite una mayor separación de responsabilidades y un mejor mantenimiento del código. En la capa de presentación, se utiliza Windows Forms para crear una interfaz de usuario intuitiva y fácil de usar.

## Requisitos

Antes de ejecutar la aplicación, asegúrese de tener lo siguiente instalado:

- Visual Studio 2019 o superior
- SQL Server 2016 o superior
- .NET Framework 4.7.2 o superior



## Características

- Registro de usuarios
- Creación y gestión de créditos
- Consulta y edición de información de créditos
- Reportes de créditos

## Requisitos

- .NET Framework 4.8 o superior
- SQL Server 2012 o superior

## Configuración

Antes de ejecutar la aplicación, es necesario configurar la conexión a la base de datos. Para ello, debe seguir los siguientes pasos:

1. Abra el archivo `app.config` en la capa de acceso a datos (`DataAccess`).
2. En la sección `<connectionStrings>`, reemplace `your_server_name` y `your_database_name` con la información correspondiente a su servidor y base de datos de SQL Server. También puede cambiar el nombre de usuario y la contraseña si es necesario.
3. Guarde el archivo `app.config`.

La aplicación está lista para ser ejecutada.

## Uso

Al abrir la aplicación, se mostrará la ventana de inicio de sesión. Si es un usuario registrado, puede ingresar su nombre de usuario y contraseña para acceder a la aplicación. Si no es un usuario registrado, haga clic en el botón "Registrar" para crear una nueva cuenta.

Una vez que haya iniciado sesión, se mostrará la ventana principal de la aplicación. Aquí puede crear nuevos créditos, ver y editar la información de los créditos existentes y generar reportes de créditos.

## Contribución

Si desea contribuir al proyecto, por favor haga un fork del repositorio y envíe sus cambios a través de un pull request. Agradecemos cualquier tipo de contribución, ya sea en forma de corrección de errores, mejoras en la interfaz de usuario o nuevas características.

## Licencia

Este proyecto está bajo la licencia MIT. Puede consultar el archivo `LICENSE` para más información.


