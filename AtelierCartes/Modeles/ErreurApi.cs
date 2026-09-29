using Newtonsoft.Json;

*using System;
using System.Collections.Generic;
using System.Text;

namespace AtelierCartes.Modeles
{
    internal class ErreurApi
    {
        #region Attributs
        #endregion

        #region Constructeurs
        #endregion

        #region Proprietes
        [JsonProperty("message")]
        public string Message { get; set; } = "Une erreur est survenue.";
        #endregion

        #region Methodes
        #endregion
    }
}
