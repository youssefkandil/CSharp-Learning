using System;

public class PracticeObject
{
    private readonly int id;

    public PracticeObject(int id)
    {
        this.id = id;
        Console.WriteLine($"Object {id} created.");
    }

    // A C# destructor is called a finalizer. The garbage collector runs it
    // sometime after this object is no longer reachable.
    ~PracticeObject()
    {
        Console.WriteLine($"Object {id} finalized.");
    }
}

public class DestructorPractice
{
    public static void Main()
    {
        var objects = new PracticeObject[1000];

        for (int i = 0; i < objects.Length; i++)
        {
            objects[i] = new PracticeObject(i + 1);
        }

        Console.WriteLine($"All 1,000 objects have been created and the space is {GC.GetTotalMemory(false):N0} bytes.");

        // Drop the references so the objects can be collected.
        Array.Clear(objects);

        // Force collection for this learning demo so you can see finalizers run.
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine($"Finished waiting for finalizers. The space is now {GC.GetTotalMemory(true):N0} bytes.");
    }
}
