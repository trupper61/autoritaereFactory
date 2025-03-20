using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using autoritaereFactory.setup;

namespace autoritaereFactory.world
{
    internal class Build_Modus
    {
        private bool IsbuildModusOn;
        private Building SelectedBuilding;
        private List<Building> AllBuildings;
        private List<Building> Availablebuilding_objects;
        private WorldMap WorldMap;
        public Build_Modus()
        {
            
        }
        /// <summary>
        /// places the building within the chunk
        /// </summary>
        public void PlaceObject(Building b,int x, int y)//x and y are positions of where the player wants to place the object
        {
           if(BuildingConditions()==true)
            {
                WorldMap.AddEntityAt(b, x, y);
            }
        }
        /// <summary>
        /// Check position of building of collision with other already existing buildings and other objects
        /// </summary>
        public bool BuildingConditions()
        {
            if (IsbuildModusOn) { }
            return false;       
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="b"></param>
        public void DeleteBuilding(Building b)
        {
            if (IsbuildModusOn)
            {
                //
                WorldMap.RemoveEntity(b);
            }
        }
        /// <summary>
        /// Checks If the building is available
        /// Available means: the user has enaough resources 
        /// for later...User has all resorces
        /// </summary>
        public void IsBuildingAvailable()
        {
            
        }

    }
}
