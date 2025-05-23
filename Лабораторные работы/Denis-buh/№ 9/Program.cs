﻿



/*
придумать не менее 5-ти разнотипных полей в классе. 
Разработать Windows-приложение, которое обеспечивает:
    1) создание коллекции из элементов класса +,
    2) добавление не менее 10 элементов в коллекцию +,
    3) удаление элементов из коллекции по некоторому правилу 
      (например, первый с начала и/или с конца, по некоторому критерию, выбору и прочее)+,
    4) отображение всех элементов коллекции +,
    5) переупорядочивание элементов коллекции по некоторому правилу и/или их сортировка 
      (в зависимости от вида коллекции в варианте) +,
    6) поиск необходимых элементов коллекции +,
    7) фильтрацию элементов коллекции с помощью операторов запросов LINQ +,
    8) применение двух любых методов расширений LINQ к элементам коллекции +.

Объект предметной области: Студент
Коллекция: Стек Stack<T>

Сущьности:
    1) Форма ввывод + она же main форма
    1.1) Добавить элемент
    1.2) Удалить элемент (конкретное элемент, правило)
    1.3) Поиск элемента коллекции  
    1.4) Фильтрация коллекции (разные виды фильтров)
    
    2) Студент-алкоголик
    2.0) Вывод данных организовать в виде множества 
    2.1) Количество лет
    2.2) Номер курса 
    2.3) Номер группы
    2.4) Процент hp
    2.5) Процент голода
*/




class Program{  
    static void Main(string[] args){  
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainForm());
    }  
}  