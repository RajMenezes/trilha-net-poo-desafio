using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "12345678", modelo: "C3", imei: "112233344455", memoria: 8);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\nSmartphone Iphone:");
Smartphone iphone = new Iphone(numero: "12345678", modelo: "C3", imei: "112233344455", memoria: 8);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
