using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;

namespace AtelierCartes.Modeles
{
    internal class Carte
    {
        #region Attributs
        #endregion
        #region Constructeurs

        #endregion
        #region Propriétés
        using Newtonsoft.Json;

namespace AtelierCartes.Modeles
    {
        public class Carte
        {
            #region Attributs
            #endregion

            #region Constructeurs
            #endregion

            #region Proprietes
            [JsonProperty("id")]
            public string Identifiant { get; set; } = string.Empty;

            [JsonProperty("brand")]
            public string Marque { get; set; } = string.Empty;

            [JsonProperty("model")]
            public string Modele { get; set; } = string.Empty;

            [JsonProperty("variant")]
            public string Variante { get; set; } = string.Empty;
            #endregion

            #region Methodes
            #endregion
        }
    }
    #region Méthodes
    #endregion
}
}
