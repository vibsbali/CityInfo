using System.Threading;

namespace CityInfo.Api.Code
{
    public static class Helpers
    {
        public static int IncrementBy(this int value, int increment)
        {
            return Interlocked.Add(ref value, increment);
        }
    }
}

