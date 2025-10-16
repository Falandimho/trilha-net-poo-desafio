using DesafioPOO.Models;

Console.WriteLine("Teste com o nokia");
Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");
Console.WriteLine("Teste com o Iphone");
Iphone iphone = new Iphone("987654321", "iPhone 13", "654321", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
