
using BenchmarkDotNet.Attributes;
using System.Net.Http.Json;
namespace DefaultNamespace;

[MemoryDiagnoser]
public class ApiBenchmarks
{
    private readonly HttpClient _net8 =
        new() { BaseAddress = new Uri("http://localhost:5003") };

    private readonly HttpClient _net10 =
        new() { BaseAddress = new Uri("http://localhost:5296") };

    [Benchmark]
    public async Task Net8_EFCore8()
    {
        await _net8.GetFromJsonAsync<object[]>("/users/5");
    }

    [Benchmark]
    public async Task Net10_EFCore10()
    {
        await _net10.GetFromJsonAsync<object[]>("/users/5");
    }
}
