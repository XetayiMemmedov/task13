//13cu tapsirigin helli
Console.WriteLine("Saniyeni daxil edin:");
int s=int.Parse(Console.ReadLine());
//int s = 31600000;
double qaliq = 0;
double d = 0;
double h = 0;
double m = 0;
double temp = s;
for (double i = 0; temp >= qaliq; i++)
{
    qaliq = Math.Pow(60, 4);
    if (temp < qaliq)
        break;
    temp = temp - qaliq;
    d++;
}
qaliq = 0;
for (double i = 0; temp >= qaliq; i++)
{
    qaliq = Math.Pow(60, 3);
    if (temp < qaliq)
        break;
    temp = temp - qaliq;
    h++;
}
qaliq = 0;
for (double i = 0; temp >= qaliq; i++)
{
    qaliq = Math.Pow(60, 2);
    if (temp < qaliq)
        break;
    temp = temp - qaliq;
    m++;
}
qaliq = 0;
for (double i = 0; temp >= qaliq; i++)
{
    qaliq = Math.Pow(60, 1);
    if (temp < qaliq)
        break;
    temp = temp - qaliq;
    h++;
}
Console.Write($"{s} saniye - {d} gun, {h} saat, {m} deqiqe, {temp} saniyedir ");




