// Author: Urlana Suresh Kumar (usk2003)
// -------------------------------------------------------------------

using System;
using System.Collections.Generic;

class Program
{
    const long MOD = 1000000007;

    // Useful Functions
    static long Gcd(long a, long b)
    {
        return b == 0 ? a : Gcd(b, a % b);
    }

    static long Lcm(long a, long b)
    {
        return (a / Gcd(a, b)) * b;
    }

    static long Power(long a, long b, long mod = MOD)
    {
        long result = 1;
        a %= mod;
        while (b > 0)
        {
            if ((b & 1) == 1)
            {
                result = (result * a) % mod;
            }
            a = (a * a) % mod;
            b >>= 1;
        }
        return result;
    }

    static long ModInverse(long a, long mod = MOD)
    {
        return Power(a, mod - 2, mod);
    }

    static bool IsPrime(long n)
    {
        if (n <= 1) return false;
        if (n <= 3) return true;
        if (n % 2 == 0 || n % 3 == 0) return false;
        for (long i = 5; i * i <= n; i += 6)
        {
            if (n % i == 0 || n % (i + 2) == 0) return false;
        }
        return true;
    }

    static long Factorial(long n, long mod = MOD)
    {
        long result = 1;
        for (long i = 2; i <= n; i++)
        {
            result = (result * i) % mod;
        }
        return result;
    }

    static long NCr(long n, long r, long mod = MOD)
    {
        if (r > n) return 0;
        long num = Factorial(n, mod);
        long denom = (Factorial(r, mod) * Factorial(n - r, mod)) % mod;
        return (num * ModInverse(denom, mod)) % mod;
    }

    static long NPr(long n, long r, long mod = MOD)
    {
        if (r > n) return 0;
        long num = Factorial(n, mod);
        long denom = Factorial(n - r, mod);
        return (num * ModInverse(denom, mod)) % mod;
    }

    // -------------------------------------------------------------------
    static void Solve()
    {
        var inputs = Console.ReadLine().Split();
        long n = long.Parse(inputs[0]);
        long q = long.Parse(inputs[1]);
        // Add logic for problem-solving here.
    }

    public static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            Solve();
        }
    }
}
// -------------------------------------------------------------------
