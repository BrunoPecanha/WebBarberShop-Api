﻿using Newtonsoft.Json;

namespace PecanhaBruno.WebBarberShop.CrossCutting.EntryContainers
{
    public class DefaultOutPutContainer
    {
        /// <summary>
        /// Id da empresa.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }
        /// <summary>
        /// Objeto de erro para retorno.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool Valid { get; set; }
        /// <summary>
        /// Messagem Padrão de saída
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }
        /// <summary>
        /// Objeto de saída
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object Log { get; set; }
    }     
}