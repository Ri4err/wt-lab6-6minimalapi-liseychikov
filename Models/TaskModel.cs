namespace wt_lab6_6minimalapi_liseychikov.Models;

public class TaskModel
{
     public int Id { get; set; }
     public string Name { get; set; } = "";
     public string Category { get; set; } = "";
     public int Price { get; set; }
     public bool IsAvaliable { get; set; }
}