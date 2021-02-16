using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionEtudiants.Models.Repozitories
{
    public class EtudiantsRepository : IStoreEtudiants<Etudiants>
    {
       List<Etudiants> etudiant;
        public EtudiantsRepository()
        {
            etudiant = new List<Etudiants>()
            {
                new Etudiants
                {
                    Id=1, Nom = "Khadija", Prenom= "Nejmi", Cin= "ZA123456", Adress= "Alhay almohamadi" 
                },
                new Etudiants
                {
                    Id=2, Nom = "Noura", Prenom= "Nejdi", Cin= "SD125678", Adress= "Smara"
                },
                new Etudiants
                {
                    Id=3, Nom = "Mariam", Prenom= "Alkhaldi", Cin= "DF156789", Adress= "Stinaat"
                }
            };
        }

        public void Add(Etudiants etudiants)
        {
            throw new NotImplementedException();
        }

        public void Ajouter(Etudiants entity)
        {
            etudiant.Add(entity);
        }

        public IList<Etudiants> List()
        {
            return etudiant;
        }

        public object List(int id)
        {
            throw new NotImplementedException();
        }

        public void Modifier(int id, Etudiants newetudiant)
        {
            var etud = Rechercher(id);
            etud.Nom = newetudiant.Nom;
            etud.Prenom = newetudiant.Prenom;
            etud.Cin = newetudiant.Cin;
            etud.Adress = newetudiant.Adress;
        }

        public Etudiants Rechercher(int id)
        {
            var etud = etudiant.SingleOrDefault(etd => etd.Id == id);
            return etud;
        }

        public void Suprimer(int id)
        {
            var etud = Rechercher(id);
            etudiant.Remove(etud);
        }
    }
}
