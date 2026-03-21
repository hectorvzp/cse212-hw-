using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with different priorities
    // Expected Result: Item with highest priority is removed first
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var queue = new PriorityQueue();

        queue.Enqueue("A", 1);
        queue.Enqueue("B", 5);
        queue.Enqueue("C", 3);

        var result = queue.Dequeue();

        Assert.AreEqual("B", result);
    }
    [TestMethod]
    // Scenario: Add items with same priority
    // Expected Result: First inserted item is removed first
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var queue = new PriorityQueue();

        queue.Enqueue("A", 5);
        queue.Enqueue("B", 5);
        queue.Enqueue("C", 5);

        var result = queue.Dequeue();

        Assert.AreEqual("A", result);
    }
    [TestMethod]
    // Scenario: Dequeue from empty queue
    // Expected Result: Exception is thrown
    // Defect(s) Found: 
    public void TestPriorityQueue_Empty()
    {
        var queue = new PriorityQueue();

        try
        {
            queue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}