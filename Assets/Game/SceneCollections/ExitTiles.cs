using System.Collections.Generic;
using UnityEngine;

namespace Assets.Game.SceneCollections
{
    public class ExitTiles
    {
        public IEnumerable<GameObject> AvailableTiles { get; private set; }

        public ExitTiles()
        {
            AvailableTiles = new[]
            {
                Resources.Load<GameObject>("Prefabs/Exit")
            };
        }
    }
}