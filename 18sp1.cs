//1(1)
Console.WriteLine("1 задание");
string a;
a = (Console.ReadLine());
int b=int.Parse(a)+100;
Console.WriteLine(b);
//1(2)
Console.WriteLine("2 задание");
double c = (double)(7 / 2);
Console.WriteLine(c);
int d = (int)(7.0 / 2);
Console.WriteLine(d);
//1(3)
Console.WriteLine("3 задание");
string e= (Console.ReadLine());
if (int.TryParse(e, out int newNumber)) {Console.WriteLine(newNumber*newNumber);}
else { Console.WriteLine("Ошибка ввода"); }
//1(4)
Console.WriteLine("4 задание");
double f = double.Parse(Console.ReadLine());
int g = (int)(f);
Console.WriteLine(f);
Console.WriteLine(g);
//5 
Console.WriteLine("5 задание");
int[] h = new int[5] { 1, 414, 88, 78, 70 };
string i="";
for (int j = 0; j < 5; j++)
{ i = i + h[j]+","; }
Console.WriteLine(i);
//6
Console.WriteLine("6 задание");
int l = 0;
for  (int j = 0; j < 5; j++)
{ if (h[j] % 2 == 0) { l++; } }
Console.WriteLine(l);
//7
Console.WriteLine("7 задание");
int k = 0;
for (int j = 0;j < 5; j++) { k=k+h[j]; }
Console.WriteLine(k);
Console.WriteLine((float)k/h.Length);
//8
Console.WriteLine("8 задание");
int m = h[0];
h[0] = h[h.Length-1];
h[h.Length-1] = m;
string n = "";
for (int j = 0; j < 5; j++)
{ n = n + h[j]+","; }
Console.WriteLine(n);
//9
Console.WriteLine("9 задание");
int min = h[0];
int minind = 0;
int max = h[0];
int maxind = 0;
for (int j = 1; j < 5; j++)
{
    if (min >= h[j]) { min = h[j];minind = j; }
    if (max <= h[j]) { max = h[j]; maxind = j; }
}
Console.WriteLine(min);
Console.WriteLine(minind);
Console.WriteLine(max);
Console.WriteLine(maxind);
