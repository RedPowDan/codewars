using System;
using System.Diagnostics;

namespace Tests.Helpers
{
    public static class HelperTests<T>
    {
        public static T Run(Func<T> func)
        {
            var stopwatch = Stopwatch.StartNew();
            var memoryBefore = GC.GetTotalMemory(false);
            
            try
            {
                var result = func.Invoke();
                return result;
            }
            finally
            {
                var elapsed = stopwatch.Elapsed;
                var memoryAfter = GC.GetTotalMemory(false);
                var usedMemory = memoryAfter - memoryBefore;

                Console.WriteLine($"Used memory: {usedMemory} byte");
                Console.WriteLine($"Function execution time: {elapsed.TotalMilliseconds} ms");
            }
        }
    }
}