﻿namespace DotNetCore.CAP.Dashboard.Pages
{
    internal partial class BlockMetric
    {
        public BlockMetric(DashboardMetric dashboardMetric)
        {
            DashboardMetric = dashboardMetric;
        }

        public DashboardMetric DashboardMetric { get; }
    }
}