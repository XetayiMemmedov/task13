//13cu tapsirigin helli
Console.WriteLine("Saniyeni daxil edin:");
int s = int.Parse(Console.ReadLine());
double qaliq = 0;
double d = 0;
double h = 0;
double m = 0;
double temp = s;
for (double i = 0; temp >= qaliq; i++)
{
    qaliq = 24 * Math.Pow(60, 3);
    if (temp < qaliq)
        break;
    temp = temp - qaliq;
    d++;
}
qaliq = 0;
for (double i = 0; temp >= qaliq; i++)
{
    qaliq = Math.Pow(60, 2);
    if (temp < qaliq)
        break;
    temp = temp - qaliq;
    h++;
}
qaliq = 0;
for (double i = 0; temp >= qaliq; i++)
{
    qaliq = Math.Pow(60, 1);
    if (temp < qaliq)
        break;
    temp = temp - qaliq;
    m++;
}
qaliq = 0;
if (d!=0)
    Console.Write($"{s} saniye - {d} gun, {h} saat, {m} deqiqe, {temp} saniyedir ");
else if (d==0 && h!=0)
    Console.Write($"{s} saniye - {h} saat, {m} deqiqe, {temp} saniyedir ");
else if (d==0 && h == 0 && m != 0)
    Console.Write($"{s} saniye - {m} deqiqe, {temp} saniyedir ");
else
    Console.Write($"{s} saniye - {temp} saniyedir ");




