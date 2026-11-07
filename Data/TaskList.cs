using wt_lab6_6minimalapi_liseychikov.Models;
namespace wt_lab6_6minimalapi_liseychikov.Data;
public static class TaskList
{
    public static List<TaskModel> Tasks { get; } = new()
    {
        new TaskModel
        {
            Id = 1,
            Name = "Разработка приложения",
            Category = "Разработка",
            Price = 5000,
            IsAvaliable = true
        },
        new TaskModel
        {
            Id = 2,
            Name = "Оптимизация ПО",
            Category = "Оптимизация",
            Price = 3500,
            IsAvaliable = false
        },
        new TaskModel
        {
            Id = 3,
            Name = "Проверка кода на наличие ошибок",
            Category = "Проверка",
            Price = 2000,
            IsAvaliable = true
        },
        new TaskModel
        {
            Id = 4,
            Name = "Разработка плана для проекта",
            Category = "Разработка",
            Price = 3500,
            IsAvaliable = true
        },
        new TaskModel
        {
            Id = 5,
            Name = "Создание пользовательского интерфейса",
            Category = "Дизайн",
            Price = 6700,
            IsAvaliable = false
        }
    };
}