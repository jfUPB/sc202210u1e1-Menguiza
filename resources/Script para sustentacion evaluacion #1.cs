// Declaracion de variables.
uint keyboard = 24576;

ushort keycodeF = 70;

ushort keycodeC = 67;

sbyte fillValue = 0;

uint current = 0;

// Funcion leer teclado.

sbyte CheckKeyBoard (sbyte fillValue)
{
    if(fillValue != 0)
    {
        fillValue = BlackScreen();
    }
    else
    {
        current = 24575;

        if(RAM[keyboard] == keycodeF)
        {
            fillValue = -1
            Draw();
        }
        else
        {
            fillValue = 0;
        }
    }

    return fillValue;
}

// Ciclo para iterar la revision de teclado.

while(fillValue == 0)
{
    fillValue = CheckKeyBoard(fillValue);
}

// Ciclo iterativo para asignar a cada espacio de memoria, correspondiente a cada pixel, la informacion de color.
// En este caso negro (asignado por el numero -1).
For(int i = 24575; i!=0; i--)
{
    pixel[i] = -1
}

// Ciclo iterativo para asignar a cada espacio de memoria, correspondiente a cada pixel, la informacion de color.
// En este caso blanco (asignado por el numero 0).
For(int i = 24575; i!=0; i--)
{
    pixel[i] = 0
}

// Condicional que asigna el valor de llenado dependiendo de el input del teclado.
// En caso de ser F, se asigna negro (-1), en caso de ser C, se asigna blanco (0), y en caso de ser otra no hacer nada.
if(input.GetKey().keycode(F))
{
    valorDeLlenado = -1
}
elseif(input.GetKey().keycode(C))
{
    valorDeLlenado = 0;
}
else
{
    return;
}