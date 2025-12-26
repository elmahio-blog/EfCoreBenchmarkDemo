```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.7462/24H2/2024Update/HudsonValley)
Intel Core i5-6300U CPU 2.40GHz (Max: 2.50GHz) (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3


```
| Method         | Mean     | Error    | StdDev   | Median   | Gen0      | Gen1     | Gen2     | Allocated |
|--------------- |---------:|---------:|---------:|---------:|----------:|---------:|---------:|----------:|
| Net8_EFCore8   | 87.92 ms | 7.125 ms | 20.78 ms | 87.39 ms | 1000.0000 |        - |        - |   5.63 MB |
| Net10_EFCore10 | 89.84 ms | 9.439 ms | 26.93 ms | 81.47 ms | 1000.0000 | 500.0000 | 250.0000 |   5.62 MB |
