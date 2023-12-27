using System.Collections.Concurrent;
using CROC.Zoo;
using static CROC.Learning.MathCroc;
using CROC.MyLinkedLIST;
using CROC.Learning;
using System.Net.NetworkInformation;

//MyLinkedList<int> Listik = new MyLinkedList<int>();
//Listik.Add(0);
//Listik.Add(1);
//Listik.Add(2);    
//Listik.Add(3);
//Listik.Add(4);
//Listik.DeleteByValue(3);
//Console.WriteLine(Listik);
//int res = Listik.GetByIndex(3);
//Console.WriteLine(res);
int[] ii = { 6, 4, 88, 77, 9, 3 };
Kata.sumTwoSmallestNumbers(ii);
Kata.PigIt("Pig latin is cool !");
Kata.DescendingOrder(53912);

//MyArrayList Kakilist = new MyArrayList();
//Kakilist.Add(0);
//Kakilist.Add(1);
//Kakilist.Add(2);
//Kakilist.Add(3);
//Kakilist.Add(4);
//Kakilist.Add(5);
//Kakilist.Add(6);
//Console.WriteLine(Kakilist);
//Kakilist.InsertByIndex(2,9);
//Console.WriteLine(Kakilist);
//int summa = Kakilist.Sum();
//Console.WriteLine(summa);
//int maxValue = Kakilist.MaxValue();
//Console.WriteLine(maxValue);
//int minValue = Kakilist.MinValue();
//Console.WriteLine(minValue);



//bool ExpectedResult = Zada4ki.BetterThanAverage(new int[] { 100, 40, 34, 57, 29, 72, 57, 88 }, 75);
//Console.WriteLine(ExpectedResult);




//RpsGamer.HelloRps();
//Console.WriteLine("Введите имя первого гандона");
//RpsGamer Player1 = new RpsGamer(Console.ReadLine());
//Console.WriteLine("Введите имя второго гандона");
//RpsGamer Player2 = new RpsGamer(Console.ReadLine());
//Console.WriteLine($"Прекрасно! Теперь первое уебище зовут {Player1.Name}, а второе {Player2.Name}!");
//RpsGamer.Fight(Player1 , Player2);

//string testkakov = Zada4ki.FakeBin("45385593107843568");
//Console.WriteLine(testkakov);

//int kaki1 = Zada4ki.Multiply(2);
//Console.WriteLine(kaki1);

//int[] iA = { -1, -2, -3, -4, -5 };
//int[] ia = ArraysInversion.InvertValues(iA);
//for (int i = 0; i < ia.Length; i++)
//{
//    Console.WriteLine(ia[i]);
//}
//int result =Kata.StringToNumber("1234");
//Console.WriteLine(result);
//string kata = Kata.RemoveExclamationMarks("Hi!Meow!");
//Console.WriteLine(kata);
//int kata1 = Kata.Grow(new[] {2, 3, 1, 5});
//Console.WriteLine(kata1);
//string rna = Kata.DnaToRna("GCAT");
//Console.WriteLine(rna);


//int[] massive = new int[10];
//int counter = 0;
//while (counter < massive.Length)
//{
//    massive[counter] = counter + 1;
//    counter++;

//}
//counter = 0;
//while (counter < massive.Length)
//{
//    if (massive[counter] % 2 == 0)
//    {
//        Console.WriteLine(massive[counter]);
//    }
//    counter++;
//}


//Console.WriteLine("vVEDITE CHISLO 1");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("vVEDITE CHISLO 2");
//double b = Convert.ToDouble(Console.ReadLine());
//MathCroc.SrdneeArif(a, b);

//Console.WriteLine("Vvedite chislo 1");
//int a1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Vvedite chislo 2");
//int b2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Vvedite chislo 3");
//int c3=Convert.ToInt32(Console.ReadLine());
//MathCroc.SummaAndProizved(a1, b2, c3 );

//Console.WriteLine("$$$ Zdarova, eto converter dlya REALTRUE bisnesmenov =) $$$ " +
//    "\n$$$ zdesb vi mojete convertirovat' vsyakoe govno v raznie kaki $$$ " +
//    "\n$$$ dlya vibora valuti kotoruy vi budete convertirovat' vvedite chislo: $$$ " +
//    "\n$$$ 0 - USD $$$ 1 - EUR $$$ 2 - RUB $$$ 3 - KZT $$$");
//while (true)
//{
//    int valuta1 = Convert.ToInt32(Console.ReadLine());
//    if (valuta1 < 0 || valuta1 > 3) 
//    {
//        break;
//    }
//    Console.WriteLine("$$$ dlya vibora valuti v kotoruy vi budete convertirovat' vvedite chislo: $$$");
//    int valuta2 = Convert.ToInt32(Console.ReadLine());
//    if (valuta2 < 0 || valuta2 > 3)
//    {
//        break; 
//    }
//    Console.WriteLine("$$$ teper' vvedite summu $$$");
//    double summa = Convert.ToDouble(Console.ReadLine());
//    MathCroc.Converter(summa, (Value)valuta1, (Value)valuta2);
//}
//StreamHata.SimpDoika();
//Console.WriteLine("Vstav'te babki =)");
//int myMoney = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("REDBULL 0,25 S AKCIEI SKOka shas stoit, napomni pls =)");
//int cennik = Convert.ToInt32(Console.ReadLine());
//Energydrink.PokypochkaEnergy ( myMoney  , cennik );


//Console.WriteLine("Vvedite chislo 1");
//int chislo1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Vvedite chislo 2");
//int chislo2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Vvedite chislo 3");
//int chislo3 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Vvedite chislo 4");
//int chislo4 = Convert.ToInt32(Console.ReadLine());

////MathCroc.CalcAB(chislo1, chislo2);

////MathCroc.CalcX(chislo1, chislo2, chislo3);
//MathCroc.CalcPryamaya(chislo1, chislo2, chislo3, chislo4);

//Console.WriteLine(" vvesti imya chela ");
//string[] name = new string[2];
//name[0] = Console.ReadLine();
//Console.WriteLine(" vvesti familiyu chela");
//name[1] = Console.ReadLine();
//Console.WriteLine(" vvesti gorod kirishi (pls)");
//string city = Console.ReadLine();
//Console.WriteLine(" vvesti best olast' (jemchyjina rossii)");
//string state = Console.ReadLine();  

//Name.SayHello(name, city, state);


//Human TinderUser1 = new Human("Андрей", "Пихалыч");
//Human TinderUser2 = new Human("Галина", "Палнна");
//TinderUser1.AddInformation("Кириши", "Скорпион", 35, 179, 90, 8.5, "Половые отношения");
//TinderUser2.AddInformation("Кириши", "Овен", 70, 145, 120, 6, "Ячмень на глазу");

//Food Food1 = new Food ("Киндер молочный ломтик",422, 28, true, 40, true, 7.9, 27.9, 34);
//Food Food2 = new Food("Сырочек с малиной", 388, 40, true, 21, false, 5.2, 23.5, 39);

////double kkal1 = Food1.CalcKkal(2);
////Console.WriteLine(kkal1);

////double kkal2 = Food2.CalcKkal(12);
////Console.WriteLine(kkal2);

////double kkal3 = Food1.CalcKkal(5);
////Console.WriteLine(kkal3);

//double cost1 = Food1.CalcCost(4);
//Console.WriteLine(cost1);

//double norma1 = Food1.CalcNormaKKal(2500, 2);
//Console.WriteLine(norma1);

//int bd = 0;
//MassivDrochka ABC = new MassivDrochka();
//ABC.PrintStrings("ы", "а");

//BabySpawn Roddom = new BabySpawn("Выкидышная 17");
//Human babyloh = Roddom.BabyBorn("12.23.2003", "Мальфит", "Куча");
//KidsGarden chistilishe = new KidsGarden("Чистилище", "Безперспективная 228", "30000", " 24 часа");
//babyloh = chistilishe.AddInKidsGarden(babyloh);

//Animal Andrei = new Opossum ("Andrei", 1.5, false, 1200, "musor", 0);
//Opossum Lyalya = new("Lyalya", 1.0, true, 800, "pomoechka", 4);
//Opossum Bylochka = new("Bylochka", 2.5, true, 100, "skam", 2);
//Opossum.AboutOpussums();
//if (Andrei is Opossum)
//{
//    ((Opossum)Andrei).CalculateAmountOfFood();
//}

//Lyalya.CalculateAmountOfFood();
//Bylochka.CalculateAmountOfFood();
//Bylochka.Spat();
//Animal Natasha = new Cats("Наташа", Description.Сфинкс, 4, false, 5, "курочка", 0);
//Animal Kot = new Cats("Кот",Description.Персидское_Ебло, 6, true, 4,"бумажечки", 4);
//Cats.LizatSherstky();
//if (Natasha is Cats && Kot is Cats) 
//{
//    Cats CastCats1 = (Cats)Natasha;
//    Cats CastCats2 = (Cats)Kot;

//    CastCats1.Linka();
//    CastCats1.KolichestvoKakov();
//    CastCats2.Linka();
//    CastCats2.KolichestvoKakov();
//}





















//Energydrink.SwapNaeb(chislo1,chislo2);
















//Console.WriteLine("Vvedite chislo 1");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Vvedite chislo 2");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Vvedite znak");
//string z = Console.ReadLine();
//if (z == "+")
//    Console.WriteLine(a+b);
//else if (z =="-")
//    Console.WriteLine(a-b);
//else if (z == "*")
//    Console.WriteLine(a*b);
//else if (z == "/")
//    Console.WriteLine(a/b);
//else Console.WriteLine("Vvedite 1 of 4 simbols: +,-,*,/");

// > если строго больше
// < если строго меньше
// >= если больше или равно
// <= если меньше или равно
// += добавить к тому, что перед знаком то, что после знака
// -= убрать у того, что перед знаком то, что после знака
// ++ добавить  +1 к тому, что перед знаком
// -- убрать -1 у того, что перед знаком

// == если равно
// != если не равно




//TinderUser User1 = new TinderUser("Sponge Bob", "BikiniBottom", "Deva", "12", "32", 100, 50, 1000);
//TinderUser User2 = new TinderUser("Kratos", "Sparta", "Scorpion", "54", "179", 15, 10, 100);

//while (User1.LiveFromScum && User2.LiveFromScum)
//{
//    User1.ScumAttack(User2);

//    User2.ScumAttack(User1);
//}




































