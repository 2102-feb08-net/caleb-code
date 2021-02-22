using System;



  public class test1
  {
    public string Name { get; set; }
    private string Id { get; set; }
    public decimal Money { get; set; }

    public test1(string name, string id, decimal money){
        Name = name; 
        Id = id;
        Money = money;
    }
  

    public void drainAccount(test1 person)
    {
        if(person.Name == "Nick")
        {
            person.Money = 0;

        }
    }
}
