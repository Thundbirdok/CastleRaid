using UnityEngine;

namespace GameResources.EraserMechanics.Core.Scripts
{
    using System.Collections;
    using System.Collections.Generic;

    public class GridGenerator : MonoBehaviour
    {
        [SerializeField]
        private MeshFilter meshFilter;

        [SerializeField]
        private MeshCollider meshCollider;
        
        [SerializeField]
        private Vector3 cellSize;

        [SerializeField]
        private SquarePlace place;

        private Vector3Int _sizeInCells;

        private Vector3[] _vertices;
        private int[] _triangles;
        
        private bool[][] _gridState;
        
        private IEnumerator Start()
        {
            Generate();

            var erasePoint = new Vector2Int(_sizeInCells.x / 2, 0);

            // for (var i = -5; i < 5; ++i)
            // {
            //     for (var j = -5; j < 5; ++j)
            //     {
            //         if (i * i + j * j > 25)
            //         {
            //             continue;
            //         }
            //         
            //         TurnOffCell(erasePoint.y + i, erasePoint.x + j);
            //
            //         yield return null;
            //     }
            // }

            TurnOffCell(erasePoint.y, erasePoint.x);
            TurnOffCell(erasePoint.y + 1, erasePoint.x);
            TurnOffCell(erasePoint.y + 2, erasePoint.x);
            TurnOffCell(erasePoint.y + 3, erasePoint.x);
            TurnOffCell(erasePoint.y + 4, erasePoint.x);
            TurnOffCell(erasePoint.y + 5, erasePoint.x);
            TurnOffCell(erasePoint.y + 6, erasePoint.x);
            TurnOffCell(erasePoint.y + 7, erasePoint.x);
            TurnOffCell(erasePoint.y + 8, erasePoint.x);
            TurnOffCell(erasePoint.y + 9, erasePoint.x);
            TurnOffCell(erasePoint.y + 10, erasePoint.x);
            TurnOffCell(erasePoint.y + 11, erasePoint.x);
            TurnOffCell(erasePoint.y + 12, erasePoint.x);
            TurnOffCell(erasePoint.y + 13, erasePoint.x);
            TurnOffCell(erasePoint.y + 14, erasePoint.x);
            TurnOffCell(erasePoint.y + 15, erasePoint.x);
            TurnOffCell(erasePoint.y + 16, erasePoint.x);
            TurnOffCell(erasePoint.y + 17, erasePoint.x);
            TurnOffCell(erasePoint.y + 18, erasePoint.x);
            TurnOffCell(erasePoint.y + 19, erasePoint.x);
            
            yield return null;
            meshFilter.mesh.vertices = _vertices;
            meshFilter.mesh.triangles = _triangles;
            
            TurnOffCell(erasePoint.y, erasePoint.x - 1);
            TurnOffCell(erasePoint.y + 1, erasePoint.x- 1);
            TurnOffCell(erasePoint.y + 2, erasePoint.x- 1);
            TurnOffCell(erasePoint.y + 3, erasePoint.x- 1);
            TurnOffCell(erasePoint.y + 4, erasePoint.x- 1);
            TurnOffCell(erasePoint.y + 5, erasePoint.x- 1);
            TurnOffCell(erasePoint.y + 6, erasePoint.x- 1);
            TurnOffCell(erasePoint.y + 7, erasePoint.x- 1);
            TurnOffCell(erasePoint.y + 8, erasePoint.x - 1);
            TurnOffCell(erasePoint.y + 9, erasePoint.x- 1);
            TurnOffCell(erasePoint.y + 10, erasePoint.x- 1);
            TurnOffCell(erasePoint.y + 11, erasePoint.x - 1);
            TurnOffCell(erasePoint.y + 12, erasePoint.x- 1);
            TurnOffCell(erasePoint.y + 13, erasePoint.x- 1);
            TurnOffCell(erasePoint.y + 14, erasePoint.x- 1);
            TurnOffCell(erasePoint.y + 15, erasePoint.x- 1);
            TurnOffCell(erasePoint.y + 16, erasePoint.x- 1);
            TurnOffCell(erasePoint.y + 17, erasePoint.x- 1);
            TurnOffCell(erasePoint.y + 18, erasePoint.x - 1);
            TurnOffCell(erasePoint.y + 19, erasePoint.x- 1);
            
            yield return null;
            meshFilter.mesh.vertices = _vertices;
            meshFilter.mesh.triangles = _triangles;
            
            TurnOffCell(erasePoint.y, erasePoint.x + 1);
            TurnOffCell(erasePoint.y + 1, erasePoint.x + 1);
            TurnOffCell(erasePoint.y + 2, erasePoint.x + 1);
            TurnOffCell(erasePoint.y + 3, erasePoint.x + 1);
            TurnOffCell(erasePoint.y + 4, erasePoint.x + 1);
            TurnOffCell(erasePoint.y + 5, erasePoint.x + 1);
            TurnOffCell(erasePoint.y + 6, erasePoint.x + 1);
            TurnOffCell(erasePoint.y + 7, erasePoint.x + 1);
            TurnOffCell(erasePoint.y + 8, erasePoint.x + 1);
            TurnOffCell(erasePoint.y + 9, erasePoint.x + 1);
            TurnOffCell(erasePoint.y + 10, erasePoint.x + 1);
            TurnOffCell(erasePoint.y + 11, erasePoint.x + 1);
            TurnOffCell(erasePoint.y + 12, erasePoint.x + 1);
            TurnOffCell(erasePoint.y + 13, erasePoint.x + 1);
            TurnOffCell(erasePoint.y + 14, erasePoint.x + 1);
            TurnOffCell(erasePoint.y + 15, erasePoint.x + 1);
            TurnOffCell(erasePoint.y + 16, erasePoint.x + 1);
            TurnOffCell(erasePoint.y + 17, erasePoint.x + 1);
            TurnOffCell(erasePoint.y + 18, erasePoint.x + 1);
            TurnOffCell(erasePoint.y + 19, erasePoint.x + 1);
            
            yield return null;
            meshFilter.mesh.vertices = _vertices;
            meshFilter.mesh.triangles = _triangles;
            
            TurnOffCell(erasePoint.y, erasePoint.x - 2);
            TurnOffCell(erasePoint.y + 1, erasePoint.x - 2);
            TurnOffCell(erasePoint.y + 2, erasePoint.x - 2);
            TurnOffCell(erasePoint.y + 3, erasePoint.x - 2);
            TurnOffCell(erasePoint.y + 4, erasePoint.x - 2);
            TurnOffCell(erasePoint.y + 5, erasePoint.x - 2);
            TurnOffCell(erasePoint.y + 6, erasePoint.x - 2);
            TurnOffCell(erasePoint.y + 7, erasePoint.x - 2);
            TurnOffCell(erasePoint.y + 8, erasePoint.x - 2);
            TurnOffCell(erasePoint.y + 9, erasePoint.x - 2);
            TurnOffCell(erasePoint.y + 10, erasePoint.x - 2);
            TurnOffCell(erasePoint.y + 11, erasePoint.x - 2);
            
            yield return null;
            meshFilter.mesh.vertices = _vertices;
            meshFilter.mesh.triangles = _triangles;
            
            TurnOffCell(erasePoint.y, erasePoint.x + 2);
            TurnOffCell(erasePoint.y + 1, erasePoint.x + 2);
            TurnOffCell(erasePoint.y + 2, erasePoint.x + 2);
            TurnOffCell(erasePoint.y + 3, erasePoint.x + 2);
            TurnOffCell(erasePoint.y + 4, erasePoint.x + 2);
            TurnOffCell(erasePoint.y + 5, erasePoint.x + 2);
            TurnOffCell(erasePoint.y + 6, erasePoint.x + 2);
            TurnOffCell(erasePoint.y + 7, erasePoint.x + 2);
            TurnOffCell(erasePoint.y + 8, erasePoint.x + 2);
            TurnOffCell(erasePoint.y + 9, erasePoint.x + 2);
            TurnOffCell(erasePoint.y + 10, erasePoint.x + 2);
            TurnOffCell(erasePoint.y + 11, erasePoint.x + 2);
            
            yield return null;
            meshFilter.mesh.vertices = _vertices;
            meshFilter.mesh.triangles = _triangles;
            
            TurnOffCell(erasePoint.y, erasePoint.x - 3);
            TurnOffCell(erasePoint.y + 1, erasePoint.x - 3);
            TurnOffCell(erasePoint.y + 2, erasePoint.x - 3);
            TurnOffCell(erasePoint.y + 3, erasePoint.x - 3);
            TurnOffCell(erasePoint.y + 4, erasePoint.x - 3);
            TurnOffCell(erasePoint.y + 5, erasePoint.x - 3);
            TurnOffCell(erasePoint.y + 6, erasePoint.x - 3);
            TurnOffCell(erasePoint.y + 7, erasePoint.x - 3);
            
            yield return null;
            meshFilter.mesh.vertices = _vertices;
            meshFilter.mesh.triangles = _triangles;
            
            TurnOffCell(erasePoint.y, erasePoint.x + 3);
            TurnOffCell(erasePoint.y + 1, erasePoint.x + 3);
            TurnOffCell(erasePoint.y + 2, erasePoint.x + 3);
            TurnOffCell(erasePoint.y + 3, erasePoint.x + 3);
            TurnOffCell(erasePoint.y + 4, erasePoint.x + 3);
            TurnOffCell(erasePoint.y + 5, erasePoint.x + 3);
            TurnOffCell(erasePoint.y + 6, erasePoint.x + 3);
            TurnOffCell(erasePoint.y + 7, erasePoint.x + 3);

            yield return null;
            meshFilter.mesh.vertices = _vertices;
            meshFilter.mesh.triangles = _triangles;
            
            var mesh = meshCollider.sharedMesh;
            mesh.vertices = _vertices;
            mesh.triangles = _triangles;
            meshCollider.sharedMesh = mesh;
        }

        private void TurnOffCell(int iCellIndex, int jCellIndex)
        {
            if (iCellIndex >= _sizeInCells.z || iCellIndex < 0)
            {
                return;
            }
            
            if (jCellIndex >= _sizeInCells.x || jCellIndex < 0)
            {
                return;
            }
            
            _gridState[iCellIndex][jCellIndex] = false;

            SetInversedCell(iCellIndex, jCellIndex - 1);
            SetInversedCell(iCellIndex + 1, jCellIndex - 1);
            SetInversedCell(iCellIndex - 1, jCellIndex - 1);
            
            MoveVertexDown(iCellIndex, jCellIndex);
            MoveVertexDown(iCellIndex, jCellIndex + 1);
            MoveVertexDown(iCellIndex + 1, jCellIndex);
            MoveVertexDown(iCellIndex + 1, jCellIndex + 1);
        }

        private void SetInversedCell(int iCellIndex, int jCellIndex)
        {
            if (iCellIndex >= _sizeInCells.z || iCellIndex < 0)
            {
                return;
            }
            
            if (jCellIndex >= _sizeInCells.x || jCellIndex < 0)
            {
                return;
            }
            
            if (_gridState[iCellIndex][jCellIndex] == false)
            {
                return;
            }
            
            var verticesForLoop = _sizeInCells.x + 1;
            var vertexIndex = iCellIndex * verticesForLoop + jCellIndex;
            var triangleIndex = jCellIndex * 6 + iCellIndex * _sizeInCells.x * 6;

            _triangles[triangleIndex] = _triangles[triangleIndex + 5] = vertexIndex;
            _triangles[triangleIndex + 1] = vertexIndex + verticesForLoop;

            _triangles[triangleIndex + 2] =
                _triangles[triangleIndex + 3] = vertexIndex + verticesForLoop + 1;

            _triangles[triangleIndex + 4] = vertexIndex + 1;
        }

        private void MoveVertexDown(int i,  int j)
        {
            if (i > _sizeInCells.z || i < 0)
            {
                return;
            }
            
            if (j > _sizeInCells.x || j < 0)
            {
                return;
            }
            
            var index = i * (_sizeInCells.x + 1) + j;

            var newPosition = _vertices[index];
            newPosition.y = 0;
            _vertices[index] = newPosition;
        }
        
        private void Generate()
        {
            var mesh = new Mesh
            {
                name = "GeneratedGrid"
            };

            _sizeInCells = new Vector3Int
            (
                Mathf.CeilToInt(place.Size.x / cellSize.x),
                1,
                Mathf.CeilToInt(place.Size.z / cellSize.z)
            );
            
            //
            _gridState = new bool[_sizeInCells.z][];

            for (int i = 0; i < _sizeInCells.z; i++)
            {
                _gridState[i] = new bool[_sizeInCells.x];

                for (int j = 0; j < _sizeInCells.x; j++)
                {
                    _gridState[i][j] = true;
                }
            }
            //
            
            SetVertices(ref mesh);

            SetTriangles(ref mesh);
            
            mesh.RecalculateNormals();
            
            meshFilter.mesh = mesh;
            meshCollider.sharedMesh = mesh;
        }

        private void SetVertices(ref Mesh mesh)
        {
            var verticesCount = GetVerticesCount();

            _vertices = new Vector3[verticesCount];

            var vertexIndex = 0;

            SetTopVertices(ref vertexIndex);
            
            SetSideVertices(ref vertexIndex);

            mesh.vertices = _vertices;
        }

        private int GetVerticesCount()
        {
            var cornersCount = 8;
            var edgesCount = (_sizeInCells.x + _sizeInCells.y + _sizeInCells.z - 3) * 4;

            var xySide = (_sizeInCells.x - 1) * (_sizeInCells.y - 1);
            var zySide = (_sizeInCells.y - 1) * (_sizeInCells.z - 1);
            var top = (_sizeInCells.x - 1) * (_sizeInCells.z - 1);
            
            var faceCount = xySide * 2
                            + top
                            + zySide * 2;
            
            var verticesCount = cornersCount + edgesCount + faceCount;

            return verticesCount;
        }

        private void SetTopVertices(ref int vertexIndex)
        {
            for (var i = 0; i <= _sizeInCells.z; ++i)
            {
                for (var j = 0; j <= _sizeInCells.x; ++j)
                {
                    SetVertex(i, j, _sizeInCells.y, ref vertexIndex);
                }
            }
        }

        private void SetSideVertices(ref int vertexIndex)
        {
            for (var j = 0; j <= _sizeInCells.x; ++j)
            {
                SetVertex(0, j, 0, ref vertexIndex);
            }

            for (var i = 1; i < _sizeInCells.z; ++i)
            {
                SetVertex(i, _sizeInCells.x, 0, ref vertexIndex);
            }

            for (var j = 0; j <= _sizeInCells.x; ++j)
            {
                SetVertex(_sizeInCells.z, _sizeInCells.x - j, 0, ref vertexIndex);
            }

            for (var i = 1; i < _sizeInCells.z; ++i)
            {
                SetVertex(_sizeInCells.z - i, 0, 0, ref vertexIndex);
            }
        }

        private void SetVertex(int i, int j, int k, ref int vertexIndex)
        {
            _vertices[vertexIndex] = GetVertexPositionFromIndex(i, j, k);
            
            ++vertexIndex;
        }

        private Vector3 GetVertexPositionFromIndex(int i, int j, int k)
        {
            var x = Mathf.Min(j * cellSize.x, place.Size.x);
            var y = Mathf.Min(k * cellSize.y, place.Size.y);
            var z = Mathf.Min(i * cellSize.z, place.Size.z);
            
            return place.LocalLeftBack + new Vector3(x, y, z);
        }

        private void SetTriangles(ref Mesh mesh)
        {
            var trianglesCount = _sizeInCells.x * _sizeInCells.y * _sizeInCells.z
                                  * _sizeInCells.x * _sizeInCells.y * _sizeInCells.z
                                  * 6 * 2
                                  - _sizeInCells.x * _sizeInCells.z * 6;
            
            _triangles = new int[trianglesCount];
            
            var triangleIndex = 0;

            SetTopTriangles
            (
                ref _triangles,
                ref triangleIndex
            );

            SetSidesTriangles
            (
                ref _triangles,
                ref triangleIndex
            );

            mesh.triangles = _triangles;
        }

        private void SetSidesTriangles
        (
            ref int[] triangles,
            ref int triangleIndex
        )
        {
            var verticesForLoop = (_sizeInCells.x + _sizeInCells.z) * 2;
            var topVerticesCount = (_sizeInCells.x + 1) * (_sizeInCells.z + 1);
            var vertexIndex = topVerticesCount;
            
            for (var j = 0; j < _sizeInCells.x; ++j)
            {
                SetCell
                (
                    ref triangles,
                    ref triangleIndex,
                    vertexIndex,
                    vertexIndex - topVerticesCount,
                    vertexIndex + 1,
                    vertexIndex - topVerticesCount + 1
                );

                ++vertexIndex;
            }
            
            for (var i = 0; i < _sizeInCells.z; ++i)
            {
                var offset = _sizeInCells.x + 1;
                
                SetCell
                (
                    ref triangles,
                    ref triangleIndex,
                    vertexIndex,
                    offset * (i + 1) - 1,
                    vertexIndex + 1,
                    offset * (i + 2) - 1
                );
            
                ++vertexIndex;
            }
            
            for (var j = 0; j < _sizeInCells.x; ++j)
            {
                var offset = _sizeInCells.z + _sizeInCells.x + 1 + j * 2;
                
                SetCell
                (
                    ref triangles,
                    ref triangleIndex,
                    vertexIndex,
                    vertexIndex - offset,
                    vertexIndex + 1,
                    vertexIndex - offset - 1
                );
            
                ++vertexIndex;
            }

            for (var i = _sizeInCells.z - 1; i > 0; --i)
            {
                var offset = _sizeInCells.x + 1;
                
                SetCell
                (
                    ref triangles,
                    ref triangleIndex,
                    vertexIndex,
                    offset * (i + 1),
                    vertexIndex + 1,
                    offset * i
                );
            
                ++vertexIndex;
            }
            
            SetCell
            (
                ref triangles,
                ref triangleIndex,
                vertexIndex,
                _sizeInCells.x + 1,
                vertexIndex - verticesForLoop + 1,
                0
            );
        }

        private void SetTopTriangles
        (
            ref int[] triangles,
            ref int triangleIndex
        )
        {
            var verticesForLoop = _sizeInCells.x + 1;
            var vertexIndex = 0;

            for (var i = 0; i < _sizeInCells.z; ++i)
            {
                for (var j = 0; j < _sizeInCells.x; ++j)
                {
                    SetCell
                    (
                        ref triangles,
                        ref triangleIndex,
                        vertexIndex,
                        vertexIndex + verticesForLoop,
                        vertexIndex + 1,
                        vertexIndex + verticesForLoop + 1
                    );

                    ++vertexIndex;
                }

                ++vertexIndex;
            }
        }

        private static void SetCell
        (
            ref int[] triangles,
            ref int triangleIndex,
            int v00,
            int v01,
            int v10,
            int v11
        )
        {
            triangles[triangleIndex] = v00;
            triangles[triangleIndex + 1] = triangles[triangleIndex + 4] = v01;
            triangles[triangleIndex + 2] = triangles[triangleIndex + 3] = v10;
            triangles[triangleIndex + 5] = v11;

            triangleIndex += 6;
        }
    }
}
