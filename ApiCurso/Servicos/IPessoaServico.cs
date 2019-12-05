using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCurso.Model;

namespace ApiCurso.Servicos.Implementacao
{
    public interface IPessoaServico
    {
        Pessoa Criar(Pessoa pessoa);
        Pessoa ProcurarPorId(long id);
        List<Pessoa> Procurar();
        Pessoa Atualizar(Pessoa pessoa);
        void Apagar(long id);

    }
}
