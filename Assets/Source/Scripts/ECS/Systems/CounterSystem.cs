using Leopotam.Ecs;
using UnityEngine;

namespace Ecs
{
    sealed class CounterSystem : IEcsRunSystem
    {
        private readonly EcsFilter<CounterComponent> _filter = null;
        
        public void Run()
        {
            foreach (var i in _filter)
            {
                ref var counterComponent = ref _filter.Get1(i);

                counterComponent.count++;
                Debug.Log(counterComponent.count);

            }
        }
    }
}
