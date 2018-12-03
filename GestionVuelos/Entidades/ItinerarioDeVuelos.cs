using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ItinerarioDeVuelos
    {
        private int idvuelo;

    public int Idvuelo
    {
      get { return idvuelo; }
      set { idvuelo = value; }
    }
    private int iditinerario;

    public int Iditinerario
    {
        get { return iditinerario; }
        set { iditinerario = value; }
    }

    private string razonsocial;

    public string Razonsocial
    {
        get { return razonsocial; }
        set { razonsocial = value; }
    }
    private string ciudadorigen;

    public string Ciudadorigen
    {
        get { return ciudadorigen; }
        set { ciudadorigen = value; }
    }
    private string ciudaddestino;

    public string Ciudaddestino
    {
        get { return ciudaddestino; }
        set { ciudaddestino = value; }
    }
    private DateTime fechasalida;

    public DateTime Fechasalida
    {
        get { return fechasalida; }
        set { fechasalida = value; }
    }


    private DateTime fechallegada;

    public DateTime Fechallegada
    {
        get { return fechallegada; }
        set { fechallegada = value; }
    }
    private string horasalida;

    public string Horasalida
    {
        get { return horasalida; }
        set { horasalida = value; }
    }
    private string horallegada;

    public string Horallegada
    {
        get { return horallegada; }
        set { horallegada = value; }
    }
    private int cantsillas;

    public int Cantsillas
    {
        get { return cantsillas; }
        set { cantsillas = value; }
    }
    private int preciovuelo;

    public int Preciovuelo
    {
        get { return preciovuelo; }
        set { preciovuelo = value; }
    }
    }
}
