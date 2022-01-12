using System;

namespace GetNeighbors
{
    public static class CartesianCoordinates
    {
        /// <summary>
        /// Gets from a set of points only points that are h-neighbors for a point with integer coordinates x and y.
        /// </summary>
        /// <param name="point">Given point with integer coordinates x and y.</param>
        /// <param name="h">Distance around a given point.</param>
        /// <param name="points">A given set of points.</param>
        /// <returns>Only points that are h-neighbors for a point with integer coordinates x and y.</returns>
        /// <exception cref="ArgumentNullException">Throw when array points is null.</exception>
        /// <exception cref="ArgumentException">Throw when h-distance is less or equals zero.</exception>
        public static Point[] GetNeighbors(Point point, int h, params Point[] points)
        {
            if (points == null)
            {
                throw new ArgumentNullException(nameof(points));
            }

            if (h <= 0)
            {
                throw new ArgumentException(null, nameof(h));
            }

            int minX = point.X - h, maxX = point.X + h, minY = point.Y - h, maxY = point.Y + h;
            Point[] getNeighbors = Array.Empty<Point>();
            for (int i = 0; i < points.Length - 1; i++)
            {
                if (points[i].X >= minX && points[i].X <= maxX && points[i].Y >= minY && points[i].Y <= maxY)
                {
                    Array.Resize(ref getNeighbors, getNeighbors.Length + 1);
                    getNeighbors[^1] = new Point(points[i].X, points[i].Y);
                }
            }

            return getNeighbors;
        }
    }
}
