using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FCM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ClusterPoint> points = new List<ClusterPoint>
            {
                new ClusterPoint(new List<double>(){0, 4}),
                new ClusterPoint(new List<double>(){0, 2}),
                new ClusterPoint(new List<double>(){0, 0}),
                new ClusterPoint(new List<double>(){1, 3}),
                new ClusterPoint(new List<double>(){1, 2}),
                new ClusterPoint(new List<double>(){1, 1}),
                new ClusterPoint(new List<double>(){2, 2}),
                new ClusterPoint(new List<double>(){3, 2}),
                new ClusterPoint(new List<double>(){4, 2}),
                new ClusterPoint(new List<double>(){5, 3}),
                new ClusterPoint(new List<double>(){5, 2}),
                new ClusterPoint(new List<double>(){5, 1}),
                new ClusterPoint(new List<double>(){6, 4}),
                new ClusterPoint(new List<double>(){6, 2}),
                new ClusterPoint(new List<double>(){6, 0})
            };                                          


            List<ClusterCentroid> centroids = new List<ClusterCentroid>
            {
                new ClusterCentroid(new List<double>(){1, 2}),
                new ClusterCentroid(new List<double>(){6, 2})
            };


            CMeansAlgorithm alg = new CMeansAlgorithm(points, centroids, 2);
            int iterations = alg.Run(Math.Pow(10, -5));

            double[,] matrix = alg.U;

            for (int j = 0; j < points.Count; j++)
            {
                for (int i = 0; i < centroids.Count; i++)
                {
                    ClusterPoint p = points[j];
                    Console.WriteLine("{0:00} Point: ({1};{2}) ClusterIndex: {3} Value: {4:0.000}", j + 1, p.Data[0], p.Data[1], p.ClusterIndex, matrix[j, i]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Iteration count: {0}", iterations);
            Console.WriteLine();
            Console.WriteLine("Please press any key to exit...");
            Console.ReadLine();
        }
    }
}
