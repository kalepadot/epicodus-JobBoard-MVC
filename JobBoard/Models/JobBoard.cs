using System.Collections.Generic;

namespace JobBoard.Models
{
  public class Posting
  {
    public string Company { get; set; }
    public string Title { get; set; }
    public int Salary { get; set; }
    private static List<Posting> _instances = new List<Posting> {};

    public Posting (string company, string title, int salary)
    {
      Company = company;
      Title = title;
      Salary = salary;
      _instances.Add(this);
    }
     public static List<Posting> GetAll()
    {
      return _instances;
    }
  }
}