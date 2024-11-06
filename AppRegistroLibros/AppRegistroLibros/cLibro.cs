using System;
using System.Collections.Generic;

namespace RegistroDeLibros
{
    class cLibro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public cEstadoLibro Estado { get; set; }

        public cLibro(string titulo, string autor, cEstadoLibro estado)
        {
            Titulo = titulo;
            Autor = autor;
            Estado = estado;
        }

        public override string ToString()
        {
            return $"{Titulo} de {Autor} - {Estado}";
        }
    }
}
