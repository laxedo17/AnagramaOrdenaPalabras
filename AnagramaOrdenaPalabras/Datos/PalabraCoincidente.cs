namespace AnagramaOrdenaPalabras.Datos
{
    /// <summary>
    /// Usamos unha struct en vez dunha clase. Struct e unha value type, mais rapida que unha clase tipica con obxetos, xa que traballa no Stack, mais accesible para a CPU e lixeira en memoria
    /// </summary>
    public struct PalabraCoincidente
    {
        public string PalabraAComparar { get; set; }
        public string Anagrama { get; set; }
    }
}
