using senai_void_webApi.Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai_void_webApi.Domains
{
    /// <summary>
    /// Classe que representa a entidade (tabela) de eventos
    /// </summary>
    public partial class Evento
    {
        public Evento()
        {
            Presencas = new HashSet<Presenca>();
        }

        public int IdEvento { get; set; }
        public int? IdTipoEvento { get; set; }
        public int? IdInstituicao { get; set; }

        // Define que o campo é obrigatório
        [Required(ErrorMessage = "Informe o título do evento")]
        public string NomeEvento { get; set; }
        public bool? AcessoLivre { get; set; }

        // Define que o campo é obrigatório
        [Required(ErrorMessage = "Informe a data do evento")]
        public DateTime DataEvento { get; set; }

        // Define que o campo é obrigatório
        [Required(ErrorMessage = "Informe a descrição do evento")]
        public string Descricao { get; set; }

        public virtual Instituico IdInstituicaoNavigation { get; set; }
        public virtual TiposEvento IdTipoEventoNavigation { get; set; }
        public virtual ICollection<Presenca> Presencas { get; set; }
    }
}
