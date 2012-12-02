namespace Eratostenes
{
    class Numeros
    {
        public Numeros(int numero, bool esPrimo)
        {
            this.Numero = numero;
            this.EsPrimo = esPrimo;
        }
        public int Numero { get; set; }
        public bool EsPrimo { get; set; }

        internal void EsMultiplo(int primo)
        {
            if (this.EsPrimo)
            {
                this.EsPrimo = !((this.Numero % primo) == 0);
            }
        }
    }
}