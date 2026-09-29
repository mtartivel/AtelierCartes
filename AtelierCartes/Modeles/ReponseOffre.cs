using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AtelierCartes.Modeles
{
    internal class ReponseOffre
    {
        #region Attributs
        #endregion
        #region Constructeurs
        #endregion
        #region Propriétés
        [JsonProperty("items")]
        public ObservableCollection<Offre> Offres { get; set; } = new ObservableCollection<Offre>();
        #endregion
        #region Méthodes
        #endregion
    }
}
}
