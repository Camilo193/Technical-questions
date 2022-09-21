using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;
using Technical_question;

#region StringBuilder
/*  StringBuilder is used to give Mutability to a string
 *  It's especially useful when you need to interact multiple times with the same string
 *  Better performance because avoid to create new objects in the heap each type you interact with a string variables
*/
string firstName = "Juan Camilo";

//It doesn't replace nothing because string is inmutable, you must assign it to a variable
firstName.Replace('a', 'x');

//Now it's works but created a new object in the heap,
//getting bad perfomance in memory ussage in massive interactions with the same variable
firstName = firstName.Replace('a', 'x');

//It doesn't gonna create a object in the heap, because StringBuilder is mutable
StringBuilder firstNameBuilder = new("Juan Camilo");
//To modify just 1 variable, maybe the difference between StringBuilder and String is not much.
firstNameBuilder.Replace('a', 'x');
//So consider to use StringBuilder when you modified the same variable in multiple times

/* In the next test, we gonna use a Json with 1000 people
 * We gonna concat FirstName with LastName using StringBuilder vs String
 * We gonna compare the performance in time and memory usage
 */
#region StringBuilder Test
string path = (@"./people.json");

string workingDirectory = Environment.CurrentDirectory;
using (StreamReader r = new StreamReader(@"people.json"))
{
    #region Getting Json
    People person = new People();
    string json = r.ReadToEnd();
    List<People> people = JsonConvert.DeserializeObject<List<People>>(json);
    #endregion

    int i = 0;

    while (i < 5)
    {

        if (i != 0)
            people.AddRange(people);


        Console.WriteLine(people.Count);

        #region Test # 5 Concatenating with:       person.FirstName + " " + person.LastName;
        Stopwatch timeMeasure5 = new Stopwatch();

        timeMeasure5.Start();

        person.ConcatWithString(people);

        timeMeasure5.Stop();
        Console.WriteLine($"Time concatenating with string: {timeMeasure5.Elapsed.TotalMilliseconds} ms");
        #endregion

        #region Test # 6 Concatenating with:        stringBuilder.Append(person.FirstName).Append(person.LastName);
        Stopwatch timeMeasure6 = new Stopwatch();

        timeMeasure6.Start();

        person.ConcatWithStringBuilder(people);

        timeMeasure6.Stop();
        Console.WriteLine($"Time concatenating with string Builder: {timeMeasure6.Elapsed.TotalMilliseconds} ms");
        #endregion
        i++;
    }

    Console.WriteLine("Stop");

}

#endregion

#endregion

