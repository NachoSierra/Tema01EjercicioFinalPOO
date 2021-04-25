using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Tema01EjercicioFinalPOO.BL;
using Tema01EjercicioFinalPOO.BL.Enums;

namespace Tema01EjercicioFinalPOO.DL
{
    public class RepositorioDeTriangulosEquilateros
    {
        public List<TrianguloEquilatero> Triangulos { get; set; } = new List<TrianguloEquilatero>();
        private readonly string _archivo = Environment.CurrentDirectory + "\\TriangulosEquilateros.txt";
        private readonly string _archivoBak = Environment.CurrentDirectory + "\\TriangulosEquilateros.bak";

        public RepositorioDeTriangulosEquilateros()
        {
            LeerDatosDelArchivo();
        }

        private void LeerDatosDelArchivo()
        {
            StreamReader lector = new StreamReader(_archivo);
            while (!lector.EndOfStream)
            {
                string linea = lector.ReadLine();
                TrianguloEquilatero trianguloEquilatero = ConstruirTrianguloEquilatero(linea);
                Triangulos.Add(trianguloEquilatero);
            }
            lector.Close();
        }

        private TrianguloEquilatero ConstruirTrianguloEquilatero(string linea)
        {
            var campos = linea.Split(';');
            return new TrianguloEquilatero
            {
                Lado = double.Parse(campos[0]),
                Borde = (Borde)byte.Parse(campos[1])
            };
        }

        public void Agregar(TrianguloEquilatero trianguloequilatero)
        {
            Triangulos.Add(trianguloequilatero);
            GuardarRegistro(trianguloequilatero);
        }

        private void GuardarRegistro(TrianguloEquilatero trianguloequilatero)
        {
            StreamWriter escritor = new StreamWriter(_archivo, true);
            string linea = ConstruirLinea(trianguloequilatero);
            escritor.WriteLine(linea);
            escritor.Close();
        }

        private string ConstruirLinea(TrianguloEquilatero trianguloequilatero)
        {
            return $"{trianguloequilatero.Lado};{trianguloequilatero.Borde.GetHashCode()}";
        }

        public void Borrar(TrianguloEquilatero trianguloequilatero)
        {
            Triangulos.Remove(trianguloequilatero);
            BorrarRegistroDelArchivo(trianguloequilatero);
        }

        private void BorrarRegistroDelArchivo(TrianguloEquilatero trianguloequilatero)
        {
            StreamReader lector = new StreamReader(_archivo);
            StreamWriter escritor = new StreamWriter(_archivoBak);
            while (!lector.EndOfStream)
            {
                string linea = lector.ReadLine();
                TrianguloEquilatero trianguloEnArchivo = ConstruirTrianguloEquilatero(linea);
                if (!trianguloEnArchivo.Equals(trianguloequilatero))
                {
                    escritor.WriteLine(linea);
                }
            }
            lector.Close();
            escritor.Close();
            File.Delete(_archivo);
            File.Move(_archivoBak, _archivo);
        }

        public void Editar(TrianguloEquilatero trianguloequilateroEditado, TrianguloEquilatero trianguloequilateroABuscar)
        {
            StreamReader lector = new StreamReader(_archivo);
            StreamWriter escritor = new StreamWriter(_archivoBak);
            while (!lector.EndOfStream)
            {
                string linea = lector.ReadLine();
                TrianguloEquilatero trianguloEnArchivo = ConstruirTrianguloEquilatero(linea);
                if (trianguloEnArchivo.Equals(trianguloequilateroABuscar))
                {
                    linea = ConstruirLinea(trianguloequilateroEditado);
                }
                escritor.WriteLine(linea);
            }
            lector.Close();
            escritor.Close();
            File.Delete(_archivo);
            File.Move(_archivoBak, _archivo);
        }
        public int GetCantidad()
        {
            return Triangulos.Count;
        }
        public List<TrianguloEquilatero> GetLista()
        {
            return Triangulos;
        }
        public TrianguloEquilatero GetTriangulo(int posicion)
        {
            return Triangulos[posicion];
        }

        public List<TrianguloEquilatero> Filtrar(Borde linea)
        {
            return Triangulos.Where(t => t.Borde == linea).ToList();
        }

        public List<TrianguloEquilatero> OrdenarDeMenoraMayor()
        {
            return Triangulos.OrderBy(t => t.Borde).ThenBy(t => t.Lado).ToList();
        }

        public List<TrianguloEquilatero> OrdenarDeMayoraMenor()
        {
            return Triangulos.OrderBy(t => t.Borde).ThenByDescending(t => t.Lado).ToList();
        }
    }
}
