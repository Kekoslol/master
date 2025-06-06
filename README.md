
# Фильтрация строк по длине (C#)

## 📌 Условие задачи

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
**Не использовать коллекции**, только массивы.

## 🧠 Алгоритм

1. Подсчитать количество строк длиной ≤ 3.
2. Создать новый массив нужной длины.
3. Перенести подходящие строки.
4. Вывести результат.

## 🧾 Пример работы программы

**Входной массив:**  
`{ "123", "hello", "hi", ":-)", "world", "OK" }`  

**Результат:**  
```
Новый массив строк (длина <= 3):
123
hi
:-)
OK
```

## 💻 Программа

Код находится в файле `Program.cs`.

## 🗺 Блок-схема

Смотри `docs/algorithm.png`

---

## 📁 Структура проекта

```
FilterShortStrings/
├── src/
│   └── Program.cs
├── docs/
│   └── algorithm.png
├── README.md
└── .gitignore
```

## 👨‍💻 Автор

Создано в рамках учебного задания.
