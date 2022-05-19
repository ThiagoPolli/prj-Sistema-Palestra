using System;
using System.Collections.Generic;

namespace SistemaPalestra.Domain
{
    public class Evento
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public DateTime? DateEnvento { get; set; }
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string ImageURL { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        
        //pode ter varios Lotes coloca enumerable
        public IEnumerable<Lote> Lotes { get; set; }
        public IEnumerable<RedesSocial> RedesSociais { get; set; }
        public IEnumerable<PalestranteEvento> PalestranteEventos { get; set; }
    }
}