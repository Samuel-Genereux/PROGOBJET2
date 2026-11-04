using System;
using System.Collections.Generic;
using System.Text;

namespace Commandes.Presentation
{
    public  class AbonnementCommande : IDisposable
    {
        private List<IObservateurCommande> m_observateurs;
        private IObservateurCommande m_observateur;

        public AbonnementCommande(List<IObservateurCommande> observateurs,IObservateurCommande observateur)
        {
            m_observateurs = observateurs;
            m_observateur = observateur;
        }

        public void Dispose()
        {
            if (m_observateurs is not null)
            {
                int index = m_observateurs.FindIndex(
                    item => ReferenceEquals(item, m_observateur));
                if (index >= 0)
                {
                    m_observateurs.RemoveAt(index);
                }

                m_observateurs = null;
                m_observateur = null;
            }
        }
    }
}
