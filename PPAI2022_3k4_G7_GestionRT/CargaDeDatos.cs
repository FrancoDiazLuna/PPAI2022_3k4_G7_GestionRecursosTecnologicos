using PPAI2022_3k4_G7_GestionRT.entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2022_3k4_G7_GestionRT
{
    public static class CargaDeDatos
    {
        //Cientificos en el sistema
        public static PersonalCientifico cientifico1 = new PersonalCientifico(1234567, "nom1", "ape1", 12345678, 351234567, "correo1@gmail.com", "correo1@unc.com");
        public static PersonalCientifico cientifico2 = new PersonalCientifico(1234567, "nom2", "ape2", 12345678, 351234567,  "correo2@gmail.com", "correo2@unc.com");
        public static PersonalCientifico cientifico3 = new PersonalCientifico(1234567, "nom3", "ap3", 12345678, 351234567, "correo3@gmail.com", "correo3@unc.com");
        public static PersonalCientifico cientifico4 = new PersonalCientifico(1234567, "nom4", "ape4", 12345678, 351234567, "correo4@gmail.com", "correo4@unc.com");

        //Sesion actual
        public static DateTime fechaInicio = DateTime.Now;
        public static DateTime fechaFin = DateTime.Now.AddHours(2);

        public static Usuario user = new Usuario("ramonRoldan", "root", true, cientifico1);
        public static Sesion sesionActual = new Sesion(fechaFin, fechaInicio, user);

        //Tipos de recursos en el sistema
        public static TipoRecursoTecnologico tipoRecurso1 = new TipoRecursoTecnologico("Microscopio", "Descripcion");
        public static TipoRecursoTecnologico tipoRecurso2 = new TipoRecursoTecnologico("Balanza de precision ", "Descripcion");
        public static TipoRecursoTecnologico tipoRecurso3 = new TipoRecursoTecnologico("Centrifugador", "Descripcion");
        public static TipoRecursoTecnologico tipoRecurso4 = new TipoRecursoTecnologico("Mixer", "Descripcion");
        public static TipoRecursoTecnologico tipoRecurso5 = new TipoRecursoTecnologico("Horno", "Descripcion");
        public static TipoRecursoTecnologico tipoRecurso6 = new TipoRecursoTecnologico("Resonador magnético", "Descripcion");
        public static TipoRecursoTecnologico tipoRecurso7 = new TipoRecursoTecnologico("Equipamiento de cómputo de datos de alto rendimiento", "Descripcion");
        

        //Modelos en el sistema
        public static Modelo modelo = new Modelo("XZ3343");
        public static Modelo modelo1 = new Modelo("AAA3343");
        public static Modelo modelo2 = new Modelo("XAF6343");
        public static Modelo modelo3 = new Modelo("XBGH463");
        public static Modelo modelo4 = new Modelo("CVGT677");
        public static Modelo modelo5 = new Modelo("AGH7676");
        public static Modelo modelo6 = new Modelo("AGGF5677");
        public static Modelo modelo7 = new Modelo("X2000");
        public static Modelo modelo8 = new Modelo("BM345");
        public static Modelo modelo9 = new Modelo("X2001");
        public static Modelo modelo10 = new Modelo("MP354");
        public static Modelo modelo11 = new Modelo("P350");
        public static Modelo modelo12 = new Modelo("KAII34");
        public static Modelo modelo13 = new Modelo("HYS68");
        public static Modelo modelo14 = new Modelo("SFS667");

        //Estados Recurso Tecnologico
        public static Estado estadoRT1 = new Estado("En mantenimiento", "Descripcion", "Recurso", false, false);
        public static Estado estadoRT2 = new Estado("DisponibleRT", "Descripcion", "Recurso", true, false);
        public static Estado estadoRT3 = new Estado("Mantenimiento correctivo", "Descripcion", "Recurso", false, false);

        //Estados Turno
        public static Estado estadoTDisponible = new Estado("Disponible", "Descripcion", "Turno", true, false);
        public static Estado estadoTPendiente = new Estado("Pendiente", "Descripcion", "Turno", true, true);
        public static Estado estadoTReservado = new Estado("Reservado", "Descripcion", "Turno" , true , false);

        //Cambios de estado Turno
        public static CambioEstadoTurno cet1 = new CambioEstadoTurno(estadoTDisponible, new DateTime(2022, 06, 20) , new DateTime(2022, 06, 21));
        public static CambioEstadoTurno cet2 = new CambioEstadoTurno(estadoTDisponible, new DateTime(2022, 06, 22) , new DateTime(2022, 06, 23));
        public static CambioEstadoTurno cet3 = new CambioEstadoTurno(estadoTDisponible, new DateTime(2022, 06, 24), null);
        

        //Cambios de estado RT
        public static CambioEstadoRT cert1 = new CambioEstadoRT(estadoRT1, fechaInicio, fechaFin );
        public static CambioEstadoRT cert2 = new CambioEstadoRT(estadoRT2, fechaInicio, fechaFin );
        public static CambioEstadoRT cert3 = new CambioEstadoRT(estadoRT3, fechaInicio, fechaFin );

        //Marcas en el sistema
        public static Marca marca1 = new Marca("Nikon", new List<Modelo> { modelo, modelo1 });
        public static Marca marca2 = new Marca("Okrus", new List<Modelo> { modelo2, modelo3 });
        public static Marca marca3 = new Marca("Jano", new List<Modelo> { modelo4, modelo5, modelo6 });
        public static Marca marca4 = new Marca("Leica", new List<Modelo> { modelo7, modelo9 });
        public static Marca marca5 = new Marca("General Electric", new List<Modelo> { modelo9 });
        public static Marca marca6 = new Marca("Picker", new List<Modelo> { modelo10, modelo14 });
        public static Marca marca7 = new Marca("Fugaku ", new List<Modelo> { modelo11, modelo12, modelo13 });

        public static List<Estado> loadEstados()
        {
            List<Estado> listaEstados = new List<Estado>();
            listaEstados.Add(estadoTDisponible);
            listaEstados.Add(estadoTPendiente);
            listaEstados.Add(estadoTReservado);
            listaEstados.Add(estadoRT1);
            listaEstados.Add(estadoRT2);
            listaEstados.Add(estadoRT3);

            return listaEstados;
        }

        
        public static List<TipoRecursoTecnologico> loadTiposRecursoTecnologico()
        {
            List<TipoRecursoTecnologico> listaTipoRecursos = new List<TipoRecursoTecnologico>();
            listaTipoRecursos.Add(tipoRecurso1);
            listaTipoRecursos.Add(tipoRecurso2);
            listaTipoRecursos.Add(tipoRecurso3);
            listaTipoRecursos.Add(tipoRecurso4);
            listaTipoRecursos.Add(tipoRecurso5);
            listaTipoRecursos.Add(tipoRecurso6);
            listaTipoRecursos.Add(tipoRecurso7);


            return listaTipoRecursos;
        }

        public static List<CambioEstadoRT> crearCambioEstadoRTsDisponible()
        {
            List<CambioEstadoRT> listaCambioEstados = new List<CambioEstadoRT>();
            listaCambioEstados.Add(cert3);
            listaCambioEstados.Add(cert1);
            listaCambioEstados.Add(cert2);

            return listaCambioEstados;

        }

        public static List<CambioEstadoRT> crearCambioEstadoRTsReservable()
        {
            List<CambioEstadoRT> listaCambioEstados = new List<CambioEstadoRT>();
            listaCambioEstados.Add(cert1);
            listaCambioEstados.Add(cert2);
            listaCambioEstados.Add(cert3);

            return listaCambioEstados;

        }

        public static Sesion loadSesion() { return sesionActual; }

        public static List<PersonalCientifico> loadCientificos()
        {
            List<PersonalCientifico> listaCientificos = new List<PersonalCientifico>();
            listaCientificos.Add(cientifico1);

            return listaCientificos;
        }

        public static List<Marca> loadMarcas()
        {
            List<Marca> listaMarcas = new List<Marca>();
            listaMarcas.Add(marca1);
            listaMarcas.Add(marca2);
            listaMarcas.Add(marca3);

            return listaMarcas;
        }
        public static List<RecursoTecnologico> loadRecursoTecnologico()
        {
            List<RecursoTecnologico> listaRT = new List<RecursoTecnologico>();
            listaRT.Add(new RecursoTecnologico(1,fechaInicio,modelo1,20,2,null,null,null,null,tipoRecurso1));
            listaRT.Add(new RecursoTecnologico(1,fechaInicio,modelo2,25,3,null,null,null,null,tipoRecurso2));
            listaRT.Add(new RecursoTecnologico(1,fechaInicio,modelo3,30,4,null,null,null,null,tipoRecurso3));
            listaRT.Add(new RecursoTecnologico(1,fechaInicio,modelo4,45,5,null,null,null,null,tipoRecurso4));
            return listaRT;
        }
    }
}
