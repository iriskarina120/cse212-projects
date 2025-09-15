using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue multiple elements with different priorities and dequeue one.
    // Expected Result: The value with the highest priority should be returned.     
    // Defect(s) Found: None
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Lucy", 2);
        priorityQueue.Enqueue("Marck", 3);
        priorityQueue.Enqueue("Jack", 1);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Marck", result);
    }

    [TestMethod]
    // Scenario: Enqueue two elements with the same maximum priority and Dequeue one of them.
    // Expected Result: The one added first, "Anne" (closest to the front) should be returned.
    // Defect(s) Found: None
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Lucy", 2);
        priorityQueue.Enqueue("Anne", 4);
        priorityQueue.Enqueue("Marck", 3);
        priorityQueue.Enqueue("Jack", 4);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Anne", result);
    }
    [TestMethod]
    // Scenario: Dequeue on an empty queue.
    // Expected Result: Throws an InvalidOperationException with the message: "The queue is empty."
    // Defect(s) Found: None
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        var ex = Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
        Assert.AreEqual("The queue is empty.", ex.Message);
    }

    [TestMethod]
    // Scenario: Enqueue multiple elements, the highest priority at the end.
    // Expected Result: The last,"Jack"(highest priority) element is successfully removed.
    // Defect(s) Found: The loop doesn't check the last element, so it never removes it.   
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Lucy", 1);
        priorityQueue.Enqueue("Anne", 2);
        priorityQueue.Enqueue("Marck", 3);
        priorityQueue.Enqueue("Jack", 4);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Jack", result);
    }

    // Add more test cases as needed below.
}