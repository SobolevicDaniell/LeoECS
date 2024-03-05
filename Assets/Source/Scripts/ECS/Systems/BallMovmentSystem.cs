using Leopotam.Ecs;
using UnityEngine;

namespace Ecs
{
    sealed class BallMovmentSystem : IEcsRunSystem
    {
        private readonly EcsFilter<BallMovmentComponent> _filter = null;
        
        public void Run()
        {
            foreach (var i in _filter)
            {
                ref var ballMovmentComponent = ref _filter.Get1(i);

                ballMovmentComponent.ballTransform.transform.Translate(Vector3.forward * ballMovmentComponent.speed * Time.deltaTime);
                
                if (ballMovmentComponent.ballTransform.transform.position.x >= ballMovmentComponent.amplitude)
                {
                    ballMovmentComponent.movingRight = false;
                }
                else if (ballMovmentComponent.ballTransform.transform.position.x <= -ballMovmentComponent.amplitude)
                {
                    ballMovmentComponent.movingRight = true;
                }

                float direction = ballMovmentComponent.movingRight ? 1f : -1f;
                ballMovmentComponent.ballTransform.transform.Translate(Vector3.right * direction * ballMovmentComponent.amplitudeSpeed * Time.deltaTime);
            }
        }
    }
}