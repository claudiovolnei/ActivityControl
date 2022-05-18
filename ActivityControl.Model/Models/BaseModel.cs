using System;

namespace ActivityControl.Domain.Models
{
    public class BaseModel
    {
        public string CriadoPor { get; set; } = String.Empty;
        public string AlteradoPor { get; set; } = String.Empty;
        public DateTime CriadoEm { get; set; }
        public DateTime AlteradoEm { get; set; }
    }
}
