using Leopotam.Ecs;
using UnityEngine;

namespace Ecs
{
    sealed class InitSystem : IEcsInitSystem
    {
        private readonly EcsWorld _world = null;

        private readonly EcsFilter<InitComponent> _filter = null;
        
        public void Init()
        {
            foreach (var i in _filter)
            {
                ref var initComponent = ref _filter.Get1(i);

                for (int j = 0; j < initComponent.count; j++)
                {
                    Vector3 randomPosition = new Vector3(
                        Random.Range(-100, 100),
                        Random.Range(-100, 100),
                        0
                    );
                    
                    Object.Instantiate(initComponent.prefab, randomPosition, Quaternion.identity);
                }
            }
        }
    }
}