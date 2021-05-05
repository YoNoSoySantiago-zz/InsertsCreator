# Inserts Creator

Este programa permite generar automaticamente los INSERTS para una base de datos en SQL Oracle, la cual contiene la siguiente informacion en sus tablas:


_DB={Employee, Department, Project, WorksOn}_

_Employee(empNo, fName, lName, address, DOB, sex, position, deptNo)_

_Department(deptNo, deptName, mgrEmpNo)_    

_Project(projNo, projName, deptNo)_

_WorksOn(empNo, projNo, dateworked, hoursWorked)_

Employee  es la tabla que contiene la información de los empleados. Un empleado trabaja en un departamento y esto es representado por el atributo deptNo. 

Department  es la tabla con la información de cada departamento.  mgrEmpNo es el identificador del empleado que es el jefe del departamento.  Solo hay un jefe por cada departamento.

Project es la tabla que contiene la información de los proyectos asignados a cada departamento. Un proyecto es ejecutado por un solo departamento.

WorksOn es la tabla que contiene los detalles de las horas trabajadas por los empleados de cada proyecto.


## Comenzando 🚀

_Estas instrucciones te permitirán obtener una copia del proyecto en funcionamiento en tu máquina local para propósitos de desarrollo y pruebas._

* Clonar el repositorio en tu equipo
* Abrir la carpeta InsertCreatorApp
* Ejecutar la aplicacion **InsertCreatorApp.sln** en Visual Studio
* Iniciar el proyecto
* Escoger la cantidad de INSERTS de cada tabla que se desea generar
* Presionar el botón **GENERATE** el cual abrira la Ubicacion del archivo generado

y con esto tendriamos nuestro archivo INSERTS.sql con los inserts generados.

### Pre-requisitos 📋

_Se necesita tener isntalado Visual Studio, preferiblemente la ultima version_

```
Visual Studio 2019 v16.9.4
```

## Autores ✒️

* **Santiago Hurtado Solis** [YoNoSoySantiago](https://github.com/YoNoSoySantiago)
* **Luis Felipe Gomez** [gomezLF](https://github.com/gomezLF)

También puedes mirar la lista de todos los [contribuyentes](https://github.com/your/project/contributors) quíenes han participado en este proyecto. 
