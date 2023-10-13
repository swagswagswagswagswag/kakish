# Юнит-тесты
В данном репозитории представлены функции с решением математических задач, а так же юнит тесты для тестирования данных функций </br>
**Когда спросил у Юлии сергеевны сколько должно быть юнит тестов**
![Когда спросил у Юлии Сергеевны сколько должно быть юнит тестов](https://github.com/swagswagswagswagswag/kakish/blob/master/1000%20%D0%BA%D1%80%D0%B0%D0%B9.jpg)</br>
# Описание программы
1. Создаются функции для решения определённых математических операций
2. Вывод решения на экран
3. Подключается проект юнит тестирования к проекту с решением
4. Прописывается код для юнит тестов
5. Запускается отладка тестирования
6. Результат выводится на экран</br>
**Как создавался данный проект**
![a](https://github.com/swagswagswagswagswag/kakish/blob/master/cs.jpg)
# Использование программы 

``` C#
﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using kakish;

namespace kakich_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4, Program.izum(2));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreNotEqual(4, Program.izum(3));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(Program.kuraga());
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsFalse(Program.kulich());
        }
        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsNull(Program.yaichko());
        }
        [TestMethod]
        public void TestMethod6()
        {
            Assert.IsNotNull(Program.luzin());
        }
        [TestMethod]
        public void TestMethod7()
        {
            Assert.IsNotInstanceOfType(Program.izum(2), typeof(double));
        }
        [TestMethod]
        public void TestMethod8()
        {
            Assert.IsInstanceOfType(Program.izum(2), typeof(int));
        }
        [TestMethod]
        public void TestMethod9()
        {
            StringAssert.Contains("ганс красава, собянин молодец", Program.aleksei());
        }
    }
}</br>
```
1. Откройте Visual studio
2. Нажмите в меню на вкладку тест
3. Нажмите на кнопку "запуск всех тестов"</br>
Ссылки на доп ресурсы</br>
https://www.youtube.com/watch?v=jjPAeo7YcZk</br>
https://www.youtube.com/shorts/lhLm8akXOTQ
