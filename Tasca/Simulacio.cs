public class Simulacio
{

    public Peixera Peixera {get; set;}

     public int Ronda { get; set; }

     public Simulacio(Peixera peixera)
    {
        Peixera = peixera;
        Ronda = 99;
    }
    
    public void MoureAnimals(Peixera peixera)
    {
        foreach(Animal a in peixera.Aquari)
        {
            a.MoureAnimal();
            
        }
    }
    public void BuscarCoincidencies(Peixera peixera)
    {
         foreach(Animal a in peixera.Aquari)
        {
            a.MoureAnimal();
            
        }
        
    }
    
    /*public  void Interactuar(Animal altre,Peixera peixera)
    {
        if(altre is Tauro)
        {
            Morir();
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
                Reproduccio(p, peixera);
                
            }
        }
    }*/

     public void FerRonda()
    {
        
    }

        
    }

  


    //te peixera

    //conta rondes 100

    //executar una ronda

    //mou animals x ronda

    //mira coincidencies

    //comprovar trobades

    //aplicar regles: executa comprovacions i metodes on hi ha coincidencies

    //mostrar resultats finals
    /*int Ronda

        FerRonda()

        Executar()

        ComprovarTrobades()

        GestionarInteraccions()

        EliminarMorts()

        MostrarResultatFinal()*/

    
    












}