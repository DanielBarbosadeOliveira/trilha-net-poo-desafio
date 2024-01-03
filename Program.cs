using System.Reflection.Metadata.Ecma335;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("SmartPhone Nokia: ");
Smartphone nokia = new Nokia(numero: "999088840", modelo: "Modelo1", imei: "11111111", memoria: 68);
nokia.Ligar();
nokia.InstalarAplicativo("Ifood");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone iPhone: ");
Smartphone iphone = new Iphone(numero: "33226319", modelo: "11 Pro Max", imei: "2222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Uber");