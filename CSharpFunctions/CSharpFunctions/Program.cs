
// Somma quadrato un elemento
int sommaQuadrato = 5;
int risultato = Quadrato(sommaQuadrato);
Console.WriteLine(risultato);

//---------------- Somma elementi array
int[] arrayPrincipale = {2,6,7,5,3,9};
int sommaArray = sommaElementiArray(arrayPrincipale);
Console.WriteLine(sommaArray);

//--------------------------------------- stampa array

StampaArray(arrayPrincipale);
//--------stampa array al quadrato
int[] NuovoArrayAlQuadrato= ElevaArrayAlQuadrato(arrayPrincipale);
StampaArray(NuovoArrayAlQuadrato);

//-------- somma di tutti i numeri elevati al quadrati


int sommaArrayQuadrato = sommaElementiArray(NuovoArrayAlQuadrato);
Console.WriteLine(sommaArrayQuadrato);


//-------------- FUNZIONI --------------------------
void StampaArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] );
    if (i < array.Length - 1)
    {
        Console.Write(" ,");
    }
    
}
Console.WriteLine("]");
}
//----------------

int Quadrato(int numero )
{
    int numQuadrato = numero * numero;
    return numQuadrato;
}

int sommaElementiArray ( int[] array )
{
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }
    return somma;

}

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayAlQuadrato = (int[]) array.Clone();

    for (int i = 0; i < array.Length; i++)
    {
        arrayAlQuadrato[i] = array[i]* array[i]; 
    }
    
    return arrayAlQuadrato;   
}



