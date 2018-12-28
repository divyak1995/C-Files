using System;
using System.Text;

class Reverse {
  public static String reverseString(String st) {
    int n=st.Length;
    StringBuilder s=new StringBuilder("");
    for (int i=n-1; i>=0;i--) {
      s.Append(st[i]);
    }
    return s.ToString();
  }

  public static void Main(String[] args) {
    Console.WriteLine("Please enter the string :");
    string st=Console.ReadLine();
    string result=reverseString(st);
    Console.WriteLine(result);
  }
}
