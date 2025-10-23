using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Nokia n = new Nokia("123456789", "Nokia 6.1", "123456789012345", 32);
n.Ligar();
n.ReceberLigacao();
n.InstalarAplicativo("WhatsApp");


Console.WriteLine("\nSmartphone iPhone:");
Iphone i = new Iphone("987654321", "iPhone 12", "987654321098765", 128);
i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("Telegram");