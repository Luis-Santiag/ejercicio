using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_4.MisClases
{
    internal class trailer : vehiculo
    {
        private int NiveDisel;
        private int cargaActual;
        private int capacidadCarga;
        private int cargarDisel;

        public trailer(int Anio, string Elcolor, string Elmodelo) : base(Anio, Elcolor, Elmodelo)
        {
            tiposLicenciaAceptados = new List<string> { "A" };
            capacidadCarga = 10000;
            cargaActual = 0;
            cargarDisel = 0; 
        }

        
        public int NivelDisel
        {
            get { return cargarDisel; }
        }

       
        public void CagarDisel(int cantidad)
        {
            if (cantidad > 0)
            {
                cargarDisel += cantidad;
                Console.WriteLine($"Se han cargado {cantidad} litros de diésel. Nivel actual: {cargarDisel} litros.");
            }
            else
            {
                Console.WriteLine("La cantidad a cargar debe ser mayor que 0.");
            }
        }

      
        public int NivlDisel
        {
            get { return NiveDisel; }
        }

        public void CargarDisel(int cantidad)
        {
            if (cantidad > 0)
            {
                NiveDisel += cantidad;
                Console.WriteLine($"Se han cargado {cantidad} litros de diésel. Nivel actual: {CargarDisel} litros.");
            }
            else
            {
                Console.WriteLine("La cantidad a cargar debe ser mayor que 0.");
            }
        }

        
        public void CargarMaximo(int peso)
        {
            if (peso < 0)
            {
                Console.WriteLine("El peso no puede ser negativo.");
                return;
            }

            if (cargaActual + peso <= capacidadCarga)
            {
                cargaActual += peso;
                Console.WriteLine($"Mercancía cargada. Carga actual: {cargaActual} kg.");
            }
            else
            {
                Console.WriteLine("No se puede cargar, excede la capacidad máxima.");
            }
        }
    }
}