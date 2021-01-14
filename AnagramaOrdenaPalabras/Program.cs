using AnagramaOrdenaPalabras.Datos;
using AnagramaOrdenaPalabras.Traballadores;
using static AnagramaOrdenaPalabras.Constantes;

using System;
using System.Collections.Generic;
using System.Linq;

using static System.Console;

namespace AnagramaOrdenaPalabras
{
    class Program
    {
        private static readonly LectorArquivo _lectorArquivo = new LectorArquivo();//readonly non e static de por si o contrario que const, pero permite usar obxetos e non tipos predefinidos de C# solamente, por iso non escribimos const para FileReader nin para CombinadorPalabras, que son obxetos e non tipos de C# (string, int, double, float, etc)
        public static readonly CombinadorPalabras _comparadorPalabras = new CombinadorPalabras();
        //private const string arquivoConPalabras = "listapalabras.txt";//const e estatico de por si, non hai que escribir static. Pero SOLO funciona con tipos predefinidos de C# non con obxetos e clases
        static void Main()
        {
            try
            {
                bool continuaOrdenando = true;

                do
                {

                    WriteLine(OpcionInicial);
                    var opcion = ReadLine() ?? string.Empty;

                    switch (opcion.ToUpper())
                    {
                        case Ficheiro:
                            WriteLine(RutaArquivo);
                            AnagramasArquivo();
                            break;
                        case Manual:
                            WriteLine(EntradaManual);
                            AnagramasManuales();
                            break;
                        default:
                            WriteLine(OpcionErro);
                            break;
                    }

                    var decisionContinuar = string.Empty;
                    do
                    {
                        WriteLine(Continuar);
                        decisionContinuar = (ReadLine() ?? string.Empty);
                    } while 
                    (
                    !decisionContinuar.Equals(Si, StringComparison.OrdinalIgnoreCase) &&
                    !decisionContinuar.Equals(Non, StringComparison.OrdinalIgnoreCase)
                    );

                    continuaOrdenando = decisionContinuar.Equals(Si, StringComparison.OrdinalIgnoreCase); //se a decision de continuar co anagrama e Si, continuarOrdenando sigue en true, co cal non sae do bucle. Se pulsas N ou outra tecla, vai sair do bucle xa que continuaOrdenando sera falso
                } while (continuaOrdenando);
            }
            catch (Exception ex)
            {
                WriteLine(PalabrasNonCargan + ex.Message);
            }

        }

        private static void AnagramasManuales()
        {
            var entradaManual = ReadLine() ?? String.Empty;
            string[] senAnagrama = entradaManual.Split(SeparaPorComas);
            MostrarAnagramasEquivalentes(senAnagrama);
        }

        private static void AnagramasArquivo()
        {
            try
            {
                var nomeArquivo = ReadLine() ?? String.Empty;
                string[] senAnagrama = _lectorArquivo.Leer(nomeArquivo);
                MostrarAnagramasEquivalentes(senAnagrama);
            }
            catch (Exception ex)
            {
                WriteLine(PalabrasNonCargan + ex.Message);
            }

        }

        /// <summary>
        /// Ordena as palabras para crear os anagramas
        /// </summary>
        /// <param name="palabrasSenAnagrama"></param>
        private static void MostrarAnagramasEquivalentes(string[] palabrasSenAnagrama)
        {
            string[] listaPalabras = _lectorArquivo.Leer(NomeArquivo);

            List<PalabraCoincidente> palabrasEquivalentes = _comparadorPalabras.Coincide(palabrasSenAnagrama, listaPalabras);

            if (palabrasEquivalentes.Any())
            {
                foreach (var palabraEquivalente in palabrasEquivalentes)
                {
                    WriteLine(HaiEquivalencia, palabraEquivalente.PalabraAComparar, palabraEquivalente.Anagrama);
                }
            }
            else
            {
                WriteLine(SenEquivalencia);
            }
        }


    }
}
