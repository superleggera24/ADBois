using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//win32 exception?
using System.ComponentModel;
//make calls to native Win32 functions
using System.Runtime.InteropServices;

namespace DLLAD
{
    // Query Performance Counter class, meet de duur van de uit te voeren sorteermethode
    public class QueryPerfCounter
    {
        //call de QueryPerformanceCounter win32 API
        [DllImport("KERNEL32")]
        private static extern bool QueryPerformanceCounter(out long lpPerformanceCount);

        // call de QueryPerformanceFrequency win32 API
        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceFrequency(out long lpFrequency);


        private long start;
        private long stop;
        private long frequency;
        Decimal multiplier = new Decimal(1.0e9);

        // Constructor
        public QueryPerfCounter()
        {
            if (QueryPerformanceFrequency(out frequency) == false)
            {
                // Frequency not supported
                throw new Win32Exception();
            }
        }

        //Start methode om current value van QueryPerformanceCounter te krijgen
        public void Start()
        {
            QueryPerformanceCounter(out start);
        }

        //Stop methode om current value van QueryPerformanceCounter te krijgen
        public void Stop()
        {
            QueryPerformanceCounter(out stop);
        }

        // Duration method met aantal iteraties als argument
        // Returned duration value
        // De methode berekent het aantal ticks tussen de start en stop values
        // stop-start resultaat x multiplier (duration van alle operations)
        // deel door het aantal iteraties om de duration per operation value te bekijken

        public double Duration(int iterations)
        {
            return ((((double)(stop - start) *
                      (double)multiplier) /
                      (double)frequency) / iterations);
        }

    }



    /*WRAPPER CLASS testestsetstestestttset
     * To use the QueryPerfCounter wrapper class in your code, you need to reference QueryPerfCounter.dll and 
     * then instantiate the QueryPerfCounter class.

        QueryPerfCounter myTimer = new QueryPerfCounter();
        // Measure without boxing
        myTimer.Start();

        for(int i = 0; i<iterations; i++)
        {
          // do some work to time
        }
        myTimer.Stop();

        // Calculate time per iteration in nanoseconds
        double result = myTimer.Duration(iterations);
    */
}