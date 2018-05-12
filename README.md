# ParkingAPI
My third homework (bsa 18). ASP.NET Core Web API Application

Academy'18 • 2nd stage • 3. .NET Core
На основі домашньої роботи №2 необхідно реалізувати ASP.NET Core Web API додаток (не потрібно розробляти графічний інтерфейс).

Доступ до всього функціоналу повинен бути реалізований за допомогою WebAPI і кожен метод буде повертати JSON об’єкти. Для тестування роботи додатка можна скористатися наступними тулзами: Postman (https://www.getpostman.com/) або Fiddler (https://www.telerik.com/fiddler)

Solution повинен містити два проекти:
*ASP.NET Core з відкритим REST API

*Class Library який буде містити всю логіку для роботи з парковкою

REST API:
Cars
-Список всіх машин (GET)

-Деталі по одній машині (GET)

-Видалити машину (DELETE)

-Додати машину (POST)

Parking
-Кількість вільних місць (GET)

-Кількість зайнятих місць (GET)

-Загальний дохід (GET)

Transactions
-Вивести Transactions.log (GET)

-Вивести транзакції за останню хвилину (GET)

-Вивести транзакції за останню хвилину по одній конкретній машині (GET)

-Поповнити баланс машини (PUT)
