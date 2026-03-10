public class Tauro: Animal
{
    private static Random rPeix = new();
    public int RondaNaixament {get; set;}

    public ESexe Sexe {get; private set;}

    public Tauro((int x, int y) posicioInicial) : base(posicioInicial)
    {
      
      EscullSexe();
    }

    public override Animal? Interactuar(Animal altre, Peixera peixera)
    {
        
        if(altre is Peix p)
        {
            p.Morir();
        }
        else if(altre is Tortuga )
        {
            CanvidireccioTauro();
        }
        else if(altre is Tauro t)
        {
            if(Sexe == t.Sexe)
            {
                Morir();
                t.Morir();
            }
            else
            {
                 return Reproduccio(t,peixera);
                
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

            return new Tauro(posicioFill);
    }
    

    // public bool 50ROndesMor(Animal)
    
    //
    public void  CanvidireccioTauro()
    {

        int dx = r.Next(-1, 2);
        int dy = r.Next(-1, 2);
        

        while (dx == Direccio.dx && dy == Direccio.dy || dx == 0 && dy == 0)
        {
            dx = r.Next(-1, 2);
            dy = r.Next(-1, 2);
        }

        Direccio = (dx, dy);
        
    }

    
}