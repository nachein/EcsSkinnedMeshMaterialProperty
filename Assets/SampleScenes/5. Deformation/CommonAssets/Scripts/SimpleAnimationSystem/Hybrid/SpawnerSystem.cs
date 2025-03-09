using Unity.Entities;
using UnityEngine;

namespace SampleScenes._5._Deformation.CommonAssets.Scripts.SimpleAnimationSystem.Hybrid
{
    public partial struct SpawnerSystem : ISystem
    {
        private EntityQuery _spawnerQuery;

        public void OnCreate(ref SystemState state)
        {
            _spawnerQuery = state.GetEntityQuery(typeof(SpawnerComponent));
        }

        public void OnUpdate(ref SystemState state)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var spawner = _spawnerQuery.GetSingleton<SpawnerComponent>();
                var newEntity = state.EntityManager.Instantiate(spawner.Prefab);
            }
        }
    }

    public struct SpawnerComponent : IComponentData
    {
        public Entity Prefab;
    }
}