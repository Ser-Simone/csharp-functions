/*Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:

void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array
in questa forma “[elemento 1, elemento 2, elemento 3, ...]”. Potete prendere quella fatta in classe questa mattina 
int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti
gli elementi elevati quadrato. Attenzione: è importante restituire un nuovo array, e non modificare l’array come 
parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli 
elementi dell’array.
Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già 
dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
Stampare l’array di numeri fornito a video
Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato, ristampo nuovamente l’array originale e verificando che sia rimasto [2, 6, 7, 5, 3, 9])
Stampare la somma di tutti i numeri
Stampare la somma di tutti i numeri elevati al quadrati*/

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

//--------





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

int sommaElementiQuadrato (int[] array )
{

}

