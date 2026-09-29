using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierCartes.Modeles
{
    internal class DemandeCreationOffre
    {
        #region Attributs
        #endregion

        #region Constructeurs
        #endregion

        #region Proprietes
        [JsonProperty("copyId")]
        public string IdentifiantExemplaire { get; set; } = string.Empty;

        [JsonProperty("price")]
        public decimal Prix { get; set; } = 0;
        #endregion

        #region Methodes
        #endregion
    }
}
