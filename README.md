вопрос №1
C# библиотека для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
Юнит-тесты
Легкость добавления других фигур
Вычисление площади фигуры без знания типа фигуры в compile-time
Проверка на то, является ли треугольник прямоугольным 

вопрос №2
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов.
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

ответ:
SELECT Products.Name AS ProductName, Categories.Name AS CategoryName
FROM Products
LEFT JOIN ProductCategory ON Products.ProductID = ProductCategory.ProductID
LEFT JOIN Categories ON ProductCategory.CategoryID = Categories.CategoryID;
