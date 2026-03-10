public class Tortuga : Animal
{
    public ESexe Sexe {get; private set;}

    
    public Tortuga((int x, int y) posicioInicial) : base(posicioInicial)
    {
      
      EscullSexe();
    }

    
    public override Animal? Interactuar(Animal altre, Peixera peixera)
    {
        
        if(altre is Peix p)
        {
            p.Morir();
        }

        if(altre is Tauro t)
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
}