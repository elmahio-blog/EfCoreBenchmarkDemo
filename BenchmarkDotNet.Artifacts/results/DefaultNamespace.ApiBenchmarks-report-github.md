```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.7462/24H2/2024Update/HudsonValley)
Intel Core i5-6300U CPU 2.40GHz (Max: 2.50GHz) (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method         | Mean      | Error     | StdDev   | Gen0     | Gen1     | Allocated |
|--------------- |----------:|----------:|---------:|---------:|---------:|----------:|
| Net8_EFCore8   | 110.75 ms | 10.490 ms | 30.10 ms | 750.0000 | 250.0000 |   5.62 MB |
| Net10_EFCore10 |  81.47 ms |  5.283 ms | 14.73 ms | 750.0000 | 250.0000 |   5.62 MB |
