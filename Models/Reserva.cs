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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTADO*
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTADO*
                throw new Exception("Não é possível cadastrar mais hospedes. Além da capacidade.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTADO*
            int quantidadeHospedes = Hospedes.Count();
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // *IMPLEMENTADO*
            decimal calculo = DiasReservados * Suite.ValorDiaria;
            decimal valor = calculo;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTADO*
            if (DiasReservados >= 10)
            {
                decimal desconto = Suite.ValorDiaria - 10/100 * Suite.ValorDiaria;
                decimal calculoComDesconto = calculo - desconto;
                valor = calculoComDesconto;
            }

            return valor;
        }
    }
}