public abstract class Animal
{
    private static Random r = new();
    public (int x, int y) Posicio_inicial {get; private set;}

    public (int x, int y) Direccio {get; private set;}

    public bool EsViu {get; private set;}

    public Animal()
    {
      direccioAnimal();
      EsViu = true;

    }

    
    public void direccioAnimal ()
    {
        string[] direccions = {"dreta","esquerra","amunt","abaix"};
        string index = direccions[r.Next(direccions.Length-1)];
        
       
       
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

    public void MoureAnimal( (int x, int y) inici,(int x, int y) direccio )
    {
        
    }

    // 


   

    //Mirar si hi ha algu a la mateix aposicio per ronda???



    
}