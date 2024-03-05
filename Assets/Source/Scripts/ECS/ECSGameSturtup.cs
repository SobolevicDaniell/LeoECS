using System;
using System.Collections;
using System.Collections.Generic;
using Leopotam.Ecs;
using UnityEngine;
using Voody.UniLeo;

namespace Ecs
{
    public class ECSGameSturtup : MonoBehaviour
    {
        private EcsWorld _world;
        private EcsSystems _systems;
    
        private void Start()
        {
            _world = new EcsWorld();
            _systems = new EcsSystems(_world);

            _systems.ConvertScene();
            
            AddSystems();
            _systems.Add(new InitSystem());
        
            _systems.Init();
            _systems.Run();
        }

        private void Update()
        {
            _systems.Run();
        }


        private void AddSystems()
        {
            _systems
                .Add(new CounterSystem())
                .Add(new BallMovmentSystem());
        }
        
        

        private void OnDestroy()
        {
            _systems?.Destroy();
            _world?.Destroy();
        }
    }
}
