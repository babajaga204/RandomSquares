// See https://aka.ms/new-console-template for more information

using RandomSquares;

var cell = new VirtualScreenCell();
cell.AddLowerLeftCorner();
cell.AddVertical();

Console.WriteLine(cell.GetCharacter());