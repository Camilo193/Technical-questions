using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    /*This is a Class to give responses in the API's
     * Data would take any type of class, struct or primitive variable
     * where T : struct, means that T only can be a struct (Primitive variables are structs)
     * But you can use where T : class. Means T only can be a class
     * If you don't define where T, how you imagine, means T can be anything 
     * You can define a lot of T behaviors: where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>, etc...
     * You can have two or more differents generics in the same class: Response<T, Y, X, Z>
    */

    public class Response<T> where T : struct 
    {
        //In this particular case, data gonna be a primitive variable
        public T Data { get; set; }

        public bool IsSuccess { get; set; }

        public string Message { get; set; }
    }

    public class Response2<T> where T : class
    {
        public T Data { get; set; }

        public bool IsSuccess { get; set; }

        public string Message { get; set; }
    }

    //You can't combine struct, class, notnull and default in where T :
    //public class Response3<T> where T : struct, class
    //{
    //    public T Data { get; set; }

    //    public bool IsSuccess { get; set; }

    //    public string Message { get; set; }
    //}

    public class Response4<T>
    {
        public T Data { get; set; }

        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        //public static implicit operator string(Response4<string> v)
        //{
        //    throw new NotImplementedException();
        //}
    }

    //Generic class with multiples generics
    public class Response5<T,X,Y,Z>
    {
        public T Data { get; set; }

        public X Data2 { get; set; }

        public Y Data3 { get; set; }

        public Z Data4 { get; set; }
    }

    //If you have multiple generics, each one can have their where
    public class Response6<T, X, Y, Z> where T : struct where X : struct
    {
        public T Data { get; set; }

        public X Data2 { get; set; }

        public Y Data3 { get; set; }

        public Z Data4 { get; set; }
    }
}
