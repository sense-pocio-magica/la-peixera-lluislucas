public abstract class Animal
{
    private static Random r = new();
    public (int x, int y) Posicio {get; private set;}

    public (int x, int y) Direccio {get; private set;}

    public bool EsViu {get; private set;}

    public Animal((int x, int y) posicio)
    {
      
      Posicio = posicio;
      direccioAnimal();
      EsViu = true;

    }
    
    public virtual void direccioAnimal ()
    {
        string[] direccions = {"dreta","esquerra","amunt","abaix"};
        string index = direccions[r.Next(direccions.Length)];
        
       
       
        switch (index)
        {
            case  "dreta":
              Direccio = (1,0);
                break;

            case  "esquerra":
                 Direccio = (-1,0);
                break;

            case  "amunt":
                Direccio = (0,-1);
                break;
 
            default:
                Direccio = (0,1);
                break;
        }
        
    }

    public virtual void MoureAnimal( (int x, int y) posicioActual,(int x, int y) direccio )
    {
        
        posicioActual.x = posicioActual.x +direccio.x;
        posicioActual.y = posicioActual.y +direccio.y;
        posicioActual= Posicio;

    }

    // 


   

    //Mirar si hi ha algu a la mateix aposicio per ronda???



    
}