class Program
{
    static void Main(string[] args)
    {
        int hp_player = 100;
        int hp_bot = 320;
        int block = 16;
        int attack = 20;
        int big_attack = 30;
        int parirovanie = 16;
        int defence = 14;
        int charge = 0;
        int quantity_health_potion = 3;
        int health = 40;

        Console.WriteLine("Бот-"+hp_player  + " "+"Игрок-"+hp_bot);
        Console.WriteLine("1-Удар, 2-Блок, 3-Контратака, 4-Сильный удар, 5-Выпить зелье здоровья");

        for (int i = 0; i < hp_player;)
        {
            if (hp_bot > 0)
            {
                int[] hod_bot = new int[1];
                Random r = new Random();
                Console.WriteLine("Ваша энергия равна: " + charge);

                for (int n = 0; n < hod_bot.Length; n++)
                {
                    hod_bot[n] = r.Next(1, 4);
                    Console.WriteLine("");
                    try
                    {
                        Console.WriteLine("Введите цифру, исходя из вашего хода: ");
                        int hod_player = Convert.ToInt32(Console.ReadLine());



                        if (hod_bot[n] == 1)
                        {
                            if (hod_player == 1)
                            {
                                hp_player = hp_player - attack;
                                hp_bot = hp_bot - attack;
                                Console.WriteLine("Противник тоже решил вас ударить. ");
                                Console.WriteLine("Молниеносно, ваши мечи достигают друг друга.");
                                Console.WriteLine("Ваше ХП:" + hp_player);
                                Console.WriteLine("ХП бота:" + hp_bot);
                                charge++;
                            }
                            else if (hod_player == 2)
                            {
                                hp_player = hp_player - block;
                                Console.WriteLine("Противник решил вас ударить. Часть урона прошло сквозь щит");
                                Console.WriteLine("Ваше ХП:" + hp_player);
                                Console.WriteLine("ХП бота:" + hp_bot);
                                charge++;
                            }
                            else if (hod_player == 3)
                            {
                                hp_bot = hp_bot - defence;
                                Console.WriteLine("Противник решил вас ударить. Но вы смогли контратаковать.");
                                Console.WriteLine("Ваше ХП:" + hp_player);
                                Console.WriteLine("ХП бота:" + hp_bot);
                                charge++;
                            }
                            else if (hod_player == 4 && charge >= 5)
                            {
                                Console.WriteLine("Вы ломаете кости своему противнику");
                                hp_bot = hp_bot - big_attack;
                                charge = charge - 5;
                                Console.WriteLine("Ваше ХП:" + hp_player);
                                Console.WriteLine("ХП бота:" + hp_bot);
                            }
                            else if (hod_player == 5 && quantity_health_potion > 0)
                            {
                                Console.WriteLine("Вы быстро выпили зелья здоровья и продолжили сражение");
                                hp_player = hp_player + health;
                                quantity_health_potion--;
                                Console.WriteLine("Ваше ХП:" + hp_player);
                                Console.WriteLine("Осталось зелий: " + quantity_health_potion);
                            }
                            else
                            {
                                Console.WriteLine("Только одна цифра!");
                                Console.WriteLine("");
                            }
                        }

                        else if (hod_bot[n] == 2)
                        {
                            if (hod_player == 1)
                            {
                                hp_bot = hp_bot - block;
                                Console.WriteLine("Противник укрлыся щитом, но чать урона прошло.");
                                Console.WriteLine("Ваше ХП:" + hp_player);
                                Console.WriteLine("ХП бота:" + hp_bot);
                                charge++;

                            }
                            else if (hod_player == 2)
                            {
                                Console.WriteLine("Ничго не случилось");
                                Console.WriteLine("Противник укрлыся щитом");
                                charge++;
                            }
                            else if (hod_player == 3)
                            {
                                hp_player = hp_player - parirovanie;
                                Console.WriteLine("Противник укрлыся щитом и ударил вас, подловив на неудачной контратаке.");
                                Console.WriteLine("Ваше ХП:" + hp_player);
                                Console.WriteLine("ХП бота:" + hp_bot);
                                charge++;
                            }
                            else if (hod_player == 4 && charge >= 5)
                            {
                                Console.WriteLine("Вы ломаете кости своему противнику");
                                hp_bot = hp_bot - big_attack;
                                charge = charge - 5;
                                Console.WriteLine("Ваше ХП:" + hp_player);
                                Console.WriteLine("ХП бота:" + hp_bot);
                            }
                            else if (hod_player == 5 && quantity_health_potion > 0)
                            {
                                Console.WriteLine("Вы быстро выпили зелья здоровья и продолжили сражение");
                                hp_player = hp_player + health;
                                quantity_health_potion--;
                                Console.WriteLine("Ваше ХП:" + hp_player);
                                Console.WriteLine("Осталось зелий: " + quantity_health_potion);
                            }
                            else
                            {
                                Console.WriteLine("Только одна цифра!");
                                Console.WriteLine("");
                            }
                        }

                        else if (hod_bot[n] == 3)
                        {
                            if (hod_player == 1)
                            {
                                hp_player = hp_player - defence;
                                Console.WriteLine("Противник контратаковал вас.");
                                Console.WriteLine("Ваше ХП:" + hp_player);
                                Console.WriteLine("ХП бота:" + hp_bot);
                                charge++;
                            }
                            else if (hod_player == 2)
                            {
                                hp_bot = hp_bot - parirovanie;
                                Console.WriteLine("Вы укрылись щитом, подловив противника на неудачной контратаке вы ударили его.");
                                Console.WriteLine("Ваше ХП:" + hp_player);
                                Console.WriteLine("ХП бота:" + hp_bot);
                                charge++;
                            }
                            else if (hod_player == 3)
                            {
                                Console.WriteLine("Противник выбрал контратаку.");
                                Console.WriteLine("Никто из вас не смог найти слабое место в защите противника");
                                Console.WriteLine("Ничго не случилось");
                                charge++;
                            }
                            else if (hod_player == 4 && charge >= 5)
                            {
                                Console.WriteLine("Вы ломаете кости своему противнику");
                                hp_bot = hp_bot - big_attack;
                                charge = charge - 5;
                                Console.WriteLine("Ваше ХП:" + hp_player);
                                Console.WriteLine("ХП бота:" + hp_bot);
                            }
                            else if (hod_player == 5 && quantity_health_potion > 0)
                            {
                                Console.WriteLine("Вы быстро выпили зелья здоровья и продолжили сражение");
                                hp_player = hp_player + health;
                                quantity_health_potion--;
                                Console.WriteLine("Ваше ХП:" + hp_player);
                                Console.WriteLine("Осталось зелий: " + quantity_health_potion);
                            }
                            else
                            {
                                Console.WriteLine("Только одна цифра!");
                                Console.WriteLine("");
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Вписывайте только цифры хода!");
                    }

                    if (hp_bot <= 0)
                    {
                        Console.WriteLine("Вы победили!");
                    }
                    else if (hp_player <= 0)
                    {
                        Console.WriteLine("Вы проиграли!");
                    }
                }
            }
        }
    }
}

