namespace dotnet_linq_to_object
{
  public class MyData {
    private static int lastId = 0;
    public int id;
    public MyData() {
      this.id = ++lastId;
      for(int i = 0; i < 1000000; i++){
        var garbageString = "garbage";
        garbageString += " + additional garbage";
      }
    }
    ~MyData() {
      System.Console.WriteLine("The End - #" + this.id);
    }
  }
}