using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AtelierCartes.Modeles
{
    internal class Offre
    {
        #region Attributs
        #endregion
        #region Constructeurs
        #endregion
        #region Propriétés
        [JsonProperty("id")]
        public string Identifiant { get; set; } = string.Empty;
        [JsonProperty("copyId")]
        public string IdentifiantExemplaire { get; set; } = string.Empty;

        [JsonProperty("price")]
        public decimal Prix { get; set; } = 0;

        [JsonProperty("status")]
        public string Statut { get; set; } = string.Empty;
        #endregion
    }
}
