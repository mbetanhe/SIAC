using System;

namespace SIAC.CORE.Exceptions
{
    /// <summary>
    /// Clase que manejara las excepciones de forma global.
    /// </summary>
    public class GlobalException : Exception
    {
        public string Mensaje { get; }

        public int Codigo { get; set; }

        public GlobalException(string Mensaje) : base(Mensaje)
        {
            this.Mensaje = Mensaje;
        }

        public GlobalException(string Mensaje, int Codigo) : base(Mensaje)
        {
            this.Mensaje = Mensaje;
            this.Codigo = Codigo;
        }

    }
}
