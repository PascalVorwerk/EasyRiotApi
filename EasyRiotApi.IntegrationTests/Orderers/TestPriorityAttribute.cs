namespace EasyRiotApi.IntegrationTests.Orderers;

public class TestPriorityAttribute(int priority) : Attribute
{
    public int Priority { get; private set; } = priority;
}