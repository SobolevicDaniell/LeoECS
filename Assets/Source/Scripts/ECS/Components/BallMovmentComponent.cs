using System;
using UnityEngine;

namespace Ecs
{
    [Serializable]
    public struct BallMovmentComponent
    {
        public Transform ballTransform;
        public float speed;
        public float amplitude;
        public float amplitudeSpeed;
        public bool movingRight;
    }
}