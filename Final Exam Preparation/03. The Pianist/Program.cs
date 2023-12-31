﻿int numberOfPieces = int.Parse(Console.ReadLine());

static void ChangeKeyIfExists(Dictionary<string, Piece> pieces, string[] tokens, string name)
{
    string newKey = tokens[2];

    if (pieces.ContainsKey(name))
    {
        pieces[name].Key = newKey;
        Console.WriteLine($"Changed the key of {name} to {newKey}!");
    }
    else
    {
        Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
    }
}

static void RemovePieceIfExists(Dictionary<string, Piece> pieces, string name)
{
    if (pieces.ContainsKey(name))
    {
        pieces.Remove(name);
        Console.WriteLine($"Successfully removed {name}!");
    }
    else
    {
        Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
    }
}

static void AddPieceIfDoesNotExists(Dictionary<string, Piece> pieces, string[] tokens, string name)
{
    if (!pieces.ContainsKey(name))
    {
        string composer = tokens[2];
        string key = tokens[3];
        pieces[name] = new Piece(name, composer, key);
        Console.WriteLine($"{name} by {composer} in {key} added to the collection!");
    }
    else
    {
        Console.WriteLine($"{name} is already in the collection!");
    }
}

Dictionary<string, Piece> pieces = new Dictionary<string, Piece>();

for (int i = 0; i < numberOfPieces; i++)
{
    string[] info = Console.ReadLine()
        .Split("|", StringSplitOptions.RemoveEmptyEntries);

    string name = info[0];
    string composer = info[1];
    string key = info[2];

    pieces[name] = new Piece(name, composer, key);
}

string input;
while ((input = Console.ReadLine()) != "Stop")
{
    string[] tokens = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
    string command = tokens[0];
    string name = tokens[1];

    if (command == "Add")
    {
        AddPieceIfDoesNotExists(pieces, tokens, name);
    }
    else if (command == "Remove")
    {
        RemovePieceIfExists(pieces, name);
    }
    else if (command == "ChangeKey")
    {
        ChangeKeyIfExists(pieces, tokens, name);
    }
}

foreach (var piece in pieces.Values)
{
    Console.WriteLine($"{piece.Name} -> Composer: {piece.Composer}, Key: {piece.Key}");
}

class Piece
{
    public string Name { get; set; }
    public string Composer { get; set; }
    public string Key { get; set; }

    public Piece(string name, string composer, string key)
    {
        Name = name;
        Composer = composer;
        Key = key;
    }
}