string cumle, tersCumle = "";
Console.Write("cümle giriniz:");
cumle = Console.ReadLine();
for(int i=cumle.Length-1;i>=0;i--)
{
tersCumle += cumle[i];
}
Console.WriteLine(tersCumle);
Console.ReadKey();
