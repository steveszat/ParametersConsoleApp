// See https://aka.ms/new-console-template for more information
DoSomething();
void DoSomething()
{
    Console.WriteLine("Consider it done!");
    int x = 22;
    Console.WriteLine($"Initial value = {x}");
    InParameter(x);
    Console.WriteLine($"In Value after: {x}");
    OutParameter(out x);
    Console.WriteLine($"Out Value after: {x}");
    ReferenceParameter(ref x);
    Console.WriteLine($"Ref Value after: {x}");

}

void InParameter(in int someNumber)
{
    Console.WriteLine($"Value before: {someNumber}");
    Console.WriteLine("in parameter cannot be modified");
}

void ReferenceParameter(ref int someNumber)
{
    Console.WriteLine($"Value before: {someNumber}");
    someNumber++;

}

void OutParameter(out int someNumber)
{
    Console.WriteLine($"Parameter cannot be referenced because it is uninitialized");
    someNumber = 44;
}