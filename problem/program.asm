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