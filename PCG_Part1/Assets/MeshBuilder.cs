using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshBuilder
{
    private List<Vector3> vertices = new List<Vector3>(); // list of points 
    private List<int> trianglesIndices = new List<int>(); // an index to the list of points, specifying which points make up a triangle 
    private List<Vector3> normals = new List<Vector3>(); // defines the direction of each vertex
    private List<Vector2> uv = new List<Vector2>();

    private List<int>[] subMeshIndices = new List<int>[] { }; // array of submesh indices - index points to an index of a material

    public void TriangleBuilder(Vector3 p0, Vector3 p1, Vector3 p2, int submesh)
    {
        Vector3 normal = Vector3.Cross(p1 - p0, p2 - p0).normalized;
        TriangleBuilder(p0, p1, p2, submesh);
    }

    public void TriangleBuilder(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 normal, int submesh)
    {
        int p0Index = vertices.Count;
        int p1Index = vertices.Count + 1;
        int p2Index = vertices.Count + 2;

        trianglesIndices.Add(p0Index);
        trianglesIndices.Add(p1Index);
        trianglesIndices.Add(p2Index);

        subMeshIndices[submesh].Add(p0Index);
        subMeshIndices[submesh].Add(p1Index);
        subMeshIndices[submesh].Add(p2Index);

        vertices.Add(p0);
        vertices.Add(p1);
        vertices.Add(p2);

        normals.Add(normal);
        normals.Add(normal);
        normals.Add(normal);

        uv.Add(new Vector2(0, 0));
        uv.Add(new Vector2(0, 1));
        uv.Add(new Vector2(1, 1));
    }
}
