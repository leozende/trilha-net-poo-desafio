using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "4343567", modelo: "Modelo 5", imei: "4444444444", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "3529385", modelo: "Modelo 3", imei: "233233333", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");