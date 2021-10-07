using System;

namespace apiaeropuerto
{
    public class WeatherForecast
    {
        public DateTime fechavuelo { get; set; }

        public int cantidadPasajeros { get; set; }

        public int duracionVuelo => 32 + (int)(TemperatureC / 0.5556);

        public string destino { get; set; }
    }
}
