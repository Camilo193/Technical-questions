#region Equals vs ==
/* The Equals() method compares only content.
 * The Equality operator == is used to compare the reference identity. (content and reference)
 */

using System.Runtime.InteropServices;

string str = "hello";
string str2 = str;

//Gettin memory address or reference address
IntPtr memoryoStr = GCHandle.Alloc(str, GCHandleType.Pinned).AddrOfPinnedObject();
IntPtr memoryoStr2 = GCHandle.Alloc(str2, GCHandleType.Pinned).AddrOfPinnedObject();

Console.WriteLine("== vs Equals with same variable with same reference: \n");

Console.WriteLine("Using == operator: {0}, Adress: {1}", str == str2, memoryoStr); //True (Same reference and content)
Console.WriteLine("Using equals() method: {0}, Adress: {1}", str.Equals(str2), memoryoStr2); //True (Same content)

object str3 = "hello";
char[] values = { 'h', 'e', 'l', 'l', 'o' };
object str4 = new string(values);

//Gettin memory address or reference address
IntPtr memoryoStr3 = GCHandle.Alloc(str3, GCHandleType.Pinned).AddrOfPinnedObject();
IntPtr memoryoStr4 = GCHandle.Alloc(str4, GCHandleType.Pinned).AddrOfPinnedObject();

Console.WriteLine("\n == vs Equals with same variable with different reference \n");

Console.WriteLine("Using == operator: {0}, Adress: {1}", str3 == str4, memoryoStr3); //False
//False because despite it has the same content (str3 = "hello and str4 = "hello"),
//it has different type (str3 is a String and str4 is an Object, so they have different reference)

Console.WriteLine("Using equals() method: {0}, Adress: {1}", str3.Equals(str4), memoryoStr4); //True
//True because it has the same content (str3 = "hello and str4 = "hello")

double e = 2.718281828459045;
double d = e;
object o1 = d;
object o2 = e;

IntPtr memoryO1 = GCHandle.Alloc(o1, GCHandleType.Pinned).AddrOfPinnedObject();
IntPtr memoryO2 = GCHandle.Alloc(o2, GCHandleType.Pinned).AddrOfPinnedObject();

Console.WriteLine("\n Two differents objects with the same content: \n");

Console.WriteLine("Using == method: {0}, reference address: {1}", d == e, memoryO1); //True 
//True because it has same content and reference
Console.WriteLine("Using == method: {0}, referen adress: {1}", o1 == o2, memoryO2); //False
//False because despite it has same content and same type (object) it has different reference

#endregion