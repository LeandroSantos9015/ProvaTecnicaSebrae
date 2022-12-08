﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaTecnicaSebrae.Models
{
    public class EnderecoDTO
    {
        [JsonProperty("cep")]
        public string Cep { get; set; }

        [JsonProperty("logradouro")]

        public string Logradouro { get; set; }
        [JsonProperty("complemento")]

        public string complemento { get; set; }
        [JsonProperty("bairro")]

        public string Bairro { get; set; }
        [JsonProperty("localidade")]

        public string localidade { get; set; }
        [JsonProperty("uf")]

        public string Uf { get; set; }
        [JsonProperty("ibge")]

        public string Ibge { get; set; }
        [JsonProperty("gia")]

        public string Gia { get; set; }
        [JsonProperty("ddd")]

        public string Ddd { get; set; }

        [JsonProperty("siafi")]
        public string Siafi { get; set; }
    }
}