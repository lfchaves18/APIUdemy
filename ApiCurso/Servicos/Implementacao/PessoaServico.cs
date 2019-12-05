using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ApiCurso.Model;

namespace ApiCurso.Servicos.Implementacao
{
    public class PessoaServicoImp : IPessoaServico
    {
        private volatile int count;

        public Pessoa Criar(Pessoa pessoa)
        {
            return pessoa;
        }

        public void Apagar(long id)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> Procurar()
        {
            List<Pessoa> listPessoas = new List<Pessoa>();
            for (int i = 0; i < 8; i++)
            {
                Pessoa pessoa = MockPessoa(i);
                listPessoas.Add(pessoa);
            }
            return listPessoas;
        }

        public Pessoa ProcurarPorId(long id)
        {
            return new Pessoa
            {
                Id = IncrementaEPega(),
                PrimeiroNome = "Lucas",
                UltimoNome = "Chaves",
                Endereco = "Sao Paulo - SP",
                Genero = "Masculino"
            };
        }

        public Pessoa Atualizar(Pessoa pessoa)
        {
            return pessoa;
        }

        private Pessoa MockPessoa(int i)
        {
            return new Pessoa
            {
                Id = IncrementaEPega(),
                PrimeiroNome = $"Nome Pessoa {i}",
                UltimoNome = $"Ultimo Nome {i}",
                Endereco = $"Endereco {i}",
                Genero = $"Genero {i}"
            };
        }

        private long IncrementaEPega()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
