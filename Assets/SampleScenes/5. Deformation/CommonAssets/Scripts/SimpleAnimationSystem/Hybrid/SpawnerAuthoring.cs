using Unity.Entities;
using UnityEngine;

namespace SampleScenes._5._Deformation.CommonAssets.Scripts.SimpleAnimationSystem.Hybrid
{
    public class SpawnerAuthoring : MonoBehaviour
    {
        public GameObject Prefab;
        class SpawnerBaker : Baker<SpawnerAuthoring>
        {
            public override void Bake(SpawnerAuthoring authoring)
            {
                var entity = GetEntity(TransformUsageFlags.Dynamic);

                var prefabEntity = GetEntity(authoring.Prefab, TransformUsageFlags.Renderable);

                AddComponent(entity, new SpawnerComponent { Prefab = prefabEntity });
            }
        }
    }
}