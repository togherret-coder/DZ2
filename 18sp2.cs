
//11
Console.WriteLine("11 задание");
int r = int.Parse(Console.ReadLine());
while (r > jor.Length - 1) { r = int.Parse(Console.ReadLine()); }
jor[r] = 0;
for (int j = r; j < 20; j++) { jor[j] = jor[j + 1]; }
string n2 = "";
for (int j = 0; j < 20; j++)
{ n2 = n2 + jor[j] + ","; }
Console.WriteLine(n2);
//12
Console.WriteLine("12 задание");
int kl = int.Parse(Console.ReadLine());
while (kl > jor.Length - 1) { kl = int.Parse(Console.ReadLine()); }
jor[kl] = jor[jor.Length - 1];
int[] jk = new int[jor.Length - 1];
for (int j = r; j < 19; j++) { jk[j] = jor[j]; }
string n3 = "";
for (int j = 0; j < 20; j++)
{ n3 = n3 + jk[j] + ","; }
Console.WriteLine(n3);
//13
Console.WriteLine("13 задание");
int x = int.Parse(Console.ReadLine());
int op = 0;
for (int j = 0; j < o.Length; j++) { if (o[j] == x) { op++; o[j] = 0; } }
int[] yuh = new int[o.Length - op];
for (int j = 0; j < o.Length; j++) { if (o[j] != 0) { yuh[j] = o[j]; } }
string n5 = "";
for (int j = 0; j < yuh.Length; j++)
{ n = n5 + yuh[j] + ","; }
Console.WriteLine(n5);
//14
Console.WriteLine("14 задание");
int p = 0;
for (int j = 0; j < h.Length / 2; j++)
{ p = h[j]; h[j] = h[h.Length - 1 - j]; h[h.Length - 1 - j] = p; }
string q = "";
for (int j = 0; j < 5; j++)
{ q = q + h[j] + ","; }
Console.WriteLine(q);
//15
Console.WriteLine("15 задание");
int[] jkl = new int[5] { 1, 3, 5, 2, 1 };
for (int j = 0; j < 5; j++) { if (jkl[j] == jkl[jkl.Length - j - 1]) { }; }

