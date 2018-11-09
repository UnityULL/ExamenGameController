# Examen
* Autor: Abel Delgado Falcón
* Email: alu0100792218@ull.edu.es
* Prueba de control realizada el viernes 9-11-2018 sobre eventos y game control.

### Objetivos
* Debe incluir varias instancias de 3 tipos de objetos A(dinámico), B (estáticos) y C (cinemáticos) (pueden ser primitivas 3d)
* Cuando el jugador colisiona con cualquier objeto A, se debe aumentar el poder de los objetos B y cambiar su color.
* Cuando el jugador colisiona con objetos de tipo B se deben mover los objetos de tipo C de forma proporcional a su poder.
* El jugador puede aumentar la masa de los objetos de tipo A en la UI.

## Entrega:
* Debe incluir varias instancias de 3 tipos de objetos A(dinámico), B (estáticos) y C (cinemáticos) (pueden ser primitivas 3d):
    - Los objetos de tipo A son cubos rojos dinámicos a los que se les añadió un RigiBody.
    - Los objetos de tipo B son cápsulas azules estáticas.
    - Los objetos de tipo C son esferas con RigiBody y la opción isKinematic marcada, lo que los convierte en cinemáticos


* Cuando el jugador colisiona con cualquier objeto A, se debe aumentar el poder de los objetos B y cambiar su color.
    - El poder no se aprecia, pero es una variable que aumenta y se muestra por consola.

![](media/first.gif)

* Cuando el jugador colisiona con objetos de tipo B se deben mover los objetos de tipo C de forma proporcional a su poder.
    - En este caso, el poder de los objetos B es de 5 y se aplica un transform de la posicion para el eje x y z

![](media/second.gif)
* El jugador puede aumentar la masa de los objetos de tipo A en la UI.

![](media/third.gif)
