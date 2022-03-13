SELECT Product.name, Category.name 
FROM Products 
LEFT JOIN Category ON Products.Id = Category.ProductId
ORDER BY Product.name
