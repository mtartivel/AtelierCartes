using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierCartes.Modeles
{
    internal class ReponseConnexion
    {
        #region Attributs
        #endregion

        #region Constructeurs
        #endregion

        #region Proprietes
        [JsonProperty("accessToken")]
        public string JetonAcces { get; set; } = string.Empty;
        #endregion

        #region Methodes
        #endregion
    }
}
