using Fluxor;

namespace BlazorKnowledge.Flux.Store.Simple;

/// <summary>
/// This is the class that will hold the values of your state to be displayed in your application.
/// Note: State should be immutable, no setters!
/// </summary>
[FeatureState]
public sealed record SimpleState
{
    public int Counter { get; init; }

    public DateTimeOffset LastModified { get; init; } = DateTimeOffset.Now;
}

/// <summary>
/// this action can be dispatched to set a new value for the counter state
/// </summary>
public sealed record SimpleSetCounterAction(int NewValue);

/// <summary>
/// Reducer can change the state using the data from an action
/// preferably a static class with static methods.
/// This is intentional since a Reducer method should be a pure method with no side effects.
/// if you find yourself needing to inject dependencies into a reducer then you might be taking the wrong approach.
/// </summary>
public static class SimpleReducers
{
    [ReducerMethod]
    public static SimpleState Reduce(SimpleState state, SimpleSetCounterAction action)
    {
        Console.WriteLine($"reducing action {action.NewValue}");
        return state with { Counter = action.NewValue, LastModified = DateTimeOffset.Now };
    }
}
