using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2022_3k4_G7_GestionRT.entidad
{
    public class RecursoTecnologicoMuestra
    {
        //ATRIBUTOS
        private string centroDeInvestigacion;
        private int numeroInventario;
        private string marca;
        private string modelo;
        private string estado;
        private int color;

        //METODOS

        // --> Metodo Constructor
        public RecursoTecnologicoMuestra(string centroDeInv, int numeroInventario, string marca, string modelo, string estado)
        {
            this.centroDeInvestigacion= centroDeInv;
            this.numeroInventario = numeroInventario;
            this.marca = marca;
            this.modelo = modelo;
            this.estado = estado;
        }

        public void setColor(int nroColor)
        {
            this.color = nroColor;
        }

        public string getEstado() { return estado; }
        public string getCentroDeInvestigacion() { return centroDeInvestigacion; }
        public string getMarca() { return marca; }
        public string getModelo() { return modelo; }
        public int getNumetoInventario() { return numeroInventario; }

        internal int getColor()
        {
            return color;
        }
    }
}
