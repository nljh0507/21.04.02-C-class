
using System;

class MainClass{
  int num;
  
  public static void Main (string[] args){
    MainClass mc = new MainClass();

    mc.num = 100;
    Console.WriteLine(mc.num);
  }
}

/*using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hi World~!");
    Console.Write ("Hi World~!\n");


    Console.WriteLine ("Hi World~!"+" Oh beautiful!");
    int s = 66 + 66;
    Console.WriteLine("\t"+s);

    Console.Write(
      "(C) Currency:\t{0:C} \n"+
      "(D) Decimal:\t{0:D} \n"+
      "(E) Scientific:\t{1:E} \n"+
      "(G) General:\t{0:G} \n", 
      123, 123.45f);
    //abvab
  }
}
*/