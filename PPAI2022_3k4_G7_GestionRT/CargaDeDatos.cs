﻿using PPAI2022_3k4_G7_GestionRT.entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2022_3k4_G7_GestionRT
{
    public static class CargaDeDatos
    {
        //Cientificos en el sistem
        public static PersonalCientifico cientifico1 = new PersonalCientifico(1, "Ramon", "Roldan", 23392569, 353657450, "ramonroldan@gmail.com", "rroldan@unc.com");
        public static PersonalCientifico cientifico2 = new PersonalCientifico(1, "Ana", "Roldan", 20458785, 353657450, "anaroldan@gmail.com", "anaroldan@unc.com");
        public static PersonalCientifico cientifico3 = new PersonalCientifico(1, "Juan", "Marin", 22365489, 353657450, "juanmarin@gmail.com", "juanmarin@unc.com");
        public static PersonalCientifico cientifico4 = new PersonalCientifico(1, "Rosalia", "Lopez", 23365478, 353657450, "rolopez@gmail.com", "rolopez@unc.com");

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
        public static Estado estadoRT1 = new Estado("En mantenimiento", "Descripcion", "Recurso");
        public static Estado estadoRT2 = new Estado("Disponible", "Descripcion", "Recurso");
        public static Estado estadoRT3 = new Estado("Mantenimiento correctivo", "Descripcion", "Recurso");

        //Estados Turno
        public static Estado estadoTDisponible = new Estado("Disponible", "Descripcion", "Turno");
        public static Estado estadoTPendiente = new Estado("Pendiente", "Descripcion", "Turno");
        public static Estado estadoTReservado = new Estado("Reservado", "Descripcion", "Turno");

        //Cambios de estado Turno
        public static CambioEstadoTurno cet1 = new CambioEstadoTurno(fechaInicio, estadoTDisponible);
        public static CambioEstadoTurno cet2 = new CambioEstadoTurno(fechaInicio, estadoTPendiente);
        public static CambioEstadoTurno cet3 = new CambioEstadoTurno(fechaInicio, estadoTReservado);

        //Cambios de estado RT
        public static CambioEstadoRT cert1 = new CambioEstadoRT(estadoRT1, fechaInicio, fechaFin);
        public static CambioEstadoRT cert2 = new CambioEstadoRT(estadoRT2, fechaInicio, fechaFin);
        public static CambioEstadoRT cert3 = new CambioEstadoRT(estadoRT3, fechaInicio, fechaFin);

        //Marcas en el sistema
        public static Marca marca1 = new Marca("Nikon", new List<Modelo> { modelo, modelo1 });
        public static Marca marca2 = new Marca("Okrus", new List<Modelo> { modelo2, modelo3 });
        public static Marca marca3 = new Marca("Jano", new List<Modelo> { modelo4, modelo5, modelo6 });
        public static Marca marca4 = new Marca("Leica", new List<Modelo> { modelo7, modelo9 });
        public static Marca marca5 = new Marca("General Electric", new List<Modelo> { modelo9 });
        public static Marca marca6 = new Marca("Picker", new List<Modelo> { modelo10, modelo14 });
        public static Marca marca7 = new Marca("Fugaku ", new List<Modelo> { modelo11, modelo12, modelo13 });

        //Turnos en el sistema
        public static Turno turn1 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(1).AddHours(2), DateTime.Now.AddDays(1).AddHours(3), crearCambioEstadoTurnosReservado());
        public static Turno turn2 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(1).AddHours(3), DateTime.Now.AddDays(1).AddHours(5), crearCambioEstadoTurnosDisponible());
        public static Turno turn3 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(1), DateTime.Now.AddDays(1).AddHours(1), crearCambioEstadoTurnosReservado());
        public static Turno turn4 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(1), DateTime.Now.AddDays(1).AddHours(1), crearCambioEstadoTurnosDisponible());
        public static Turno turn5 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(2), DateTime.Now.AddDays(2).AddHours(1), crearCambioEstadoTurnosReservado());
        public static Turno turn6 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(5), DateTime.Now.AddDays(5).AddHours(1), crearCambioEstadoTurnosDisponible());
        public static Turno turn7 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(4).AddHours(1), DateTime.Now.AddDays(4).AddHours(2), crearCambioEstadoTurnosDisponible());
        public static Turno turn8 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(4).AddHours(2), DateTime.Now.AddDays(4).AddHours(4), crearCambioEstadoTurnosDisponible());
        public static Turno turn9 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(4).AddHours(4), DateTime.Now.AddDays(4).AddHours(6), crearCambioEstadoTurnosDisponible());
        public static Turno turn10 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(4).AddHours(6), DateTime.Now.AddDays(4).AddHours(8), crearCambioEstadoTurnosDisponible());
        public static Turno turn11 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(4).AddHours(8), DateTime.Now.AddDays(4).AddHours(10), crearCambioEstadoTurnosDisponible());
        public static Turno turn12 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(4).AddHours(10), DateTime.Now.AddDays(4).AddHours(11), crearCambioEstadoTurnosDisponible());
        public static Turno turn13 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(6).AddHours(1), DateTime.Now.AddDays(6).AddHours(2), crearCambioEstadoTurnosDisponible());
        public static Turno turn14 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(6).AddHours(2), DateTime.Now.AddDays(6).AddHours(4), crearCambioEstadoTurnosDisponible());
        public static Turno turn15 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(6).AddHours(4), DateTime.Now.AddDays(6).AddHours(6), crearCambioEstadoTurnosDisponible());
        public static Turno turn16 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(6).AddHours(6), DateTime.Now.AddDays(6).AddHours(8), crearCambioEstadoTurnosDisponible());
        public static Turno turn17 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(6).AddHours(8), DateTime.Now.AddDays(6).AddHours(10), crearCambioEstadoTurnosDisponible());
        public static Turno turn18 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(6).AddHours(10), DateTime.Now.AddDays(6).AddHours(11), crearCambioEstadoTurnosDisponible());
        public static Turno turn19 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(3).AddHours(1), DateTime.Now.AddDays(3).AddHours(2), crearCambioEstadoTurnosDisponible());
        public static Turno turn20 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(3).AddHours(2), DateTime.Now.AddDays(3).AddHours(4), crearCambioEstadoTurnosDisponible());
        public static Turno turn21 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(3).AddHours(4), DateTime.Now.AddDays(3).AddHours(6), crearCambioEstadoTurnosDisponible());
        public static Turno turn22 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(3).AddHours(6), DateTime.Now.AddDays(3).AddHours(8), crearCambioEstadoTurnosDisponible());
        public static Turno turn23 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(3).AddHours(8), DateTime.Now.AddDays(3).AddHours(10), crearCambioEstadoTurnosDisponible());
        public static Turno turn24 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(3).AddHours(10), DateTime.Now.AddDays(3).AddHours(11), crearCambioEstadoTurnosDisponible());
        public static Turno turn25 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(7).AddHours(1), DateTime.Now.AddDays(7).AddHours(2), crearCambioEstadoTurnosDisponible());
        public static Turno turn26 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(7).AddHours(2), DateTime.Now.AddDays(7).AddHours(4), crearCambioEstadoTurnosDisponible());
        public static Turno turn27 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(7).AddHours(4), DateTime.Now.AddDays(7).AddHours(6), crearCambioEstadoTurnosDisponible());
        public static Turno turn28 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(7).AddHours(6), DateTime.Now.AddDays(7).AddHours(8), crearCambioEstadoTurnosDisponible());
        public static Turno turn29 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(7).AddHours(8), DateTime.Now.AddDays(7).AddHours(10), crearCambioEstadoTurnosDisponible());
        public static Turno turn30 = new Turno(DateTime.Now, DayOfWeek.Monday, DateTime.Now.AddDays(7).AddHours(10), DateTime.Now.AddDays(7).AddHours(11), crearCambioEstadoTurnosDisponible());

        //Asignacion de Cientificos
        public static readonly AsignacionCientifico acci1 = new AsignacionCientifico(fechaInicio, fechaFin, cientifico1);
        public static readonly AsignacionCientifico acci2 = new AsignacionCientifico(fechaInicio, fechaFin, cientifico2);
        public static readonly AsignacionCientifico acci3 = new AsignacionCientifico(fechaInicio, fechaFin, cientifico3);
        public static readonly AsignacionCientifico acci4 = new AsignacionCientifico(fechaInicio, fechaFin, cientifico4);

        //Centros de Investigacion en el sistema
        public static CentroDeInvestigacion centro1 = new CentroDeInvestigacion("Centro FCEFyN", "FCEFyN", "Chile 215", 7, loadRecursosTecnologicos(), crearAsignacionCientifico());
        public static CentroDeInvestigacion centro2 = new CentroDeInvestigacion("Centro F.C.M.", "Facultad de Ciencias Médicas", " Blvd. de la Reforma 197", 3, loadRecursosTecnologicos(), crearAsignacionCientifico());
        public static CentroDeInvestigacion centro3 = new CentroDeInvestigacion("Centro F.O.", "Facultad de Odontología (F.O.)", "Haya de la Torre S/N, X5000", 5, loadRecursosTecnologicos(), crearAsignacionCientifico());

        //Recursos tecnologicos en el sistema
        public static RecursoTecnologico rt1 = new RecursoTecnologico(1, modelo4, tipoRecurso1, crearCambioEstadoRTsDisponible(), crearListaTurnos());
        public static RecursoTecnologico rt2 = new RecursoTecnologico(2, modelo6, tipoRecurso4, crearCambioEstadoRTsReservable(), crearListaTurnos());
        public static RecursoTecnologico rt3 = new RecursoTecnologico(3, modelo2, tipoRecurso3, crearCambioEstadoRTsReservable(), crearListaTurnos());
        public static RecursoTecnologico rt4 = new RecursoTecnologico(4, modelo4, tipoRecurso2, crearCambioEstadoRTsDisponible(), crearListaTurnos());
        public static RecursoTecnologico rt5 = new RecursoTecnologico(5, modelo5, tipoRecurso5, crearCambioEstadoRTsReservable(), crearListaTurnos());
        public static RecursoTecnologico rt6 = new RecursoTecnologico(6, modelo3, tipoRecurso6, crearCambioEstadoRTsReservable(), crearListaTurnos());
        public static RecursoTecnologico rt7 = new RecursoTecnologico(7, modelo1, tipoRecurso7, crearCambioEstadoRTsReservable(), crearListaTurnos());
        public static RecursoTecnologico rt8 = new RecursoTecnologico(1, modelo4, tipoRecurso1, crearCambioEstadoRTsDisponible(), crearListaTurnos());
        public static RecursoTecnologico rt9 = new RecursoTecnologico(2, modelo6, tipoRecurso4, crearCambioEstadoRTsReservable(), crearListaTurnos());
        public static RecursoTecnologico rt10 = new RecursoTecnologico(3, modelo2, tipoRecurso3, crearCambioEstadoRTsReservable(), crearListaTurnos());
        public static RecursoTecnologico rt11 = new RecursoTecnologico(4, modelo4, tipoRecurso2, crearCambioEstadoRTsDisponible(), crearListaTurnos());
        public static RecursoTecnologico rt12 = new RecursoTecnologico(5, modelo5, tipoRecurso5, crearCambioEstadoRTsReservable(), crearListaTurnos());
        public static RecursoTecnologico rt13 = new RecursoTecnologico(6, modelo3, tipoRecurso6, crearCambioEstadoRTsReservable(), crearListaTurnos());
        public static RecursoTecnologico rt14 = new RecursoTecnologico(7, modelo1, tipoRecurso7, crearCambioEstadoRTsReservable(), crearListaTurnos());
        public static RecursoTecnologico rt15 = new RecursoTecnologico(1, modelo4, tipoRecurso1, crearCambioEstadoRTsDisponible(), crearListaTurnos());
        public static RecursoTecnologico rt16 = new RecursoTecnologico(2, modelo6, tipoRecurso4, crearCambioEstadoRTsReservable(), crearListaTurnos());
        public static RecursoTecnologico rt17 = new RecursoTecnologico(3, modelo2, tipoRecurso3, crearCambioEstadoRTsReservable(), crearListaTurnos());
        public static RecursoTecnologico rt18 = new RecursoTecnologico(4, modelo4, tipoRecurso2, crearCambioEstadoRTsDisponible(), crearListaTurnos());
        public static RecursoTecnologico rt19 = new RecursoTecnologico(5, modelo5, tipoRecurso5, crearCambioEstadoRTsReservable(), crearListaTurnos());
        public static RecursoTecnologico rt20 = new RecursoTecnologico(6, modelo3, tipoRecurso6, crearCambioEstadoRTsReservable(), crearListaTurnos());
        public static RecursoTecnologico rt21 = new RecursoTecnologico(7, modelo1, tipoRecurso7, crearCambioEstadoRTsReservable(), crearListaTurnos());


        public static List<CentroDeInvestigacion> listarCentros()
        {
            var centros = new List<CentroDeInvestigacion>();
            centros.Add(centro1);
            centros.Add(centro2);
            centros.Add(centro3);

            return centros;
        }

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

        public static List<Turno> crearListaTurnos()
        {
            List<Turno> modList1 = new List<Turno>();
            modList1.Add(turn1);
            modList1.Add(turn2);
            modList1.Add(turn3);
            modList1.Add(turn4);
            modList1.Add(turn5);
            modList1.Add(turn6);
            modList1.Add(turn7);
            modList1.Add(turn8);
            modList1.Add(turn9);
            modList1.Add(turn10);
            modList1.Add(turn11);
            modList1.Add(turn12);
            modList1.Add(turn13);
            modList1.Add(turn14);
            modList1.Add(turn15);
            modList1.Add(turn16);
            modList1.Add(turn17);
            modList1.Add(turn18);
            modList1.Add(turn19);
            modList1.Add(turn20);
            modList1.Add(turn21);
            modList1.Add(turn22);
            modList1.Add(turn23);
            modList1.Add(turn24);
            modList1.Add(turn25);
            modList1.Add(turn26);
            modList1.Add(turn27);
            modList1.Add(turn28);
            modList1.Add(turn29);
            modList1.Add(turn30);

            return modList1;
        }
        public static List<AsignacionCientifico> crearAsignacionCientifico()
        {
            List<AsignacionCientifico> list = new List<AsignacionCientifico>();
            list.Add(acci1);
            list.Add(acci2);
            list.Add(acci3);
            list.Add(acci4);

            return list;
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

        public static List<CambioEstadoTurno> crearCambioEstadoTurnosReservado()
        {
            List<CambioEstadoTurno> listaCambioEstados = new List<CambioEstadoTurno>();
            listaCambioEstados.Add(cet1);
            listaCambioEstados.Add(cet2);
            listaCambioEstados.Add(cet3);

            return listaCambioEstados;
        }

        public static List<CambioEstadoTurno> crearCambioEstadoTurnosDisponible()
        {
            List<CambioEstadoTurno> listaCambioEstados = new List<CambioEstadoTurno>();
            listaCambioEstados.Add(cet3);
            listaCambioEstados.Add(cet2);
            listaCambioEstados.Add(cet1);

            return listaCambioEstados;
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

        internal static List<RecursoTecnologico> loadRecursosTecnologicosC1()
        {
            List<RecursoTecnologico> listaRecursos = new List<RecursoTecnologico>();
            listaRecursos.Add(rt1);
            listaRecursos.Add(rt2);
            listaRecursos.Add(rt3);
            listaRecursos.Add(rt4);
            listaRecursos.Add(rt5);
            listaRecursos.Add(rt6);
            listaRecursos.Add(rt7);
            return listaRecursos;
        }

        internal static List<RecursoTecnologico> loadRecursosTecnologicosC2()
        {
            List<RecursoTecnologico> listaRecursos = new List<RecursoTecnologico>();
            listaRecursos.Add(rt8);
            listaRecursos.Add(rt9);
            listaRecursos.Add(rt10);
            listaRecursos.Add(rt11);
            listaRecursos.Add(rt12);
            listaRecursos.Add(rt13);
            listaRecursos.Add(rt14);
            return listaRecursos;
        }

        internal static List<RecursoTecnologico> loadRecursosTecnologicosC3()
        {
            List<RecursoTecnologico> listaRecursos = new List<RecursoTecnologico>();
            listaRecursos.Add(rt14);
            listaRecursos.Add(rt15);
            listaRecursos.Add(rt16);
            listaRecursos.Add(rt17);
            listaRecursos.Add(rt18);
            listaRecursos.Add(rt19);
            listaRecursos.Add(rt20);
            listaRecursos.Add(rt21);
            return listaRecursos;
        }

        internal static List<RecursoTecnologico> loadRecursosTecnologicos()
        {
            List<RecursoTecnologico> listaRecursos = new List<RecursoTecnologico>();
            listaRecursos.Add(rt1);
            listaRecursos.Add(rt2);
            listaRecursos.Add(rt3);
            listaRecursos.Add(rt4);
            listaRecursos.Add(rt5);
            listaRecursos.Add(rt6);
            listaRecursos.Add(rt7);
            listaRecursos.Add(rt8);
            listaRecursos.Add(rt9);
            listaRecursos.Add(rt10);
            listaRecursos.Add(rt11);
            listaRecursos.Add(rt12);
            listaRecursos.Add(rt13);
            listaRecursos.Add(rt14);
            listaRecursos.Add(rt15);
            listaRecursos.Add(rt16);
            listaRecursos.Add(rt17);
            listaRecursos.Add(rt18);
            listaRecursos.Add(rt19);
            listaRecursos.Add(rt20);
            listaRecursos.Add(rt21);

            return listaRecursos;
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
    }
}
