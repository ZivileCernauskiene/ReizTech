// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Branch myTry = new Branch();

myTry.branches.Add(new Branch());
myTry.branches[0].branches.Add(new Branch());
myTry.branches.Add(new Branch());
myTry.branches[1].branches.Add(new Branch());
myTry.branches[1].branches[0].branches.Add(new Branch());

Console.WriteLine(depthFinder(myTry));



int depthFinder(Branch structure)
{
    if (structure.branches.Count == 0)
    {
        return 1;
    }
    List<int> result = new List<int>();
    foreach(var x in structure.branches)
    {
        result.Add(depthFinder(x)+1);
    }
    return result.Max();
}
class Branch
{
    public List<Branch> branches=new List<Branch>();
}

