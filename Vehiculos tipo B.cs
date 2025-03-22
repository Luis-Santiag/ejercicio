using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio_4.MisClases
{
    internal class VehiculostipoB : vehiculo
    {
        private int CargarGasolina; // Cambio de diésel a gasolina
        private int capacidadPasajeros;
        private int pasajerosActuales;

        public VehiculostipoB(int Anio, string Elcolor, string Elmodelo) : base(Anio, Elcolor, Elmodelo)
        {
            tiposLicenciaAceptados = new List<string> { "B" }; // Solo se acepta licencia tipo B
            capacidadPasajeros = 5; // Capacidad máxima de pasajeros
            pasajerosActuales = 0; // Inicialmente no hay pasajeros
            CargarGasolina = 0; // Inicializar el nivel de gasolina
        }

        // Método para cargar gasolina
        public void CargarGasolina(int cantidad)
        {
            if (cantidad > 0)
            {
                this.CargarGasolina += cantidad;
                Console.WriteLine($"Se han cargado {cantidad} litros de gasolina. Nivel actual: {this.CargarGasolina} litros.");
            }
            else
            {
                Console.WriteLine("La cantidad a cargar debe ser mayor que 0.");
            }
        }

        // Propiedad para obtener el nivel de gasolina
        public int NivelGasolina
        {
            get { return CargarGasolina; }
        }

        // Método para cargar gasolina
        public void CargarGasolina(int cantidad)
        {
            if (cantidad > 0)
            {
                CargarGasolina += cantidad;
                Console.WriteLine($"Se han cargado {cantidad} litros de gasolina. Nivel actual: {CargarGasolina} litros.");
            }
            else
            {
                Console.WriteLine("La cantidad a cargar debe ser mayor que 0.");
            }
        }

        // Método para subir pasajeros
        public void SubirPasajeros(int cantidad)
        {
            if (cantidad < 0)
            {
                Console.WriteLine("La cantidad de pasajeros no puede ser negativa.");
                return;
            }

            if (pasajerosActuales + cantidad <= capacidadPasajeros)
            {
                pasajerosActuales += cantidad;
                Console.WriteLine($"Se han subido {cantidad} pasajeros. Pasajeros actuales: {pasajerosActuales}.");
            }
            else
            {
                Console.WriteLine("No hay suficiente espacio para más pasajeros.");
            }
        }

        // Método para bajar pasajeros
        public void BajarPasajeros(int cantidad)
        {
            if (cantidad < 0)
            {
                Console.WriteLine("La cantidad de pasajeros no puede ser negativa.");
                return;
            }

            if (pasajerosActuales - cantidad >= 0)
            {
                pasajerosActuales -= cantidad;
                Console.WriteLine($"Se han bajado {cantidad} pasajeros. Pasajeros actuales: {pasajerosActuales}.");
            }
            else
            {
                Console.WriteLine("No hay tantos pasajeros en el automóvil.");
            }
        }
    }
        