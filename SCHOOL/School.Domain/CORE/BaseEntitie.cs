using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.CORE
{
    public abstract class BaseEntitie
    {
        public DateTime FechaRegistro { get; set; }
        public int IdUsuarioCreacion { get; set; }
        public DateTime FechaMod { get; set; }
        public int IdUsarioMod {  get; set; }
        public int IdUsuarioEliminacion { get; set; }
        public DateTime FechaElimino {  get; set; }
        public bool Eliminado { get; set; }


        public virtual void Prueba()
        {
            Console.WriteLine("Im a class to check the heritance.");
        }
    }
}
