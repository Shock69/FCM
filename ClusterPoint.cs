namespace FCM
{
    public class ClusterPoint
    {
        /// Gets or sets X-coord of the point
        ///
        public double X { get; set; }

        ///
        /// Gets or sets Y-coord of the point
        ///
        public double Y { get; set; }

        ///
        /// Gets or sets some additional data for point
        ///
        public object Tag { get; set; }

        ///
        /// Gets or sets cluster index
        ///
        public double ClusterIndex { get; set; }

        ///
        /// Basic constructor
        ///
        /// X-coord
        /// Y-coord
        public ClusterPoint(double x, double y)
        {
            X = x;
            Y = y;
            ClusterIndex = -1;
        }

        ///
        /// Basic constructor
        ///
        /// X-coord
        /// Y-coord
        public ClusterPoint(double x, double y, object tag)
        {
            X = x;
            Y = y;
            Tag = tag;
            ClusterIndex = -1;
        }
    }
}