
string[] strings= { "ab", "ab", "abc" };

string[] queries = { "ab", "abc", "bc" };
string results=string.Empty;

int[] result=new int[queries.Length];
for(int i=0;i<queries.Length;i++)
{
    for(int j = 0; j < strings.Length; j++)
    {
        if (queries[i].Equals(strings[j]))
        {
            result[i]= result[i]+1;
        }
    }    
}
result.ToList();

    foreach(int i in result.ToList())
{
    Console.WriteLine(i);
}