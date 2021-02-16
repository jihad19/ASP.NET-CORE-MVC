using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiants.Models.Repozitories
{
    public interface IStoreEtudiants<TEntity>
    {
        IList<TEntity> List();

        public TEntity Rechercher(int id);
        void Ajouter(TEntity entity);
        void Modifier(int id, TEntity entity);
        void Suprimer(int id);
        void Add(Etudiants etudiants);
        object List(int id);
    }
}
