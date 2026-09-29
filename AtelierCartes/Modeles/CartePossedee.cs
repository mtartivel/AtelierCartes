using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AtelierCartes.Modeles
{
    internal class CartePossedee
    {
        #region Attributs
        #endregion

        #region Constructeurs
        #endregion

        #region Proprietes
        [JsonProperty("id")]
        public string Identifiant { get; set; } = string.Empty;

        [JsonProperty("card")]
        public Carte Carte { get; set; } = new Carte();

        [JsonProperty("currentValue")]
        public decimal ValeurActuelle { get; set; } = 0;
        #endregion

        #region Methodes
        #endregion
    }
}
