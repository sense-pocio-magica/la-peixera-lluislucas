public class Tortuga: Animal
{
    private static Random rPeix = new();
    public Tortuga((int x, int y) posicioInicial) : base(posicioInicial)
    {
      
      EscullSexe();
    }

    
    public override Animal? Interactuar(Animal altre, Peixera peixera)
    {

        if(altre is Tortuga tortu)
        {
            if(Sexe == tortu.Sexe)
            {
                Morir();
                tortu.Morir();
            }
            else
            {
                return Reproduccio(tortu,peixera);
                
            }
        
        }
        return null;
    }

    public override Animal Reproduccio(Animal altre, Peixera peixera)
    {
            (int x, int y) posicioFill = peixera.EscollirPosicioInicialAnimal(rPeix);

            while (posicioFill == this.Posicio || posicioFill == altre.Posicio)
            {
                posicioFill = peixera.EscollirPosicioInicialAnimal(rPeix);
            }

            return new Tortuga(posicioFill);
    }
}