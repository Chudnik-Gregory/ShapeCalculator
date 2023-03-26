# SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
SELECT p.ProductName, c.CategoryName
FROM Products p
LEFT OUTER JOIN ProductCategories pc ON p.ID = pc.ProductId
LEFT OUTER JOIN categories c ON pc.categoryid = c.ID;
