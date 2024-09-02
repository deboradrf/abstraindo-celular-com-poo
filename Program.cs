﻿using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1234", modelo: "Modelo 1", imei: "111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine("\n");
Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "5678", modelo: "Modelo 2", imei: "222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Twitter");