using Elsa.Mediator.Contracts;

namespace Elsa.Mediator.Middleware.Command;

/// <summary>
/// Provides context for a command.
/// </summary>
public class CommandContext
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CommandContext"/> class.
    /// </summary>
    public CommandContext(ICommand command, ICommandStrategy commandStrategy, Type resultType, IDictionary<object, object> headers, IServiceProvider serviceProvider, CancellationToken cancellationToken)
    {
        Command = command;
        CommandStrategy = commandStrategy;
        ResultType = resultType;
        Headers = headers;
        ServiceProvider = serviceProvider;
        CancellationToken = cancellationToken;
    }

    /// <summary>
    /// Gets the command.
    /// </summary>
    public ICommand Command { get; init; }

    /// <summary>
    /// Gets the command strategy.
    /// </summary>
    public ICommandStrategy CommandStrategy { get; }

    /// <summary>
    /// Gets or sets the headers associated with the command context.
    /// </summary>
    public IDictionary<object, object> Headers { get; }

    /// <summary>
    /// Gets the service provider used to resolve services for the command context.
    /// </summary>
    public IServiceProvider ServiceProvider { get; }

    /// <summary>
    /// Gets the result type.
    /// </summary>
    public Type ResultType { get; init; }
    
    /// <summary>
    /// Gets the cancellation token.
    /// </summary>
    public CancellationToken CancellationToken { get; init; }
    
    /// <summary>
    /// Gets or sets the result.
    /// </summary>
    public object? Result { get; set; }
}