# code-challenge-2
Sogeti Code Challenge de Navidad 2015
=====================================
Desafío #2: Cálculo de estadísticas
-----------------------------------
*Para medir los tiempos de respuesta de las páginas web, es muy importante recoger los datos de las respuestas para ver si hay anormalidades en ellos. Por ejemplo, la desviación estándar mide cuantos valores hay que son "extraños", es decir fuera de los rangos normales de valores.*
 
Escribe un programa que le pida al usuario los tiempos de respuesta de un sitio web, expresado en milisegundos. Debería pedir los números hasta que el usuario introduzca *"done"*. El programa entonces debería mostrar los números, la media aritmética, el tiempo mínimo, el tiempo máximo y la desviación estándar. 
 
Para calcular el promedio: suma de todos los valores / número de valores.
Para calcular la [desviación estándar](https://en.wikipedia.org/wiki/Standard_deviation): calcular la diferencia de la media para cada valor, elevarla al cuadrado, hacer una media de las diferencias al cuadrado y sacar la raíz cuadrada de la media. 
 
 
Ejemplo de salida del programa
------------------------------
    Introduzca un número: 100
    Introduzca un número: 200
    Introduzca un número: 1000
    Introduzca un número: 300
    Introduzca un número: done
    Números: 100, 200, 1000, 300
    El promedio es 400.
    El mínimo es 100.
    El máximo es 1000.
    La desviación estándar es 353,55.
 
Restricciones
-------------
* Utilizar sólo bucles y colecciones matriciales (arrays, listas) para recoger los números y hacer los cálculos matemáticos
* Impedir que el usuario entre valores no numéricos para los parámetros
* Convertir de manera explícita los valores numéricos de salida a strings
* Vigilar de no introducir el "done" como uno de los elementos de la matriz de entrada
* Vigilar de que el programa resultante esté debidamente encapsulado en clases y métodos públicos y privados
 
Para nota
---------
* Leer los números de un fichero de texto en vez de pedirlos en el bucle
* Preguntar al usuario si se usará un fichero o la introducción manual de datos

¿Cómo subir mi código a GitHub?
===============================
En vez de enviar el código a mi correo, tenéis que hacer lo siguiente:
* Hacer un fork de este repositorio
* Crear una carpeta con vuestro nombre
* Meter vuestra solución en el repositorio
* Hacer _commit_ en vuestro fork
* Hacer un _pull request_ para que lo incluya yo en el repositorio al final del tiempo del desafío

Tenéis una guía de como hacer un fork y pull request en GitHub [aquí](https://help.github.com/articles/fork-a-repo/)



