﻿using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
           // Greeter.Instance.SayHiToTheWorld();
            Singleton<Greeter>.Instance.SayHiToTheWorld();
        }
    }
}
