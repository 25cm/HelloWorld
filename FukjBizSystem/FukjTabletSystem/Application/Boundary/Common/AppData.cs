using System;

namespace FukjTabletSystem.Application.Boundary.Common
{
    public static class AppData
    {
        private static DateTime? StartTime = null;

        public static void SetStartTime(DateTime? startTime)
        {
            StartTime = startTime;
        }

        public static DateTime? GetStartTime()
        {
            return StartTime;
        }
    }
}
