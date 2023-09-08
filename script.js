let numeroObjetivo;
let puntaje;
let puntajeMaximo = 0;

function iniciarPartida() {
    numeroObjetivo = Math.floor(Math.random() * 20) + 1;
    puntaje = 20;
    actualizarPuntajes();
}

function reiniciarPartida() {
    iniciarPartida();
    document.getElementById('mensaje').textContent = '';
    document.getElementById('numero').value = '';
}

function actualizarPuntajes() {
    document.getElementById('puntaje').textContent = `Puntaje: ${puntaje}`;
    document.getElementById('puntaje-maximo').textContent = `Puntaje Máximo: ${puntajeMaximo}`;
}

function adivinarNumero() {
    const suposicion = parseInt(document.getElementById('numero').value);

    if ( suposicion < 1 || suposicion > 20) {
        document.getElementById('mensaje').textContent = 'Ingresa un número válido entre 1 y 20.';
        return;}
        if (isNaN(parseInt(suposicion))) {
            alert("Ingresa un número válido.");
            return;
    }

    const diferencia = Math.abs(numeroObjetivo - suposicion);
    puntaje -= diferencia;

    if (suposicion === numeroObjetivo) {
        document.getElementById('mensaje').textContent = `¡Felicitaciones! Has adivinado el número ${numeroObjetivo}.`;
        if (puntaje > puntajeMaximo) {
            puntajeMaximo = puntaje;
        }
        
       
    } else {
        let pista = (suposicion > numeroObjetivo) ? 'muy alto' : 'muy bajo';
        document.getElementById('mensaje').textContent = `Intento incorrecto. Estás ${pista}.`;
        actualizarPuntajes();
    }

    if (puntaje <= 0) {
        document.getElementById('mensaje').textContent = `¡Perdiste! El número era ${numeroObjetivo}.`;
        
        return;
    }
}

document.getElementById('adivinar').addEventListener('click', adivinarNumero);
document.getElementById('reiniciar').addEventListener('click', reiniciarPartida);


iniciarPartida();
