
var puntajeMaximoElement = document.getElementById("maximo-puntaje");
var puntajeActualElement = document.getElementById("puntaje-actual");
var intentosRestantesElement = document.getElementById("intentos-restantes");
var inputDeAdivinar = document.getElementById("adivinar");
var botonEnviar = document.getElementById("enviar");
var mensajeElement = document.getElementById("mensaje");

var puntajeActual = 0;
var puntajeMaximo = 0;
var intentosInicial = 20;
var intentosRestantes = intentosInicial;
var maximaCantidadDeIntentos = 20;
var numeroSecreto = generarNumeroAleatorio();

intentosRestantesElement.textContent = intentosRestantes;

botonEnviar.addEventListener("click", () => {
    var guess = parseInt(inputDeAdivinar.value);

    if (isNaN(guess) || guess < 1 || guess > maximaCantidadDeIntentos) {
        mensajeElement.textContent = "Ingresa un numero  entre 1 y " + maximaCantidadDeIntentos;
    } else {
        --intentosRestantes;

        if (guess === numeroSecreto) {
            mensajeElement.textContent = "Adivinaste....! El numero es " + numeroSecreto;
            puntajeActual += intentosRestantes;
            numeroSecreto = generarNumeroAleatorio();
            intentosRestantes = intentosInicial;
        } else if (guess < numeroSecreto) {
            mensajeElement.textContent = "NO...! el numero es mayor. Quedan " + intentosRestantes + " intentos";
        } else {
            mensajeElement.textContent = "NO...! el numero es menor. Quedan " + intentosRestantes + " intentos";
        }

        if (intentosRestantes === 0) {
            mensajeElement.textContent = "perdiste! El numero era " + numeroSecreto;
            if (puntajeActual > puntajeMaximo) {
                puntajeMaximo = puntajeActual;
                puntajeMaximoElement.textContent = puntajeMaximo;
            }
            puntajeActual = 0;
            intentosRestantes = intentosInicial;
            numeroSecreto = generarNumeroAleatorio();
        }

        inputDeAdivinar.value = "";
        puntajeActualElement.textContent = puntajeActual;
        intentosRestantesElement.textContent = intentosRestantes;
    }
});

// Función para generar un número aleatorio entre 1 y 20
function generarNumeroAleatorio() {
    return Math.floor(Math.random() * maximaCantidadDeIntentos) + 1;
}