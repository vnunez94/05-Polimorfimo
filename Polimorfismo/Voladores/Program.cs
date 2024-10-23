using System;
namespace Voladores{
    public class Program
    {
        public static void Main()
        {
            Avion avion = new Avion();
            Helicoptero helicoptero = new Helicoptero();
            Superman superman = new Superman();
            SuperTucano superTucano = new SuperTucano();
            
            Aeropuerto.Despegar(avion);
            Aeropuerto.Despegar(helicoptero);
            Aeropuerto.Despegar(superman);
            Aeropuerto.Despegar(superTucano);         
        
        }
    }
    
    interface IVolador{
        void volar();
    }

    class Helicoptero : IVolador{
        public void volar(){
            Console.WriteLine("Helicoptero volando");
        }
        
    }
    class Superman : IVolador{
        public  void volar(){
            Console.WriteLine("Superman volando");
        }
        
    }
    class Avion : IVolador
    {
        public virtual void volar()
        {
            Console.WriteLine("Avion volando");
        }

    }

    class SuperTucano: Avion{
        public override void volar(){ //new para ocultar el metodo volar de la clase Avion
            //prueba cambiando la palabra override por new y verifica la salida
            Console.WriteLine("SuperTucano volando");
        }
        
    }
    class Aeropuerto{
        public static void Despegar(IVolador volador){
            volador.volar();
        }
    }
}