using System;
using Tema01EjercicioFinalPOO.BL.Enums;

namespace Tema01EjercicioFinalPOO.BL
{
    public class TrianguloEquilatero:ICloneable
    {
        public double Lado { get; set; }
        public Borde Borde { get; set; }
        public TrianguloEquilatero()
        {

        }
        public TrianguloEquilatero(double lados, Borde borde)
        {
            Lado = lados;
            Borde = borde;
        }
        public double GetPerimetro()
        {
            return Lado * 3;
        }
        public double GetSuperficie()
        {
            return Math.Sqrt(3) / 4 * Lado;
        }
        public bool Validar()
        {
            bool esValido = true;
            switch (Borde)
            {
                case Borde.Linea:
                    if (Lado > 20 || Lado < 1)
                    {
                        esValido = false;
                    }
                    break;
                case Borde.Puntos:
                    if (Lado > 20 || Lado < 1)
                    {
                        esValido = false;
                    }
                    break;
                case Borde.Rayas:
                    if (Lado > 20 || Lado < 1)
                    {
                        esValido = false;
                    }
                    break;
            }
            return esValido;
        }
        public override bool Equals(object obj)
        {
            if (obj==null||!(obj is TrianguloEquilatero))
            {
                return false;
            }
            return this.Lado == ((TrianguloEquilatero)obj).Lado && this.Borde == ((TrianguloEquilatero)obj).Borde;
        }
        public override int GetHashCode()
        {
            return this.Lado.GetHashCode() + this.Borde.GetHashCode();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
     
