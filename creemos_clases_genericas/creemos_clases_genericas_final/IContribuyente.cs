﻿namespace Sample_solution
{
    public interface IContribuyente<T>
    {
        T Referencia {get;set;}
        string Nombre { get; set; }
        string Apellidos { get; set; }

        void PagarImpuestos();
    }
}