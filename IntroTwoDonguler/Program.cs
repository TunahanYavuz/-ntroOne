string[] konuBasliklari = new string[] {"Üniversitemiz", "Yönetim", "İdari", "Akademik" };

for (int i = 0; i < 4 ; i++)
{
    Console.WriteLine(konuBasliklari[i]);
}
foreach (var konular in konuBasliklari)
{
    Console.WriteLine(konular);
}
