using senai_void_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_void_webApi.Interfaces
{
    interface ILocalizacaoRepository
    {
        List<Localizacao> ListarTodas();

        void Cadastrar(Localizacao novaLocalizacao);
    }
}
