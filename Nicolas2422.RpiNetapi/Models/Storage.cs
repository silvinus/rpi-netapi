using System.Drawing;

namespace Nicolas2422.RpiNetapi.Models
{
    public class Storage
    {
        public string Filesystem { get; set; }

        public string Type { get; set; }

        public int Size { get; set; }

        public int Used { get; set; }

        public int Avail { get; set; }

        public decimal Usage { get; set; }

        public string Mounted { get; set; }

        public Storage()
        {
            Filesystem = String.Empty;
            Size = 0;
            Used = 0;
            Avail = 0;
            Type = String.Empty;
            Usage = 0;
            Mounted = String.Empty;
        }
    }
}