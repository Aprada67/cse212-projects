using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue one item and dequeue it
    // Expected Result: The same item should be returned
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Alberto", 1);
        var value = priorityQueue.Dequeue();

        Assert.AreEqual("Alberto", value);
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("Alberto", 1);
        priorityQueue.Enqueue("Steven", 2);
        priorityQueue.Enqueue("Geneis", 1);

        var value = priorityQueue.Dequeue();

        Assert.AreEqual("Steven", value);
        // Add more test cases as needed below.
    }

}