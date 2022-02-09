// Daniel Hoyos Correa
// 000407988
// daniel.hoyos@upb.edu.co

(BEGIN)
	// Inicializamos la direccion de los input de teclado.
	@24576
	D=A
	@keyboard
	M=D
	// Guardamos en memoria codigo de la tecla F.
	@70
	D=A
	@keycodef
	M=D
	// Guardamos en memoria codigo de la tecla C.
	@67
	D=A
	@keycodec
	M=D
(CHECK_KEYBOARD)
    @fillvalue
	D=M
	@BLACK_SCREEN
	D;JNE
	// Guardamos en memoria el ultimo pixel a pintar.
	@24575
	D=A
	@current
	M=D
	// Leer si se detecta presion en el teclado, y comprobar por el codigo si es una F; consecuente llenar pantalla.
	@keyboard
	A=M
	D=M
	@fillvalue
	M=-1
	@keycodef
	D=D-M
	@DRAW
	D;JEQ
	// Si no cumple con la condicion, limpiar pantalla.
	@fillvalue
	M=0
(DRAW)
	// Hacer el llenado de pixeles dependiendo del valor (0 para blanco y -1 para negro).
	@fillvalue
	D=M
	@current
	A=M
	M=D
	// Revisar si el ultimo pixel pintado es el primero en pantalla (similar a un indice, al llegar a 0).
	// Saltar a la comprobacion de teclado en caso tal.
	@current
	D=M
	@16384
	D=D-A
	@CHECK_KEYBOARD
	D;JLE
	// Decrecimiento en el indice del pixel en cuestion.
	@current
	M=M-1
	// Salto infinito para dibujar en cada pixel (Se omite la iteracion al llegar al ultimo pixel).
	@DRAW
	0;JMP