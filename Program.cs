using DesafioPOO.Models;

System.Console.WriteLine("Smartfone Nokia:");
Smartphone nokia = new Nokia("123456", "Modelo 1", "11111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.ReceberLigacao();

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartfone Iphone:");
Smartphone iphone = new Iphone("4987", "Modelo 2", "22222222", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.ReceberLigacao();