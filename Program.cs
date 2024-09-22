using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("123456", "Nokia 3210", "11111", "4 GB" );
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone("454545", "Iphone 8 Pro", "22222", "16 GB");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");