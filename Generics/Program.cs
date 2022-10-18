using Generics;

//This can't be possible, because string isn't a struct, it's a class
//Response<string> response = new Response<string>();

//Response2 has where T : class
Response2<string> response2 = new();

//It can't be possible, because string isn't a class, it's a struct
//Response2<bool> response3 = new();

//Response 4 can be struct and class at the same time
Response4<string> response4 = new();
Response4<bool> response4_1 = new();

//I define response4 as a string
response4.Data = "I define this variable as String";

//I define response4_1 as a bool
response4_1.Data = true;

//Note that response4 and response4_1 belong to the same class and you can define as string or bool


//Response5 has 4 generics:
Response5<string, bool, char, dynamic>  response5 = new();

response5.Data = "I'm a string";
response5.Data2 = true;
response5.Data3 = 'F';
response5.Data4 = "I'm a dynamyc, so I can be string, bool, char. But dynamic is different to generics";

dynamic parcero = "Hola";
parcero = 5;

