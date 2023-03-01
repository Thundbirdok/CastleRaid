using Scellecs.Morpeh;
using Unity.IL2CPP.CompilerServices;

namespace Plugins.ArmyFights.Core.Movement.Scripts
{
    using System;
    using UnityEngine;

    [Serializable]
    [Il2CppSetOption(Option.NullChecks, false)]
    [Il2CppSetOption(Option.ArrayBoundsChecks, false)]
    [Il2CppSetOption(Option.DivideByZeroChecks, false)]
    public struct EcsMovementComponent : IComponent
    {
        [NonSerialized]
        public Vector3 Position;
        
        [NonSerialized]
        public Quaternion Rotation;
        
        [NonSerialized]
        public Vector3 CurrentForce;
            
        public float movementForce;
    }
}