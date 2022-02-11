using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using MQTTnet.Tests.Mockups;
using MQTTnet.Tests.Server;

namespace MQTTnet.Benchmarks
{
    [SimpleJob(RuntimeMoniker.NetCoreApp50)]
    [RPlotExporter, RankColumn]
    [MemoryDiagnoser]
    public class ServerProcessingBenchmark
    {
        [GlobalSetup]
        public void GlobalSetup()
        {
            TestEnvironment.EnableLogger = false;
        }
        
        [GlobalCleanup]
        public void GlobalCleanup()
        {
        }
        
        [Benchmark]
        public void Handle_100_000_Messages_In_Server()
        {
            new Load_Tests().Handle_100_000_Messages_In_Server().GetAwaiter().GetResult();
        }
    }
}