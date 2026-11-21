Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);

Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(25);
anastasia.TakeDamage(30);

Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

yaroslav.TakeDamage(-20);
Console.WriteLine($"После неверного урона: {yaroslav.Health}");

artem.TakeDamage(200);
Console.WriteLine($"После сильного урона, Артём: {artem.Health}");

yaroslav.Heal(10);
yaroslav.GainExperience(40);
yaroslav.GainExperience(25);

Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");

bool yaroslavAlive = yaroslav.IsAlive();
Console.WriteLine($"Ярослав жив: {yaroslavAlive}");
Console.WriteLine($"Артём жив: {artem.IsAlive()}");

if (yaroslavAlive) {
    Console.WriteLine("Ярослав может продолжать приключение.");
} else {
    Console.WriteLine("Ярослав больше не может сражаться.");
}

string info = yaroslav.GetInfo();
Console.WriteLine("Строка получена. Сейчас выведем её:");
Console.WriteLine(info);

Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());


Console.WriteLine();
Console.WriteLine("Самостоятельный блок: Game");

Game hades = new Game("Hades", "Roguelike", 9);
Game stardew = new Game("Stardew Valley", "Симулятор фермы", 8);

Console.WriteLine($"Часов игры до вызова: {hades.HoursPlayed}");
hades.AddPlayTime(12);
Console.WriteLine($"После AddPlayTime(12): {hades.HoursPlayed}");
hades.AddPlayTime(-3);
Console.WriteLine($"После AddPlayTime(-3): {hades.HoursPlayed}");

hades.ChangeRating(10);
Console.WriteLine($"После ChangeRating(10): {hades.Rating}");
hades.ChangeRating(15);
Console.WriteLine($"После ChangeRating(15): {hades.Rating}");

stardew.AddPlayTime(5);

bool hadesFinished = hades.IsFinished(10);
Console.WriteLine($"Hades пройдена (порог 10 ч): {hadesFinished}");
Console.WriteLine($"Stardew Valley пройдена (порог 10 ч): {stardew.IsFinished(10)}");

Console.WriteLine();
Console.WriteLine($">>> {hades.Title} <<<");
Console.WriteLine($"Жанр: {hades.Genre}");
Console.WriteLine($"Рейтинг: {hades.Rating}");
Console.WriteLine($"Часов игры: {hades.HoursPlayed}");

Console.WriteLine();
Console.WriteLine($">>> {stardew.Title} <<<");
Console.WriteLine($"Жанр: {stardew.Genre}");
Console.WriteLine($"Рейтинг: {stardew.Rating}");
Console.WriteLine($"Часов игры: {stardew.HoursPlayed}");
