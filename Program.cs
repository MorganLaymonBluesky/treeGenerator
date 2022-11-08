using Outside;

// All classes MUST inherit from Object
// Therefore, they will all have the four functions of: ToString, GetType, Equals, and GetHashCode

var forest = new Tree[10000];

for (int i = 0; i < forest.Length; i++)
{
    forest[i] = new Tree();
}

foreach (var tree in forest)
{
    Console.WriteLine(tree + "\n");
}