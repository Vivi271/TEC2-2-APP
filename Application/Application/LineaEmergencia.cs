namespace Application
{
    public class LineaEmergencia
    {
        private List<string> numerosEmergencia;

        public LineaEmergencia()
        {
            numerosEmergencia = new List<string>();
 
            numerosEmergencia.Add("911");
            numerosEmergencia.Add("112");
            numerosEmergencia.Add("123");
        }

        public List<string> NumerosEmergencia
        {
            get { return numerosEmergencia; }
        }

        
    }
}
