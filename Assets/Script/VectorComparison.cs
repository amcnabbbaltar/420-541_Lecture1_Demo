using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorComparison : MonoBehaviour
{
    [Header("Input Vectors")]
    public Vector3 vectorA = Vector3.right;
    public Vector3 vectorB = Vector3.up;

    [Header("Results (Read Only)")]
    [SerializeField] private float dotProduct;
    [SerializeField] private Vector3 crossProduct;

    [Header("Gizmo Settings")]
    public Color vectorAColor = Color.red;
    public Color vectorBColor = Color.blue;
    public Color crossProductColor = Color.green;
    public float gizmoScale = 1f;

    void OnValidate()
    {
        // Calculate results whenever values change in Inspector
        dotProduct = Vector3.Dot(vectorA, vectorB);
        crossProduct = Vector3.Cross(vectorA, vectorB);
    }

    void OnDrawGizmos()
    {
        Vector3 origin = transform.position;

        // Draw Vector A
        Gizmos.color = vectorAColor;
        Gizmos.DrawLine(origin, origin + vectorA * gizmoScale);

        // Draw Vector B
        Gizmos.color = vectorBColor;
        Gizmos.DrawLine(origin, origin + vectorB * gizmoScale);

        // Draw Cross Product Vector
        Gizmos.color = crossProductColor;
        Gizmos.DrawLine(origin, origin + crossProduct * gizmoScale);
    }
}
