using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2022_3k4_G7_GestionRT.entidad
{
    public class Modelo
    {
        private string nombre;

        public Modelo(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombreModelo() { return nombre; }

        public string getMarca(List<Marca> marcas)
        {
            string nombreMarca = "";
            foreach (var marca in marcas)
            {
                if (marca.esDeEstaMarca(this))
                {
                    nombreMarca= marca.getNombre();

                }
            }
            return nombreMarca;


        }

    
    }
}
