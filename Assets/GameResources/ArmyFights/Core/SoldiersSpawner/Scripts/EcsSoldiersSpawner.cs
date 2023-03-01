namespace Plugins.ArmyFights.Core.SoldiersSpawner.Scripts
{
    using System.Collections.Generic;
    using Plugins.ArmyFights.Core.Fights.Scripts;
    using Plugins.ArmyFights.Core.Health.Scripts;
    using Plugins.ArmyFights.Core.Team;
    using Plugins.ArmyFights.Example.Scripts;
    using Scellecs.Morpeh;
    using Scellecs.Morpeh.Systems;
    using Unity.IL2CPP.CompilerServices;
    using UnityEngine;

    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
    [CreateAssetMenu(menuName = "ECS/Initializers/" + nameof(EcsSoldiersSpawner))]
    public sealed class EcsSoldiersSpawner : Initializer
    {
        [SerializeField]
        private GameObject soldierPrefab;

        public override void OnAwake()
        {
            var containerFilter = World.Filter.With<EcsSoldierContainerComponent>();

            var container = containerFilter.First().GetComponent<EcsSoldierContainerComponent>();
            
            var teamsFilter = World.Filter.With<EcsTeamSpawnSpotComponent>();
            
            Spawn(teamsFilter, container);
        }

        private void Spawn(Filter teamsFilter, EcsSoldierContainerComponent container)
        {
            foreach (var entity in teamsFilter)
            {
                var team = entity.GetComponent<EcsTeamSpawnSpotComponent>();

                var positions = GetPositions(team);

                foreach (var position in positions)
                {
                    CreateSoldier
                    (
                        container.transform, 
                        position,
                        team.transform.rotation,
                        team.team.Side,
                        team.team.Color
                    );
                }
            }
        }

        private static List<Vector3> GetPositions(EcsTeamSpawnSpotComponent team)
        {
            var positions = new List<Vector3>();

            var xDistance = (team.RightFrontLocalPosition.x - team.LeftBackLocalPosition.x);
            var xOffset = (xDistance % team.soldierSpawnSpace.x) / 2;
            
            var yDistance = (team.RightFrontLocalPosition.y - team.LeftBackLocalPosition.y);
            var yOffset = (yDistance % team.soldierSpawnSpace.y) / 2;
            
            for
            (
                var i = team.LeftBackLocalPosition.z + yOffset + team.soldierSpawnSpace.y / 2;
                i < team.RightFrontLocalPosition.z - team.soldierSpawnSpace.y / 2;
                i += team.soldierSpawnSpace.y
            )
            {
                for
                (
                    var j = team.LeftBackLocalPosition.x + xOffset + team.soldierSpawnSpace.x / 2;
                    j < team.RightFrontLocalPosition.x - team.soldierSpawnSpace.x / 2;
                    j += team.soldierSpawnSpace.x
                )
                {
                    var localPosition = new Vector3(j, 0, i);

                    var position = team.transform.TransformPoint(localPosition);

                    positions.Add(position);
                }
            }

            return positions;
        }

        public override void Dispose() 
        {
            
        }

        private void CreateSoldier
        (
            Transform container, 
            Vector3 position, 
            Quaternion rotation,
            bool side,
            Color color
        )
        {
            var soldier = Instantiate(soldierPrefab, position, rotation, container);

            if (soldier.TryGetComponent(out EcsHealthProvider healthProvider))
            {
                ref var healthComponent = ref healthProvider.Stash.Get(healthProvider.Entity);
                healthComponent.HealthPoints = healthComponent.maxHealthPoints;
            }
            
            if (soldier.TryGetComponent(out EcsFightableProvider fightableProvider))
            {
                ref var fightableComponent = ref fightableProvider.Stash.Get(fightableProvider.Entity);
                fightableComponent.Side = side;
            }

            if (soldier.TryGetComponent(out EcsColorControllerProvider colorControllerProvider))
            {
                var colorControllerComponent = colorControllerProvider.Stash.Get(colorControllerProvider.Entity);

                colorControllerComponent.meshRenderer.material.color = color;
            }
        }
    }
}