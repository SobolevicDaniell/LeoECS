using System;
using UnityEngine;

namespace Ecs
{
    [Serializable]
    public struct InitComponent
    {
        public int count;
        public GameObject prefab;
    }
}