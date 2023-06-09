﻿//using System;

//static class DynamicExtensionMethod
//{
//    // 확장 메서드 
//    static string PreDotNet(this string str) => $"....{str}";

//    static void Main()
//    {
//        string s1 = "DotNet";
//        Console.WriteLine(s1.PreDotNet()); //[1] 실행됨

//        dynamic d1 = "Korea";
//        Console.WriteLine(d1.PreDotNet()); //[2] 에러 발생
//    }
//}


using System;

class TupleClassDemo
{
    static void Main()
    {
        //[1] 생성자를 통한 튜플 개체 생성
        var one = new Tuple<int>(1234);
        var two = new Tuple<int, string>(1, "C#");
        var many = new Tuple<int, string, string>(2019, "C#", "8.0");

        //[2] Tuple.Create 메서드를 통한 튜플 개체 생성
        var tuple = Tuple.Create(DateTime.Now.Year, "C# 8.0");

        //[!] Tuple에 의해 생성된 개체는 Item1, Item2, Item3 순서의 속성으로 접근
        Console.WriteLine($"{tuple.Item1} - {tuple.Item2}");
    }
}
