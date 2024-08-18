// https://www.c-sharpcorner.com/UploadFile/damubetha/solid-principles-in-C-Sharp/
// LSP = Parent & child class k ak e vabe babohar korte parte hobe.
//This principle is only for Inheritance. We know, Inheritance apply like (is a relation). but
// there are something more. 


// Jamon Product , (Car, Clock)  er example ta vaba jete pare. Abar chessboard, 3dChessBoard er
// example vaba jete pare

using Solid_LSP_examples;
using System.Transactions;


Car car = new Car();
Clock clock = new Clock();
car.Name = "Jamaloon";
car.Price = (int)1e7;
car.Weight = 1e3;
car.Speed = (int)1e3;

clock.Name = "Casio";
clock.Weight = 132.23;
clock.Time = new DateTime(2022 / 09 / 11);
clock.Price = 3223; // here we can got the price of clock but it don't have a price. It break the LSP. 



// Chessboard example ------------------------------------------------------------------------------------------------
ChessBoard3D1 chessBoard3D1 = new ChessBoard3D1(2);
chessBoard3D1.AddPiece(3, 4);   // wrong inhertance er jonne ei problem

