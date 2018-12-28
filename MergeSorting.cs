//implement mergesort
// 3 5 7 1 2
// 1 2 3 5 7 
using System;

class MergeSorting {

  public static void mergeSort(int[] integers) {
    if(integers.Length > 1) {
      int mid=(integers.Length)/2;
      int n1 = mid; 
      int n2 = integers.Length-mid;
      int[] l = new int[n1]; 
      int[] r=new int[n2]; 
      for (int m=0; m<n1; m++) { 
            l[m] = integers[m]; 
      }
      for (int n=0; n<n2; n++) {
          r[n] = integers[mid + n]; 
      }
      mergeSort(l);
      mergeSort(r);

      int i,j,k;
      i=j=k=0;
      while(i< l.Length && j < r.Length) {
        if (l[i] < r[j]) {
          integers[k]=l[i];
          i+=1;
        }
        else {
          integers[k]=r[j];
          j+=1;
        } 
        k+=1;
      }

      while (i<l.Length){
      integers[k]=l[i];
      i+=1;
      k+=1;
      }
    
    while (j< r.Length) {
      integers[k]=r[j];
      j+=1;
      k+=1;
    }
  }
  }

  public static void printArray(int[] integers){
    for(int i=0;i<integers.Length;i++) {
    Console.Write(integers[i]+ " ");
    }
  }
 
  public static void Main(String[] args) {
    
    Console.WriteLine("Please enter the list of numbers:");
    string st=Console.ReadLine();
    string [] nums=st.Split();
    int [] integers=new int[nums.Length];
    for(int i=0;i<nums.Length;i++) {
      integers[i]=(Convert.ToInt32(nums[i]));
    }
    mergeSort(integers);
    printArray(integers);
  }
}
