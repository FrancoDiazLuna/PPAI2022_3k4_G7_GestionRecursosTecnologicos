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

        public string Nombre { get => nombre; set => nombre = value; }

        public List<String> obtenerModeloYMarca()
        {
            //Primero modelo y despues marca
            var modeloYMarca = new List<String>();
            modeloYMarca.Add(nombre);
            var marcas = CargaDeDatos.loadMarcas();
            foreach (var marca in marcas)
            {
                if (marca.esDeEstaMarca(this))
                {
                    modeloYMarca.Add(marca.getNombre());

                }
            }


            return modeloYMarca;
        }
    }
}
