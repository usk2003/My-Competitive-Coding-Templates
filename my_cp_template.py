# Author: Urlana Suresh Kumar (usk2003)
# -------------------------------------------------------------------

from math import gcd
from functools import lru_cache

MOD = 1000000007

# Useful Functions
def lcm(a, b):
    return a // gcd(a, b) * b

def power(a, b, mod=MOD):
    res = 1
    a %= mod
    while b > 0:
        if b % 2:
            res = (res * a) % mod
        a = (a * a) % mod
        b //= 2
    return res

def mod_inverse(a, mod=MOD):
    return power(a, mod - 2, mod)

def is_prime(n):
    if n <= 1:
        return False
    if n <= 3:
        return True
    if n % 2 == 0 or n % 3 == 0:
        return False
    i = 5
    while i * i <= n:
        if n % i == 0 or n % (i + 2) == 0:
            return False
        i += 6
    return True

@lru_cache(None)
def factorial(n, mod=MOD):
    if n == 0 or n == 1:
        return 1
    return (n * factorial(n - 1, mod)) % mod

def nCr(n, r, mod=MOD):
    if r > n:
        return 0
    num = factorial(n, mod)
    denom = (factorial(r, mod) * factorial(n - r, mod)) % mod
    return (num * mod_inverse(denom, mod)) % mod

def nPr(n, r, mod=MOD):
    if r > n:
        return 0
    num = factorial(n, mod)
    denom = factorial(n - r, mod)
    return (num * mod_inverse(denom, mod)) % mod

# -------------------------------------------------------------------
def solve():
    n, q = map(int, input().split())
    # Add logic for problem-solving here.

import sys
input = sys.stdin.read
data = input().splitlines()
t = int(data[0])
cases = data[1:]
    
for i in range(t):
    solve()

# -------------------------------------------------------------------
