using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLoreal.Models
{
    public class CourseModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Detail { get; set; }
        public string Image { get; set; }

        public bool IsFree => Price == null;
        public bool IsNotFree => Price != null;
        public double? Price { get; set; }
        public string cPrice => $"$ {Price}";
        public int NroClases { get; set; }
        public int HrsDuracion { get; set; }
        public int CupoMaximo { get; set; }
        public int CupoDisponible { get; set; }
    }
}
