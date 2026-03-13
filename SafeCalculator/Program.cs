using System;

SafeCalculator safeCalculator = new SafeCalculator();

Console.WriteLine("=== 테스트 1: 정상 입력 ===");
safeCalculator.SafeDivide("10", "2");
Console.WriteLine();

Console.WriteLine("=== 테스트 2: 0으로 나누기 ===");
safeCalculator.SafeDivide("10", "0");
Console.WriteLine();

Console.WriteLine("=== 테스트 3: 잘못된 형식 ===");
safeCalculator.SafeDivide("10dsg", "2sdfg");
Console.WriteLine();