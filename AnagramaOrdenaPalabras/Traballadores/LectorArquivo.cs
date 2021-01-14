using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AnagramaOrdenaPalabras.Traballadores
{
    public class LectorArquivo
    {
        public string[] Leer(string arquivoConPalabras)
        {
            string[] contidoArquivo; //se contidoArquivo falla no try situamolo aqui para que devolva algo anque este vacio
            try
            {
                contidoArquivo = File.ReadAllLines(arquivoConPalabras);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);//facemos un wrap -envolver- a Exception nunha nova excepcion con mensaxe
            }


            return contidoArquivo;
        }
    }
}
