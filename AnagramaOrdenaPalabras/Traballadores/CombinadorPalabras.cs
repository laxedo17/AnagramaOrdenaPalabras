using AnagramaOrdenaPalabras.Datos;

using System;
using System.Collections.Generic;
using System.Text;

namespace AnagramaOrdenaPalabras.Traballadores
{
    public class CombinadorPalabras
    {
        /// <summary>
        /// Toma duas listas de palabras, unha aleatoria de usuario e outras da lista para facer anagramas e comparaas para ver se atopa posibles coincidencias
        /// </summary>
        /// <param name="palabrasAleatorias"></param>
        /// <param name="anagramas"></param>
        /// <returns></returns>
        public List<PalabraCoincidente> Coincide(string[] palabrasAleatorias, string[] anagramas)
        {
            var palabrasCoincidentes = new List<PalabraCoincidente>();

            foreach (var palabraAleatoria in palabrasAleatorias)
            {
                foreach (var anagrama in anagramas)
                {
                    if(palabraAleatoria.Equals(anagrama, StringComparison.OrdinalIgnoreCase))
                    {
                        palabrasCoincidentes.Add(ConstruePalabraEquivalente(palabraAleatoria, anagrama));
                    }
                    else
                    {
                        var arrayAleatorias = palabraAleatoria.ToCharArray();
                        var arrayAnagramas = anagrama.ToCharArray();

                        Array.Sort(arrayAleatorias);
                        Array.Sort(arrayAnagramas);

                        var aleatoriaOrdenada = new string(arrayAleatorias);
                        var anagramaOrdenado = new string(arrayAnagramas);

                        if(aleatoriaOrdenada.Equals(anagramaOrdenado, StringComparison.OrdinalIgnoreCase))
                        {
                            palabrasCoincidentes.Add(ConstruePalabraEquivalente(palabraAleatoria, anagrama));
                        }
                    }
                }
            }

            return palabrasCoincidentes;
        }

        private PalabraCoincidente ConstruePalabraEquivalente(string anagrama, string palabra)
        {
            PalabraCoincidente palabraCoincidente = new PalabraCoincidente
            {
                PalabraAComparar = anagrama,
                Anagrama = palabra
            };

            return palabraCoincidente;
        }
    }
}
