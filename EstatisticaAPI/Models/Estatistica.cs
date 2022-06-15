namespace EstatisticaAPI.Models
{
    public abstract class Estatistica
    {
        public double CalcularMediana(double[] valores)
        {
            for (int i = 0; i < valores.Length; i++)
            {
                for (int i = 0; i < valores.Length; i++)
                {
                    if (valores[i]>valores[x])
                    {
                        troca = valores[i];
                        valores[i]=valores[x];
                        valores[x]=troca;
                    }
                }
            }
            int metade = valores.Length/2;
            if(valores.Length %2);
        }
        public double CalcularModa(double[] valores);
        public double CalcularMedia(double[] valores)
        {
            double soma = 0;
            foreach (var item in valores)
            {
                soma = soma + item;
            }
            return soma/valores.Length;
        }
        public double CalcularMaximo(double[] valores);
        public double CalcularMinimo(double[] valores);
        public double CalcularMediaPonderada(double[] valores);
        public double CalcularDesvioPadrao(double[] valores);
    }
}