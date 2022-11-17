namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {        
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("Número de hópedes é supeior que a capacidade esperada");                
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int QuantidadeDeHospedes = Hospedes.Count;
            return QuantidadeDeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valorTotal  = DiasReservados * Suite.ValorDiaria;
            decimal valor = valorTotal;

            if (DiasReservados >= 10)
            {                
               return valorTotal *= 0.9M;
            }

            return valor;
        }
    }
}