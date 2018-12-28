//Prime or not

using System;

class Primes {
  static void Main(String[] args) {
    Console.WriteLine("Please enter the number:");
    int n=Convert.ToInt32(Console.ReadLine());
    int j;
    for(j=2;j<=(n/j);j++) {
      if (n%j==0) break;
    }
    if (j> (n/j)) {
      Console.WriteLine("{0} is prime",n);
    }
    else {
      Console.WriteLine("{0} is not prime",n);
    }
    Console.ReadLine();
  }
}
