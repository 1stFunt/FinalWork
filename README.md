## **Задача:**
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

---
## **Описание решения:**
Задаём два массива, где в первый внесены некоторые строки, а второй массив пустой и равен длине первого. 
Создаём метод, в котором с помощью цикла сравниваем длину каждой строки, принадлежащую текущему индексу первого массива. 
Если длина строки меньше или равна трём символам, то записываем данную строку во второй массив через переменную "count", которая параллельно с индексом массива увеличивается на +1, пока заданная в методе проверка не пройдёт по всем индексам первого массива.

---
****Блок-схема расположена в PNG файле - flowchart.png***