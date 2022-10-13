using PrototypeDesignPattern;

SandwichMenu sandwichMenu = new();

// Initialize custom sandwiches
sandwichMenu["LoadedBLT"] = new Sandwich("Wheat", "Turkey, Bacon", "American", "Lettuce, Tomato, Onion, Olives");
sandwichMenu["Turkey"] = new Sandwich("Rye", "Turkey", "Swiss", "Lettuce, Onion, Tomato");
sandwichMenu["ThreeMeatCombo"] = new Sandwich("Rye", "Turkey, Ham, Salami", "Provolone", "Lettuce, Onion");

// Clone these sandwiches
Sandwich? sandwich1 = sandwichMenu["LoadedBLT"].Clone() as Sandwich;
Sandwich? sandwich2 = sandwichMenu["Turkey"].Clone() as Sandwich;
Sandwich? sandwich3 = sandwichMenu["ThreeMeatCombo"].Clone() as Sandwich;

Console.WriteLine($"Sandwich - 1: {sandwich1?.GetDetails()}");
Console.WriteLine($"Sandwich - 2: {sandwich2?.GetDetails()}");
Console.WriteLine($"Sandwich - 3: {sandwich3?.GetDetails()}");

// Wait for user
Console.ReadKey();