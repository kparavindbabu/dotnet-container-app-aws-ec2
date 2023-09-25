namespace ProductCRUD.Dtos.Products;

public record CreateProductRequest(string Name, string Description, decimal Price);
