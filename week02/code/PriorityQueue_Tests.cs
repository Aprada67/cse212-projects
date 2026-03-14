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
    // Scenario: Enqueue three items with different priorities
    // Expected Result: Item with highest priority is dequeued
    // Defect(s) Found:
    public void TestPriorityQueue_RemoveHigh()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Alberto", 1);
        priorityQueue.Enqueue("Hector", 2);
        priorityQueue.Enqueue("Genesis", 1);

        var value = priorityQueue.Dequeue();

        Assert.AreEqual("Hector", value);
    }

    [TestMethod]
    // Scenario: Dequeue from empty queue
    // Expected Result: InvalidOperationException with correct message
    // Defect(s) Found: None
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }

}