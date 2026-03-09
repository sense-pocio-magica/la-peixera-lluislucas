public class Peix : Animal
{
    private static Random rPeix = new();
  
    


    public Peix((int x, int y) posicioInicial) : base(posicioInicial)
    {
      
      EscullSexe();
    }



    /*public  override bool EsPotReproduir(Animal altre)
    {
        
            return false;
    }*/

   public override Animal? Interactuar(Animal altre,Peixera peixera)
    {
        if(altre is Tauro)
        {
            Morir();
            return null;
        }

        if(altre is Peix p)
        {
            if(Sexe == p.Sexe)
            {
                Morir();
                p.Morir();
                
            }
            else
            {
                return Reproduccio(p, peixera);
                
            }
        }
        return null;
    }

  
       
    public override Animal Reproduccio(Animal altrePeix, Peixera peixera)
    {
            (int x, int y) posicioFill = peixera.EscollirPosicioInicialAnimal(rPeix);

            while (posicioFill == this.Posicio || posicioFill == altrePeix.Posicio)
            {
                posicioFill = peixera.EscollirPosicioInicialAnimal(rPeix);
            }

            return new Peix(posicioFill);
    }

        
}
    

/* 

if ( altre is Tauro)
{
        this.Matar()
}
>>>>>>> dbabe4d474eafa1aebe5001e2603dc10f69b7ef1
if ( altre is Peix p)
{
    if(p.sexe == sexe)
    else
        criar()
}

*/
