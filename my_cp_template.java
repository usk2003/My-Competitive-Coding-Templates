// Author: Urlana Suresh Kumar (usk2003)
// -------------------------------------------------------------------

import java.util.*;

public class Main {

    static final long MOD = 1000000007;

    // Useful Functions
    static long gcd(long a, long b) {
        return b == 0 ? a : gcd(b, a % b);
    }

    static long lcm(long a, long b) {
        return a / gcd(a, b) * b;
    }

    static long power(long a, long b, long mod) {
        long res = 1;
        a %= mod;
        while (b > 0) {
            if (b % 2 == 1) {
                res = (res * a) % mod;
            }
            a = (a * a) % mod;
            b /= 2;
        }
        return res;
    }

    static long modInverse(long a, long mod) {
        return power(a, mod - 2, mod);
    }

    static boolean isPrime(long n) {
        if (n <= 1) return false;
        if (n <= 3) return true;
        if (n % 2 == 0 || n % 3 == 0) return false;
        for (long i = 5; i * i <= n; i += 6) {
            if (n % i == 0 || n % (i + 2) == 0) return false;
        }
        return true;
    }

    static long factorial(long n, long mod) {
        long res = 1;
        for (long i = 2; i <= n; i++) {
            res = (res * i) % mod;
        }
        return res;
    }

    static long nCr(long n, long r, long mod) {
        if (r > n) return 0;
        long num = factorial(n, mod);
        long denom = (factorial(r, mod) * factorial(n - r, mod)) % mod;
        return (num * modInverse(denom, mod)) % mod;
    }

    static long nPr(long n, long r, long mod) {
        if (r > n) return 0;
        long num = factorial(n, mod);
        long denom = factorial(n - r, mod);
        return (num * modInverse(denom, mod)) % mod;
    }

    // -------------------------------------------------------------------
    static void solve(Scanner sc) {
        long n = sc.nextLong();
        long q = sc.nextLong();
        // Add logic for problem-solving here.
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int t = sc.nextInt();
        while (t-- > 0) {
            solve(sc);
        }
        sc.close();
    }
}
// -------------------------------------------------------------------
