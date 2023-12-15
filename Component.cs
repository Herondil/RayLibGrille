using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayLibGrille
{

    //base des components
    //équivalent de MonoBehaviour ?
    internal class Component
    {
        //référence au gameobject ?
        public string name;

        //lien vers un GameObject
        public GameObject gameObject { get; private set; }

        public Component(string name, GameObject gameObject)
        {
            this.name = name;
            this.gameObject = gameObject;
        }

        public void Update()
        {

        }
    }
}
