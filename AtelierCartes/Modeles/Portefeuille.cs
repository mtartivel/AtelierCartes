using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AtelierCartes.Modeles
{
    internal class Portefeuille
    {
        #region Attributs
        #endregion
        #region Constructeurs
        #endregion
        #region Propriétés
        [JsonProperty("positions")]
        public ObservableCollection<CartePossedee> CartesPossedees { get; set; } = new ObservableCollection<CartePossedee>();
        #endregion
        #region Méthodes
        #endregion
    }
}
