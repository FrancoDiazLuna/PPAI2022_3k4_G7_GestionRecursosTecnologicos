using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2022_3k4_G7_GestionRT.entidad
{
    public class RecursoTecnologico
    {
        private int nroInventario;
        private DateTime fechaAlta;
        private Modelo modelo;
        private int periodicidadMant;  // periodicidad de mantenimiento en dias
        private int duracionMant;   // duracionMant
        private List<Turno> listaTurno;
        private List<CambioEstadoRT> cambiosEstadosRT;
        private AsignacionRespTecnologico responsableTecnologico;
        private List<CaracteristicasDelRecurso> caracteristica;
        private TipoRecursoTecnologico tipoDeRecurso;
        private CentroDeInvestigacion centroInvestigacion;

        public RecursoTecnologico(int nroInventario, Modelo modelo, TipoRecursoTecnologico tipoDeRecurso, List<CambioEstadoRT> cambiosEstadosRT, List<Turno> listaTurno)
        {
            this.nroInventario = nroInventario;
            this.modelo = modelo;
            this.listaTurno = listaTurno;
            this.cambiosEstadosRT = cambiosEstadosRT;
            this.tipoDeRecurso = tipoDeRecurso;
        }

           
        //public void buscarDatosRT(List<CentroDeInvestigacion> centrosDeInvestigacion)
        //{
        //    String nombreCI = "";
        //    if (this.buscarEstadoActual() == true)
        //    {
        //        /*
        //        En teoria esta seria la dependencia con el Centro de Investigacion
        //        Con esto, sabriamos si el nombre del CI al cual pertenece el RT
        //         */
        //        foreach (CentroDeInvestigacion ci : centrosDeInvestigacion)
        //        {
        //            if (ci.esTuRecursoTecnologico(this) == true)
        //            {
        //                nombreCI = ci.getNombre();
        //            }
        //        }
        //        /*
        //        Faltan modeloYmarca + nroInventario
        //        Verificar que debemos devolver, si un objeto con todos los datos o una lista
        //         */
        //    }
        //    Object datosRt = new Object();

        //    //return datosRt;
        //}

        //public Boolean buscarEstadoActual()
        //{
        //    Boolean esReservable = false;
        //    if (!cambiosEstadosRT.isEmpty())
        //    {
        //        for (CambioEstadoRT c:cambiosEstadosRT)
        //        {
        //            if (c.esEstadoActual())
        //            {
        //                esReservable = c.esReservable();
        //                break;
        //            }
        //        }
        //    }
        //    return esReservable;
        //}
        
        public bool esTuTipo(string nombreTipoRecurso)
        {
            return this.tipoDeRecurso.esTuTipo(nombreTipoRecurso);
        }

        public bool esReservable()
        {
            return this.cambiosEstadosRT.Last().esActual() && this.cambiosEstadosRT.Last().esReservable();
        }

        public RecursoTecnologicoMuestra mostrarDatosDeRT(List<Marca> marcas)
        {
            int nroInv = this.getNroInventario();
            mostrarCentroDeInvest();
            List<String> modeloYMarca = mostrarMarcaYModelo();
            string nombreEstado = getEstadoRT();

            return new RecursoTecnologicoMuestra(centroInvestigacion, nroInv, modeloYMarca[1], modeloYMarca[0], nombreEstado);
        }

        public int getNroInventario() { return nroInventario; }

        public void mostrarCentroDeInvest()
        {
            //Esto se realiza porque los datos estan Harcodeados
            List<CentroDeInvestigacion> centrosInvestigacion = CargaDeDatos.listarCentros();
            centrosInvestigacion[0].setRecursosTecnologicos(CargaDeDatos.loadRecursosTecnologicosC1());
            centrosInvestigacion[1].setRecursosTecnologicos(CargaDeDatos.loadRecursosTecnologicosC2());
            centrosInvestigacion[2].setRecursosTecnologicos(CargaDeDatos.loadRecursosTecnologicosC3());

            foreach (CentroDeInvestigacion centro in centrosInvestigacion)
            {
                if (centro.obtenerCIdeRecursoTecnologico(this) != null)
                {
                    centroInvestigacion = centro.obtenerCIdeRecursoTecnologico(this);
                }

            }
        }

        public List<String> mostrarMarcaYModelo()
        {
            List<String> modeloYMarca = this.modelo.obtenerModeloYMarca();
            return modeloYMarca;
        }

        public string getEstadoRT() { return cambiosEstadosRT.Last<CambioEstadoRT>().getNombreEstado(); }

        //public List<Turno> obtenerTurnos(bool esCientificodelCentro) //Ver observacion 3 y resolver lo q pide
        //{
        //    List<Turno> turnosDisponibles = new List<Turno>();
        //    DateTime date = DateTime.Now;

        //    if (esCientificodelCentro)
        //    {
        //        foreach (Turno turno in listaTurno)
        //            if (turno.validarFechaHoraInicio(date))
        //            {
        //                turnosDisponibles.Add(turno);
        //            }

        //    }
        //    else
        //    {
        //        foreach (Turno turno in listaTurno)
        //            if (turno.validarFechaHoraInicio(date.AddDays(centroInvestigacion.getTiempoAntelacionReserva())))
        //            {
        //                turnosDisponibles.Add(turno);
        //            }
        //    }

        //    return turnosDisponibles;
        //}
    }
}
