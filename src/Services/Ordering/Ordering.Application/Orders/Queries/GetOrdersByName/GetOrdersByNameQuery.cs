namespace Ordering.Application.Orders.Queries.GetOrdersByName;

public record GetOrdersByNameQuery(string name) : IQuery<GetOrderByNameQueryResult>;

public record GetOrderByNameQueryResult(IEnumerable<OrderDto> Orders);
