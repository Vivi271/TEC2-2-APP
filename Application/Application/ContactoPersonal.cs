namespace Application
{
    public class ContactoPersonal
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }

        public ContactoPersonal(string nombre, string telefono, string correoElectronico)
        {
            Nombre = nombre;
            Telefono = telefono;
            CorreoElectronico = correoElectronico;
        }
    }
}
