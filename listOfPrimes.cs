//List of primes till a given number

using System;

class Primes {
  static void Main(String[] args) {
    Console.WriteLine("Please enter the number:");
    int n=Convert.ToInt32(Console.ReadLine());
    int i,j;
    for(i=2;i<n;i++) {
      for(j=2;j<=(i/j);j++) {
        if (i%j==0) break;
      }
      if (j> (i/j)) {
        Console.WriteLine("{0} is prime",i);
      }
    }
    Console.ReadLine();
  }
}
