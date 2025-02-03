# WCF Temperature Service
Este repositorio contiene un servicio WCF (Windows Communication Foundation) que permite convertir temperaturas entre las escalas Celsius y Fahrenheit de manera facil y sencilla.

<p align="center">
  <img src="https://i.ibb.co/mrqSddQN/Screenshot-2025-02-03-163322.png" alt="img01">
</p>

## Descripción
El servicio proporciona métodos para convertir temperaturas entre Celsius, Fahrenheit y Kelvin. Se implementa utilizando Windows Communication Foundation (WCF), permitiendo su consumo en aplicaciones cliente. En este caso, se utiliza una aplicación cliente desarrollada en Web Forms que consume el servicio mediante Ajax. Sin embargo, es importante destacar que el servicio está diseñado para ser consumido por cualquier tipo de aplicación cliente, ya sea una aplicación de escritorio, móvil, web o cualquier otra plataforma compatible con WCF.

El servicio expone dos operaciones principales: 
1.	Convertir de Celsius a Fahrenheit.
2.	Convertir de Fahrenheit a Celsius.

## Tecnologías Utilizadas
-	C#
-	.NET Framework
-	WCF (Windows Communication Foundation)
-	Visual Studio

## Estructura del proyecto
```
WCF_Temperature/
├── WCF_Temperature.sln  # Solución del proyecto
├── WCF_Temperature/      # Proyecto principal
│   ├── IService.cs       # Interfaz del servicio
│   ├── Service.svc       # Implementación del servicio
│   ├── Web.config        # Configuración del servicio
├── Client/               # Aplicacion WebForms para consumir el servicio.
└── README.md             # Documentación del proyecto
```

## Instalación y Configuración

### Clonar el repositorio
```
git clone https://github.com/angelvargas75/WCF_Temperature.git
cd WCF_Temperature
```

### Abrir en Visual Studio
1.  Abrir WCF_Temperature.sln en Visual Studio.
2.  Compilar el proyecto.
3.  Ejecutar el servicio WCF.
   
### Consumir el servicio 
Puedes consumir el servicio desde un cliente WCF en una aplicación de consola, web o móvil.

Ejemplo de consumo en C#:
```
ServiceReference1.TemperatureServiceClient client = new ServiceReference1.TemperatureServiceClient();
double resultado = client.CelsiusToFahrenheit(25);
Console.WriteLine($"25°C en Fahrenheit: {resultado}°F");
```

## Enlace a la aplicación

Puedes acceder a la aplicación en el siguiente enlace: [WCF Temperature](http://demo3.somee.com/)

## Contribuciones
Si deseas contribuir a este proyecto, sigue estos pasos:

1.  Haz un fork del repositorio.
2.  Crea una rama para tu contribución (git checkout -b feature/nueva-funcionalidad).
3.  Realiza tus cambios y haz commit (git commit -m 'Añadir nueva funcionalidad').
4.  Sube tus cambios a tu fork (git push origin feature/nueva-funcionalidad).
5.  Abre un Pull Request en GitHub.

## Licencia
Este proyecto está bajo la licencia MIT. 
