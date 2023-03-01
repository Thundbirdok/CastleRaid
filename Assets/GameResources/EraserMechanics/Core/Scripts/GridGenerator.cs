using UnityEngine;

namespace GameResources.EraserMechanics.Core.Scripts
{
    using System;
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
        private Square place;

        private Vector3Int _sizeInCells;

        private Vector3[] _vertices;

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
            TurnOffCell(erasePoint.y, erasePoint.x - 3);
            TurnOffCell(erasePoint.y + 1, erasePoint.x - 3);
            TurnOffCell(erasePoint.y + 2, erasePoint.x - 3);
            TurnOffCell(erasePoint.y + 3, erasePoint.x - 3);
            TurnOffCell(erasePoint.y + 4, erasePoint.x - 3);
            TurnOffCell(erasePoint.y + 5, erasePoint.x - 3);
            TurnOffCell(erasePoint.y + 6, erasePoint.x - 3);
            TurnOffCell(erasePoint.y + 7, erasePoint.x - 3);
            
            yield return null;
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
            
            var mesh = meshCollider.sharedMesh;
            mesh.vertices = _vertices;
            meshCollider.sharedMesh = mesh;
        }

        private float time;
        private void Update()
        {
            // _vertices[0].y -= Time.deltaTime;
            //
            // meshFilter.mesh.vertices = _vertices;

            // time += Time.deltaTime;
            //
            // if (time < 0.5f)
            // {
            //     return;
            // }
            //
            // time = 0;
            //
            // TurnOffCell(0, _sizeInCells.x / 2);
            // TurnOffCell(0, _sizeInCells.x / 2 + 1);
            // TurnOffCell(0, _sizeInCells.x / 2 + 2);
            // TurnOffCell(0, _sizeInCells.x / 2 - 1);
            // TurnOffCell(0, _sizeInCells.x / 2 - 2);
            // TurnOffCell(1, _sizeInCells.x / 2);
            // TurnOffCell(1, _sizeInCells.x / 2 + 1);
            // TurnOffCell(1, _sizeInCells.x / 2 - 1);
            // TurnOffCell(2, _sizeInCells.x / 2);

            // for (int i = 0; i < _gridState.Length; i++)
            // {
            //     for (var j = 0; j < _gridState[i].Length; j++)
            //     {
            //         if ()
            //     }
            // }
        }

        private void TurnOffCell(int iCellIndex, int jCellIndex)
        {
            //_gridState[iCellIndex][jCellIndex] = false;

            var listToCheck = new List<Vector3>
            {
                GetVertexPositionFromIndex(iCellIndex, jCellIndex, _sizeInCells.y),
                GetVertexPositionFromIndex(iCellIndex, jCellIndex + 1, _sizeInCells.y),
                GetVertexPositionFromIndex(iCellIndex + 1, jCellIndex, _sizeInCells.y),
                GetVertexPositionFromIndex(iCellIndex + 1, jCellIndex + 1, _sizeInCells.y)
            };

            for (var i = 0; i < _vertices.Length; ++i)
            {
                for (var j = 0; j < listToCheck.Count; ++j)
                {
                    if (_vertices[i] != listToCheck[j])
                    {
                        continue;
                    }

                    var newPosition = listToCheck[j];
                    newPosition.y = 0;
                    _vertices[i] = newPosition;
                        
                    listToCheck.RemoveAt(j);

                    break;
                }
            }
        }

        private void OnDrawGizmos()
        {
            if (_vertices == null)
            {
                return;
            }

            var defaultColor = Gizmos.color;
            Gizmos.color = Color.red;

            foreach (var vertex in _vertices)
            {
                Gizmos.DrawSphere(transform.TransformPoint(vertex), 0.2f);
            }
            
            Gizmos.color = defaultColor;
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
                Mathf.CeilToInt(place.Size.y / cellSize.y),
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

            //SetUVs(ref mesh);
            
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

            SetSideVertices(ref vertexIndex);

            SetTopVertices(ref vertexIndex);
            
            SetBottomVertices(ref vertexIndex);

            mesh.vertices = _vertices;
        }

        private int GetVerticesCount()
        {
            var cornersCount = 8;
            var edgesCount = (_sizeInCells.x + _sizeInCells.y + _sizeInCells.z - 3) * 4;

            var faceCount = (_sizeInCells.x - 1) * (_sizeInCells.y - 1)
                            + (_sizeInCells.x - 1) * (_sizeInCells.z - 1)
                            + (_sizeInCells.y - 1) * (_sizeInCells.z - 1);

            faceCount *= 2;

            var verticesCount = cornersCount + edgesCount + faceCount;

            return verticesCount;
        }

        private void SetBottomVertices(ref int vertexIndex)
        {
            for (var i = 1; i < _sizeInCells.z; ++i)
            {
                for (var j = 1; j < _sizeInCells.x; ++j)
                {
                    SetVertex(i, j, 0, ref vertexIndex);
                }
            }
        }

        private void SetTopVertices(ref int vertexIndex)
        {
            for (var i = 1; i < _sizeInCells.z; ++i)
            {
                for (var j = 1; j < _sizeInCells.x; ++j)
                {
                    SetVertex(i, j, _sizeInCells.y, ref vertexIndex);
                }
            }
        }

        private void SetSideVertices(ref int vertexIndex)
        {
            for (var k = 0; k <= _sizeInCells.y; ++k)
            {
                for (var j = 0; j <= _sizeInCells.x; ++j)
                {
                    SetVertex(0, j, k, ref vertexIndex);
                }

                for (var i = 1; i < _sizeInCells.z; ++i)
                {
                    SetVertex(i, _sizeInCells.x, k, ref vertexIndex);
                }

                for (var j = 0; j <= _sizeInCells.x; ++j)
                {
                    SetVertex(_sizeInCells.z, _sizeInCells.x - j, k, ref vertexIndex);
                }

                for (var i = 1; i < _sizeInCells.z; ++i)
                {
                    SetVertex(_sizeInCells.z - i, 0, k, ref vertexIndex);
                }
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
        
        private void SetUVs(ref Mesh mesh)
        {
            var uvs = new Vector2[(_sizeInCells.x + 1) * (_sizeInCells.y + 1)];

            var vertexIndex = 0;

            for (var k = 0; k < _sizeInCells.y; k++)
            {
                for (var i = 0; i <= _sizeInCells.z; i++)
                {
                    for (var j = 0; j <= _sizeInCells.x; j++)
                    {
                        uvs[vertexIndex] = new Vector2
                            ((float)j / _sizeInCells.x, (float)i / _sizeInCells.y);

                        ++vertexIndex;
                    }
                }
            }

            mesh.uv = uvs;
        }

        private void SetTriangles(ref Mesh mesh)
        {
            var trianglesCount = _sizeInCells.x * _sizeInCells.y * _sizeInCells.z
                                  * _sizeInCells.x * _sizeInCells.y * _sizeInCells.z 
                                  * 6 * 2;
            
            var triangles = new int[trianglesCount];

            var verticesForLoop = (_sizeInCells.x + _sizeInCells.z) * 2;
            var triangleIndex = 0;
            var vertexIndex = 0;

            SetSidesTriangles
            (
                ref triangles,
                ref triangleIndex,
                ref vertexIndex,
                verticesForLoop
            );
            
            SetTopTriangles
            (
                ref triangles,
                ref triangleIndex,
                verticesForLoop
            );
            
            SetBottomTriangles
            (
                ref triangles,
                ref triangleIndex,
                verticesForLoop
            );
            
            mesh.triangles = triangles;
        }

        private void SetSidesTriangles
            (
            ref int[] triangles,
            ref int triangleIndex,
            ref int vertexIndex,
            in int verticesForLoop
            )
        {
            for (var k = 0; k < _sizeInCells.y; ++k)
            {
                for (var j = 0; j < verticesForLoop - 1; ++j)
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

                SetCell
                (
                    ref triangles,
                    ref triangleIndex,
                    vertexIndex,
                    vertexIndex + verticesForLoop,
                    vertexIndex - verticesForLoop + 1,
                    vertexIndex + 1
                );

                ++vertexIndex;
            }
        }

        private void SetBottomTriangles
        (
            ref int[] triangles,
            ref int triangleIndex,
            in int verticesForLoop
        )
        {
            var vertexOutRight = 0;
            var vertexOutLeft = verticesForLoop - 1;
            var innerStart = _vertices.Length - (_sizeInCells.z - 1) * (_sizeInCells.x - 1);
            var vertexInner = innerStart;
            
            SetBottomTrianglesFirstRow
            (
                ref triangles,
                ref triangleIndex,
                ref vertexOutLeft,
                ref vertexOutRight,
                ref vertexInner
            );
            
            SetBottomTrianglesInnerRow
            (
                ref triangles,
                ref triangleIndex,
                ref innerStart,
                out vertexInner,
                ref vertexOutRight,
                ref vertexOutLeft
            );
            
            SetBottomTrianglesLastRow
            (
                ref triangles, 
                ref triangleIndex, 
                ref vertexOutLeft, 
                ref vertexOutRight, 
                ref vertexInner
            );
        }

        private void SetBottomTrianglesLastRow
            (
            ref int[] triangles,
            ref int triangleIndex,
            ref int vertexOutLeft,
            ref int vertexOutRight,
            ref int vertexInner
            )
        {
            vertexOutLeft--;
            vertexOutRight++;

            SetCell
            (
                ref triangles,
                ref triangleIndex,
                vertexOutLeft,
                vertexOutLeft + 1,
                vertexOutLeft - 1,
                vertexInner
            );

            for (var x = 1; x < _sizeInCells.x - 1; x++)
            {
                SetCell
                (
                    ref triangles,
                    ref triangleIndex,
                    vertexOutLeft - 1,
                    vertexInner,
                    vertexOutLeft - 2,
                    vertexInner + 1
                );

                vertexOutLeft--;
                vertexInner++;
            }

            SetCell
            (
                ref triangles,
                ref triangleIndex,
                vertexOutRight + 1,
                vertexInner,
                vertexOutRight,
                vertexOutRight - 1
            );
        }

        private void SetBottomTrianglesInnerRow
        (
            ref int[] triangles,
            ref int triangleIndex,
            ref int innerStart,
            out int vertexInner,
            ref int vertexOutRight,
            ref int vertexOutLeft
        )
        {
            vertexInner = innerStart;
            vertexOutRight += 2;

            for (var z = 1; z < _sizeInCells.z - 1; z++)
            {
                SetCell
                (
                    ref triangles,
                    ref triangleIndex,
                    vertexOutLeft - 1,
                    vertexOutLeft,
                    vertexInner + _sizeInCells.x - 1,
                    vertexInner
                );

                for (var x = 1; x < _sizeInCells.x - 1; x++, vertexInner++)
                {
                    SetCell
                    (
                        ref triangles,
                        ref triangleIndex,
                        vertexInner + _sizeInCells.x - 1,
                        vertexInner,
                        vertexInner + _sizeInCells.x,
                        vertexInner + 1
                    );
                }

                SetCell
                (
                    ref triangles,
                    ref triangleIndex,
                    vertexInner + _sizeInCells.x - 1,
                    vertexInner,
                    vertexOutRight + 1,
                    vertexOutRight
                );

                --vertexOutLeft;
                ++vertexInner;
                ++vertexOutRight;
            }
        }

        private void SetBottomTrianglesFirstRow
        (
            ref int[] triangles,
            ref int triangleIndex,
            ref int vertexOutLeft,
            ref int vertexOutRight,
            ref int vertexInner
        )
        {
            SetCell
            (
                ref triangles,
                ref triangleIndex,
                vertexOutLeft,
                vertexOutRight,
                vertexInner,
                vertexOutRight + 1
            );

            ++vertexOutRight;

            for (var x = 1; x < _sizeInCells.x - 1; ++x)
            {
                SetCell
                (
                    ref triangles,
                    ref triangleIndex,
                    vertexInner,
                    vertexOutRight,
                    vertexInner + 1,
                    vertexOutRight + 1
                );

                ++vertexOutRight;
                ++vertexInner;
            }

            SetCell
            (
                ref triangles,
                ref triangleIndex,
                vertexInner,
                vertexOutRight,
                vertexOutRight + 2,
                vertexOutRight + 1
            );
        }

        private void SetTopTriangles
        (
            ref int[] triangles,
            ref int triangleIndex,
            in int verticesForLoop
        )
        {
            var vertexOutRight = verticesForLoop * _sizeInCells.y;
            var vertexOutLeft = verticesForLoop * (_sizeInCells.y + 1) - 1;
            var vertexInner = vertexOutLeft + 1;
            
            SetTopTrianglesFirstRow
            (
                ref triangles,
                ref triangleIndex,
                ref vertexOutRight,
                verticesForLoop
            );
            
            SetTopTrianglesInnerRow
            (
                ref triangles,
                ref triangleIndex, 
                ref vertexOutLeft,
                ref vertexInner, 
                ref vertexOutRight
            );
            
            SetTopTrianglesLastRow
            (
                ref triangles,
                ref triangleIndex,
                ref vertexOutLeft, 
                ref vertexInner,
                ref vertexOutRight
            );
        }

        private void SetTopTrianglesLastRow
        (
            ref int[] triangles,
            ref int triangleIndex,
            ref int vertexOutLeft,
            ref int vertexInner,
            ref int vertexOutRight
        )
        {
            SetCell
            (
                ref triangles,
                ref triangleIndex,
                vertexOutLeft + 1,
                vertexOutLeft,
                vertexInner,
                vertexOutLeft - 1
            );
        
            for (var x = 1; x < _sizeInCells.x - 1; ++x)
            {
                SetCell
                (
                    ref triangles,
                    ref triangleIndex,
                    vertexInner,
                    vertexOutLeft - 1,
                    vertexInner + 1,
                    vertexOutLeft - 2
                );
        
                ++vertexInner;
                --vertexOutLeft;
            }
        
            SetCell
            (
                ref triangles,
                ref triangleIndex,
                vertexInner,
                vertexOutRight + 1,
                vertexOutRight - 1,
                vertexOutRight
            );
        }
        
        private void SetTopTrianglesInnerRow
        (
            ref int[] triangles,
            ref int triangleIndex,
            ref int vertexOutLeft,
            ref int vertexInner,
            ref int vertexOutRight
        )
        {
            for (var i = 1; i < _sizeInCells.z - 1; ++i)
            {
                SetCell
                (
                    ref triangles,
                    ref triangleIndex,
                    vertexOutLeft,
                    vertexOutLeft - 1,
                    vertexInner,
                    vertexInner + _sizeInCells.x - 1
                );
        
                for (var j = 1; j < _sizeInCells.x - 1; ++j)
                {
                    SetCell
                    (
                        ref triangles,
                        ref triangleIndex,
                        vertexInner,
                        vertexInner + _sizeInCells.x - 1,
                        vertexInner + 1,
                        vertexInner + _sizeInCells.x
                    );
        
                    ++vertexInner;
                }
        
                SetCell
                (
                    ref triangles,
                    ref triangleIndex,
                    vertexInner,
                    vertexInner + _sizeInCells.x - 1,
                    vertexOutRight,
                    vertexOutRight + 1
                );
        
                --vertexOutLeft;
                ++vertexInner;
                ++vertexOutRight;
            }
            
            --vertexOutLeft;
            ++vertexOutRight;
        }
        
        private void SetTopTrianglesFirstRow
        (
            ref int[] triangles,
            ref int triangleIndex,
            ref int vertexOutRight,
            in int verticesForLoop
        )
        {
            for (var x = 0; x < _sizeInCells.x - 1; ++x)
            {
                SetCell
                (
                    ref triangles,
                    ref triangleIndex,
                    vertexOutRight,
                    vertexOutRight + verticesForLoop - 1,
                    vertexOutRight + 1,
                    vertexOutRight + verticesForLoop
                );
        
                ++vertexOutRight;
            }
        
            SetCell
            (
                ref triangles,
                ref triangleIndex,
                vertexOutRight,
                vertexOutRight + verticesForLoop - 1,
                vertexOutRight + 1,
                vertexOutRight + 2
            );
            
            vertexOutRight += 2;
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

    [Serializable]
    public class Square
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
        public Vector3 LocalRightFront => RightFront.localPosition;
    }
}
