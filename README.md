1. Создаем одномерный строчный массив A

2. Определяем длину будущего нового массива В, для этого проверяем длину каждого элемента в массиве А.

    Длина элемента в массиве А меньше 4 символов?

    Нет-->Увеличиваем счетчик позиции проверяемого элемента в массиве А  
        Да--> Увеличиваем счетчик количества подходящих под условие элементов(длину массива В). Увеличиваем счетчик позиции проверяемого элемента в массиве А

3. Дошли до конца массива A?
    Нет--> к пункту 2
    Да --> к пункту 4

4. Создаем новый строчный массив B, исходя из полученной выше длины массива

5. Повторно проходим по элементам массива А, проверяя их длину.Количество символов в элементе массива < 4?

    Нет --> Увеличиваем счетчик позиции проверяемого элемента в массиве А  
    Да --> Присваиваем элементу массива В значение элемента массива А.Увеличиваем счетчик позиции проверяемого элемента в  массиве А и счетчик позиции элемента в массиве В.

6. Дошли до конца массива A  
Нет--> к пункту 5  
Да --> к пункту 7

7. Выводим на печать массив В

