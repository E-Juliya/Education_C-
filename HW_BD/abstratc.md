# Конспект лекций по базам данных
**SELECT** для выбора столбцов таблицы 

**FROM** имя_таблицы

**SELECT*** (SELECT + звёздочка) для выбора всех столбцов таблицы *(SELECT * FROM ИМЯ_ТАБЛИЦЫ)*

**WERE** для выбора определённых строк таблицы вместе с оператором SELECT *(SELECT ИМЯ_СТОЛБЦА FROM ИМЯ_ТАБЛИЦЫ WHERE УСЛОВИЕ)*


**Предикаты** - слова IN, OR, BETWEEN, LIKE в секции WHERE - также позволяют выбрать определённые диапазоны значений (IN, OR, BETWEEN) или значения в строках (LIKE), которые требуется выбрать из таблицы. 

    SELECT ИМЯ_СТОЛБЦА FROM ИМЯ_ТАБЛИЦЫ 
      WHERE ЗНАЧЕНИЕ    
      ПРЕДИКАТ (IN, OR, BETWEEN) (ЗНАЧЕНИЯ,УКАЗЫВАЮЩИЕ ДИАПАЗОН)

    SELECT Name, Job, Years
       FROM Staff
	     WHERE Salary BETWEEN 15000 AND 17000

    SELECT Name, Job, Years
      FROM Staff
	      WHERE Name LIKE 'S_

# Типы данных

Можно подсмотреть тут: [https://sql-language.ru/osnova-sql/tipy-dannykh-sql.html]