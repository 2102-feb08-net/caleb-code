using System;



  public class test1
  {
    public string name { get; set; }
    private string Id { get; set; }
    public decimal money { get; set; }

    public test1(string name, string id, decimal money){
        name = this.name;
        id = this.id;
        money = this.money;
    }
  

    public void drainAccount(test1 person)
    {
        if(person.name == "Nick")
        {
            person.money = 0;

        }
    }
}
