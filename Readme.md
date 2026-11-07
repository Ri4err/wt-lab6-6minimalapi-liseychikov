# Web Technologies — Lab 6: Minimal API

Документация RESTful API для управления списком задач (Tasks) с использованием ASP.NET Core Minimal API.

---

## 📋 Эндпоинты API

| Метод | URL | Назначение |
| :--- | :--- | :--- |
| **GET** | `/` | Проверка работоспособности API |
| **GET** | `/api/info` | Информация о приложении |
| **GET** | `/api/tasks` | Получить список всех задач (поддерживает поиск через `?search=...`) |
| **GET** | `/api/tasks/{id}` | Получить конкретную задачу по ID |
| **POST** | `/api/tasks` | Создать новую задачу (с автогенерацией ID) |
| **PUT** | `/api/tasks/{id}` | Изменить существующую задачу по ID |
| **DELETE** | `/api/tasks/{id}` | Удалить задачу по ID |

---

## 📊 HTTP-статусы ответа

* **`200 OK`** — успешное выполнение запроса (возвращает данные).
* **`201 Created`** — успешное создание объекта (возвращает объект и заголовок `Location`).
* **`204 No Content`** — успешное удаление объекта (тело ответа пустое).
* **`400 Bad Request`** — некорректные данные в запросе.
* **`404 Not Found`** — запрашиваемый ресурс (объект) не найден.

---

## 💡 Примеры JSON-запросов и ответов

### 1. Создание задачи (`POST /api/tasks`)
* **Тело запроса (Request Body):**
  ```json
  {
    "name": "Сдать лабораторную по Web",
    "category": "Учеба",
    "price": 0,
    "isAvaliable": true
  }

  GitHub:
https://github.com/Ri4err/wt-lab6-6minimalapi-liseychikov

Render:
https://wt-lab6-6minimalapi-liseychikov.onrender.com