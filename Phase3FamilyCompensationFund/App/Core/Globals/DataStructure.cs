using Phase3FamilyCompensationFund.App.Model;

namespace Phase3FamilyCompensationFund.App.Core.Globals;

public abstract class DataStructure
{
    private static readonly Stack<AffiliateDataStructure> AffiliatesStack = new();
    private static readonly List<AffiliateDataStructure> AffiliatesList = [];
    private static readonly Queue<AffiliateDataStructure> AffiliatesQueue = new();
    
    public static void AddToStack(AffiliateDataStructure dataStructure) => AffiliatesStack.Push(dataStructure);
    public static void AddToList(AffiliateDataStructure dataStructure) => AffiliatesList.Add(dataStructure);
    public static void AddToQueue(AffiliateDataStructure dataStructure) => AffiliatesQueue.Enqueue(dataStructure);
    
    public static Stack<AffiliateDataStructure> GetStack() => AffiliatesStack;
    public static List<AffiliateDataStructure> GetList() => AffiliatesList;
    public static Queue<AffiliateDataStructure> GetQueue() => AffiliatesQueue;
    
    public static void RemoveFromStack()
    {
        if (AffiliatesStack.Count > 0) AffiliatesStack.Pop();
    }

    public static void RemoveFromList(int index)
    {
        if (index >= 0 && index < AffiliatesList.Count) AffiliatesList.RemoveAt(index);
    }

    public static void RemoveFromQueue()
    {
        if (AffiliatesQueue.Count > 0) AffiliatesQueue.Dequeue();
    }
}