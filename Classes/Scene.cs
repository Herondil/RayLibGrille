using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Le programme n'a toujours qu'une seule en cours
namespace RayLibGrille
{
    internal class Scene
    {
        //les gameobejcts de la scène
        private List<GameObject> GameObjects;

        public string name;

        //Constructeur de scène
        public Scene(string name)
        {
            GameObjects = new List<GameObject>();
            this.name = name;
        }


        public void Add(GameObject _g)
        {
            GameObjects.Add(_g);
        }

        //mise à jour des gameobjects
        public void Update()
        {
            //update de tous les GameObjects
            foreach (GameObject _g in GameObjects)
            {
                _g.Update();
            }
        }

        public void Render()
        {
            //ici pour dessiner la scène
        }
    }
}
