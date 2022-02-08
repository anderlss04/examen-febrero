# Examen  
Exámen de comprobación de conocimientos sobre pruebas unitarias y TDD

## Enunciado
Se te proporcionan dos proyectos `dotnet` para realizar las *Pruebas Unitarias* asociadas a un `Sistema` que indica si una `Persona` puede tener descendencia natural con otra `Persona`.
Una `Persona` es un tipo de dato que refleja una persona, y tendrá como atributos nombre, edad, y sexo.

**Objetivo**   
Dos personas pueden tener descendencia si son de distinto sexo, su edad no difiere en más de 12 años, y pertenecen a rangos de edad consecutivos.

**Rangos de Edad**:  
- 0-19 MuyJoven  
- 20-29 Joven  
- 30-39 Plenitud  
- 40-49 Madurez  
- 50.. Vejez  

Nuestro Sistema tendrá codificados 10+ personas, y constará de `dos métodos` uno que indica si dos personas `AdmitenDescendencia`, y otro que calculará las `PosibleParejas` entre todos los seres anteriores.

_Sobre el primer método_:  
Dibuja en una hoja, identificada con tu nombre, el `diagrama de flujo`, `calcula la complejidad ciclomática` y presenta una tabla con el diseño de las `pruebas unitarias` que vas a  programar. 

_Para subir nota_:  
Programa el segundo método.


## Entrega
  La entrega se realiza subiendo el proyecto a un repositorio `Git` de acceso público que tu profesor evaluará. Introduce tu nombre y la url a tu repositorio en este documento.
  Se pide que en un (documento)[https://docs.google.com/document/d/1jgvz3u1SCS6zmqXtNA4e5FnsMvDf2lnLji2syLJzpZk/edit?usp=sharing] PDF/md, que muestra explicación y las capturas de pantalla que demuestran que tu programa y los test son correctos.

## Preparación
Utiliza la plantilla que tú hayas creado en clase o:
```
   git clone xxx
   cd xxx
   rd /q/s .git
```
Con estos comandos tienes dos proyectos, uno del `Sistema` y otro de `pruebas unitarias` limpio para poder subirlo al repositorio que crees para la entrega. Limpia el código que no sea necesario. 

