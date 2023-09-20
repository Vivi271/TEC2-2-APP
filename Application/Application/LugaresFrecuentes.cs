using System;
using System.Collections.Generic;

namespace Application
{
    public class LugaresFrecuentes
    {
        private Dictionary<string, (double Latitud, double Longitud)> ubicaciones = new Dictionary<string, (double, double)>();

        public void AgregarUbicacion(string lugar, double latitud, double longitud)
        {
            ubicaciones[lugar] = (latitud, longitud);
        }

        public void EliminarUbicacion(string lugar)
        {
            if (ubicaciones.ContainsKey(lugar))
            {
                ubicaciones.Remove(lugar);
            }
        }

        public Dictionary<string, (double Latitud, double Longitud)> Ubicaciones
        {
            get { return ubicaciones; }
        }
    }
}
