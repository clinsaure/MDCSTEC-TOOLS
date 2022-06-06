namespace MdcstecTools.Models
{
    public class ParameterDto
    {
        public string? BlockName { get; set; }
        public string? ParamName { get; set; }
        public string? ParamValue { get; set; }
        //public Parameters? Parameters { get; set; }
    }

    public class ParametersDto
    {
        public string? BlockName { get; set; }
        public Parameters? Parameters { get; set; }
    }

    public class ConnectionDto
    {
        public string? BlockName { get; set; }
        public int? BlockId { get; set; }

        public string? InputEnd { get; set; }

        public string? OutputEnd { get; set; }

        public string? ConnectionForm { get; set; }

        public string? GraphicalForm { get; set; }

        public List<Vertex>? Vertex { get; set; }
    }

    public class ConnectionsDto
    {
        public string? BlockName { get; set; }
        public Connections? Connections { get; set; }
    }
}
