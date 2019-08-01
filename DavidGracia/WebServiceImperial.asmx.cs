using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Services;

namespace DavidGracia
{
    /// <summary>
    /// Descripción breve de WebServiceImperial
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceImperial : WebService
    {
        private static List<Rebelde> Rebeldes = new List<Rebelde>();
        private static List<Planeta> Planetas = new List<Planeta>();
        private static readonly DateTime FechaLocal = DateTime.Now;
        readonly string _fecha = Convert.ToDateTime(FechaLocal).ToString("R");
        readonly string _rutaFichero = Directory.GetCurrentDirectory() + @"\InfoAvistamientoRebelde.txt";
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        [WebMethod]
        public bool AdjuntarRebelde(string nombre)
        {
            Rebelde rebelde = new Rebelde();

            try
            {
                if (!String.IsNullOrWhiteSpace(nombre))
                {
                    rebelde.Nombre = nombre;

                    Rebeldes.Add(rebelde);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                Log.Error("No se ha podido crear el rebelde" + _fecha);
                return false;
            }
        }

        [WebMethod]
        public bool AdjuntarPlaneta(string nombre)
        {
            Planeta planeta = new Planeta();

            try
            {
                if (!String.IsNullOrWhiteSpace(nombre))
                {
                    planeta.Nombre = nombre;

                    Planetas.Add(planeta);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                Log.Error("No se ha podido crear el planeta " + _fecha);
                return false;
            }
        }

        [WebMethod]
        public bool AdjuntarIdentificacion(List<string> datos)
        {

            try
            {
                if (!File.Exists(_rutaFichero))
                {
                    using (StreamWriter sw = File.CreateText(_rutaFichero))
                    {
                        foreach (var item in datos)
                        {
                            sw.WriteLine("rebeld " + item[1] + "on " + item[2] + "at " + _fecha);
                        }
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(_rutaFichero))
                    {
                        foreach (var item in datos)
                        {
                            sw.WriteLine("rebeld " + item[1] + "on " + item[2] + "at " + _fecha);
                        }
                    }
                }

                return true;
            }
            catch
            {
                Log.Error("No se ha guardado la información en el fichero " + _fecha);
                return false;
            }
        }
    }
}
