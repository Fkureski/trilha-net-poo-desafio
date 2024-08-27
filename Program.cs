using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "0000-0000", modelo: "nokiaGT", imei: "11111111", memoria: 64);
nokia.InstalarAplicativo("snake");
nokia.Ligar();

Console.WriteLine("");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "9999-9999", modelo: "Iphpne 13Pro", imei:"222222", memoria: 256);
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();