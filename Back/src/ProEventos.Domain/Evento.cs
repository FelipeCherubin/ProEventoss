using System;
using System.Collections.Generic;

namespace ProEventos.Domain
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string Local { get; set; }
        public DateTime? DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string  ImagemURL { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public IEnumerable<Lote> Lote { get; set; }
        public IEnumerable<RedesSociais> RedesSociais { get; set; }
        public IEnumerable<PalestranteEvento> PalestranteEvento { get; set; }

    }
}