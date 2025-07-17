using Interface;

public class BeCancha : IEntity
{
    public BeCancha(string pNombre, decimal pPrecio, int pCapacidad, string pEstado, string pObservaciones)
    {
        Nombre = pNombre;
        Precio = pPrecio;
        Capacidad = pCapacidad;
        Estado = pEstado;
        Observaciones = pObservaciones;
    }
    public BeCancha(object[] array)
    {
        id = array[0].ToString();
        Nombre = array[1].ToString();
        Precio = decimal.Parse(array[2].ToString());
        Capacidad = int.Parse(array[3].ToString());
        Estado = array[4].ToString();
        Observaciones = array[5].ToString();
    }
    public BeCancha() { }
    public string id { get; set; }
    public string Nombre { get; set; }
    public decimal Precio { get; set; }   
    public int Capacidad { get; set; }
    public string Estado { get; set; }
    public string Observaciones { get; set; }
}
