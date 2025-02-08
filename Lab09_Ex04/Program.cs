// See https://aka.ms/new-console-template for more information
var a1 = new AAA();  
var a2 = new AAA();  

    a1.b1 = 10;
    a1.b2 = 20;  
    a2.b1 = 30;
    a2.b2 = 40;  

    Console.WriteLine($"a1.b1 = {a1.b1}");  
    Console.WriteLine($"a1.b2 = {a1.b2}");  
    Console.WriteLine($"a2.b1 = {a2.b1}");  
    Console.WriteLine($"a2.b2 = {a2.b2}");  
    
class AAA
{
    public int b1;     
    public int b2;     
}

