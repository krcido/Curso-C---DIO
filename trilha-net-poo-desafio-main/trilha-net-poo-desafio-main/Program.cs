using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero: "15991000000", modelo: "AA34", 
                             imei: "1234567891011", memoria:64);
Smartphone iphone = new Iphone(numero: "15991000000", modelo: "iPhone 13", 
                             imei:"1110987654321", memoria:512);

Console.WriteLine("Smartphone Nokia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("=======================================");

Console.WriteLine("Smartphone iPhone");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");