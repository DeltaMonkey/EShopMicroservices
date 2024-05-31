using FluentValidation;

namespace Ordering.Application.Orders.Commands.DeleteOrder;

public record DeleteOrderCommand(Guid OrderId) : ICommand<DeleteOrderResponse>
{
}

public record DeleteOrderResponse(bool IsSuccess);

public class DeleteorderCommandValidator : AbstractValidator<DeleteOrderCommand>
{
    public DeleteorderCommandValidator()
    {
        RuleFor(x => x.OrderId).NotEmpty().WithMessage("OrderId is required");
    }
}
