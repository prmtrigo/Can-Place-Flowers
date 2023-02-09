namespace Can_Place_Flowers;
class Program
{
    public bool canPlaceFlowers(int[] canteiro, int parametro){
        //definir contador e tamanho
        int contador = 0;  int tamanho = canteiro.Length;

        for(int i =0; i< tamanho; i++){

            if(canteiro[i] == 0){
                //verificar se esses lados estão vazios
                bool esquerdaVazia = (i == 0) || (canteiro[i-1] == 0);
                bool direitaVazia = (i == tamanho - 1) || (canteiro[i+1] == 0);

                //se os dois lados estão vazios, podemos plantar!
                if (esquerdaVazia && direitaVazia){
                    canteiro[i] = 1;
                    contador++;
                    if(contador >= parametro){
                        Console.WriteLine("1");
                        return true;
                    }
                }
            }
        }

        Console.WriteLine("0");
        return contador >= parametro;
    }
    static void Main(string[] args)
    {
        Program p =  new Program();

        int[] canteiro = {1,0,0,0,1};

        int parametro = 2;

        p.canPlaceFlowers(canteiro,parametro);
    }
}
