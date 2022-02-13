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
            fillValue = -1;
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

void Draw()
{
    for(int i = current; i<16384; i--)
    {
        RAM[i] = fillValue
    }

    CheckKeyBoard();
}

// Funcion leer teclado con pantalla en negro.

sbyte BlackScreen ()
{
    current = 24575;
    if(RAM[keyboard] == keycodeC)
    {
        fillValue = 0;
        Draw();
    }
    else
    {
        fillValue = RAM[current];
    }
    return fillValue;
}

// Ciclo para iterar la revision de teclado.

while(fillValue == -1)
{
    fillValue = BlackScreen();
}