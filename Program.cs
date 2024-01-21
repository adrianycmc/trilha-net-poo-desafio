using System.Runtime.CompilerServices;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Implementado

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "00-12345-6789", modelo: "A40", imei: "nokia@teste1.com", memoria: 240);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");

//Implementações extras
//DATA 
nokia.Data();
//RELOGIO
nokia.Relogio();
//AGENDA
nokia.AdicionarItemNaAgenda("23/01 | ", "Painel da Avanade");
nokia.ListarItemAgenda();
nokia.RemoverItemAgenda("23/01 | ", "Painel da Avanade");
nokia.ListarItemAgenda();

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "00-12345-6789", modelo: "15C", imei: "iphone@teste2.com", memoria: 127);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Teams");

//Implementações extras
//DATA
iphone.Data();
//RELOGIO
iphone.Relogio();
//AGENDA
iphone.ListarItemAgenda();