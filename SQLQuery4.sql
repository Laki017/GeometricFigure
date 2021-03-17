SELECT P."Name", C."Name"
FROM Products P
LEFT JOIN Product_Category PC
	ON P.Id = PC.ProductId
LEFT JOIN Category C
	ON PC.CategoryId = C.Id;