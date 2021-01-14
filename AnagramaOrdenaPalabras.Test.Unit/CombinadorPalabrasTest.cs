using AnagramaOrdenaPalabras.Traballadores;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnagramaOrdenaPalabras.Test.Unit
{
    [TestClass]
    public class CombinadorPalabrasTest
    {
        private readonly CombinadorPalabras _combinadorPalabras = new CombinadorPalabras();

        /// <summary>
        /// Testea que se tome a palabra correcta dunha lista de palabras a comparar, creando varias incorrectas e unha correcta que coincida, que e o resultado que esperamos
        /// </summary>
        [TestMethod]
        public void PalabraNonOrdenadaCoincideConPalabraQueLlePasamosNunhaLista()
        {
            string[] anagramas = { "can", "leon", "amor" };
            string[] palabrasDesordenadas = { "roma" };

            var palabrasCoincidentes = _combinadorPalabras.Coincide(palabrasDesordenadas, anagramas);

            Assert.IsTrue(palabrasCoincidentes.Count == 1);//temos que saber que hai unha palabra o menos
            Assert.IsTrue(palabrasCoincidentes[0].PalabraAComparar.Equals("roma")); //esa 1ª palabra miramos se cumple a condicion, por iso o indice [0] (1ª palabra dun array)
            Assert.IsTrue(palabrasCoincidentes[0].Anagrama.Equals("amor"));//se a palabra que tomou o metodo Coincide foi roma e despois foi amor, enton fixoo ben, xa que son palabras compatibles unha coa outra
        }

        /// <summary>
        /// Testea que se tomen varias palabras correctas de duas listas de palabras con varias palabras a comparar para facer anagramas.
        /// </summary>
        [TestMethod]
        public void PalabraNonOrdenadaCoincideConPalabrasQueLlePasamosNunhaLista()
        {
            string[] anagramas = { "can", "leon", "amor", "lista" };
            string[] palabrasDesordenadas = { "roma", "tilas", "lercha" };

            var palabrasCoincidentes = _combinadorPalabras.Coincide(palabrasDesordenadas, anagramas);

            Assert.IsTrue(palabrasCoincidentes.Count == 2);//temos que saber que hai duas palabras coincidentes o menos
            Assert.IsTrue(palabrasCoincidentes[0].PalabraAComparar.Equals("roma")); //esa 1ª palabra miramos se cumple a condicion, por iso o indice [0] (1ª palabra dun array)
            Assert.IsTrue(palabrasCoincidentes[0].Anagrama.Equals("amor"));//se a palabra que tomou o metodo Coincide foi roma e despois foi amor, enton fixoo ben
            Assert.IsTrue(palabrasCoincidentes[1].PalabraAComparar.Equals("tilas")); //coa 2ª palabra miramos se cumple a condicion tamen, por iso o indice [1] (2ª palabra dun array)
            Assert.IsTrue(palabrasCoincidentes[1].Anagrama.Equals("lista"));//se a 2ª palabra que tomou o metodo Coincide foi tilas e despois foi lista, enton fixoo ben
        }
    }
}
