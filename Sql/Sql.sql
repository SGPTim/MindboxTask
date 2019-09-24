Использую таблицы:
Product - таблица с продуктами.
Category - таблица с категориями.
Т.к. в этом задании связь many-to-many, то при проектировании такой системы следовало создать таблицу для связи. Буду считать что она есть и называется ProductCategoryRelation.


select Product.Name, Category.Name 
from product 
left join ProductCategoryRelation relation
on Product.Id = relation.ProductId
left join Category 
on Category.Id = relation.CategoryId 
