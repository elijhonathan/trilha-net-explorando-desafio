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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido OK
            // *IMPLEMENTE AQUI* OK
            if ( Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido OK
                // *IMPLEMENTE AQUI* OK
                throw new InvalidOperationException("A capacidade não é suficiente para acomodar todos os hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes) OK
            // *IMPLEMENTE AQUI* OK
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária OK
            // Cálculo: DiasReservados X Suite.ValorDiaria OK
            // *IMPLEMENTE AQUI*
            decimal valor =  DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10% OK
            // *IMPLEMENTE AQUI* OK
            if (DiasReservados >= 10)
            {
                valor = valor - (valor * 0.10M);
            }

            return valor;
        }
    }
}
