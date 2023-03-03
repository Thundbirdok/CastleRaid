using System;
using UnityEngine;

namespace GameResources.EraserMechanics.Core.Scripts
{
    [Serializable]
    public class SquarePlace
    {
        [field: SerializeField]
        public Transform LeftBack { get; private set; }
        
        [field: SerializeField]
        public Transform RightFront { get; private set; }

        private Vector3 _size = Vector3.zero;
        public Vector3 Size
        {
            get
            {
                if (_size != Vector3.zero)
                {
                    return _size;
                }

                var rightFrontPosition = RightFront.position;
                var leftBackPosition = LeftBack.position;

                _size = new Vector3
                (
                    rightFrontPosition.x - leftBackPosition.x,
                    rightFrontPosition.y - leftBackPosition.y,
                    rightFrontPosition.z - leftBackPosition.z
                );

                return _size;
            }
        }

        public Vector3 LocalLeftBack => LeftBack.localPosition;
    }
}
