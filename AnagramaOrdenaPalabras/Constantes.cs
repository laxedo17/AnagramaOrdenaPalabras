using System;
using System.Collections.Generic;
using System.Text;

namespace AnagramaOrdenaPalabras
{
    public class Constantes
    {
        public const string OpcionInicial = "Entra a(s) palabra(s) para facer anagramas manualmente ou como un ficheiro: F- ficheiro / M - manual";
        public const string Continuar = "Queres continuar facendo anagramas? S / N (S e Si, N e Non)";

        public const string RutaArquivo = "Entra a ruta completa incluido o nome do arquivo: ";
        public const string EntradaManual = "Entra palabra(s) manualmente (separadas por comas si son multiples)";
        public const string OpcionErro = "Esa opcion non existe no programa";

        public const string PalabrasNonCargan = "As palabras para facer anagramas non se poideron agregar porque houbo un erro";
        public const string ErroFinPrograma = "O programa pecharase, debido a un erro.";

        public const string HaiEquivalencia = "Equivalencia atopada en {0}: {1}";
        public const string SenEquivalencia = "Non se atoparon coincidencias.";

        public const string Si = "S";
        public const string Non = "N";
        public const string Ficheiro = "F";
        public const string Manual = "M";

        public const string NomeArquivo = "listapalabras.txt";

        public const char SeparaPorComas = ',';
    }
}
