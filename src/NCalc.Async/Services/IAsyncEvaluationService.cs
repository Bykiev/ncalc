using NCalc.Domain;
using NCalc.Handlers;

namespace NCalc.Services;

/// <summary>
/// Service used to asynchronous evaluate the result of a <see cref="LogicalExpression"/>
/// </summary>
public interface IAsyncEvaluationService
{
    public event AsyncEvaluateFunctionHandler? EvaluateFunctionAsync;
    public event AsyncEvaluateParameterHandler? EvaluateParameterAsync;

    Task<object?> EvaluateAsync(LogicalExpression expression, AsyncExpressionContext context);
}