using UnityEngine;

namespace Sabresaurus.NineSlicedMesh
{
    public static class GizmoHelper
    {
        /// <summary>
        /// Draw a wire triangle from three points
        /// </summary>
        public static void DrawTriangle(Vector3 point1, Vector3 point2, Vector3 point3)
        {
            Gizmos.DrawLine(point1, point2);
            Gizmos.DrawLine(point2, point3);
            Gizmos.DrawLine(point3, point1);
        }
    }
}