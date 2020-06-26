using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter salesperson name: ");
    var name = Console.ReadLine();
    Console.WriteLine ("Enter sales amount: ");
    var s = Console.ReadLine();
    var sales = Convert.ToInt32(s);
    var commission = 200 + (0.09 * sales);
    Console.WriteLine ("Sales commission for " + name + " is $" + commission);
    
    if (sales <= 2999){
      Console.WriteLine ("Performance is poor");
    }
    else if (sales >= 3000 && sales <= 4999){
      Console.WriteLine ("Performance is average");
    }
    else if (sales >=5000 && sales <= 9999){
      Console.WriteLine ("Performance is good");
    }
    else if (sales >= 10000 && sales <= 14999){
    Console.WriteLine ("Performance is excelent");
    }
    else if (sales >= 15000){
    Console.WriteLine ("Performance is outstanding");
    }

  }
}

