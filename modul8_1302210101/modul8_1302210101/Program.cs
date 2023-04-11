// See https://aka.ms/new-console-template for more information
using static modul8_1302210101.BankTransferConfig.set;

readWrite rw = new readWrite();

rw.Ubahlang();

if (rw.config.lang == "en")
{
    Console.WriteLine("Please insert the ammount money to transfer: ");
}
else if (rw.config.lang == "id") {
    Console.WriteLine("Masukan Jumlah Uang yang akan di-transfer");
}

int uang = Convert.ToInt32(Console.ReadLine());

int fee = 0;
if (uang <= rw.config.threshold)
{
    fee = rw.config.low_fee;
}
else { 
    fee = rw.config.high_fee;
}
Console.WriteLine(" ");
if (rw.config.lang == "en")
{
    Console.WriteLine("Transfer fee = "+fee);
    Console.WriteLine("Total amount = " + (uang+fee));
}
else if (rw.config.lang == "id")
{
    Console.WriteLine("Biaya transfer = " + fee);
    Console.WriteLine("Total biaya = " + (uang + fee));
}
Console.WriteLine(" ");
if (rw.config.lang == "en")
{
    Console.WriteLine("Select transfer method: ");
}
else if (rw.config.lang == "id")
{
    Console.WriteLine("Pilih metode transfer: ");
}

Console.WriteLine("1. RTO (real-time) ");
Console.WriteLine("2. SKN ");
Console.WriteLine("3. RTGS ");
Console.WriteLine("4. BI FAST ");

int in2 = Convert.ToInt32(Console.ReadLine());

if (rw.config.lang == "en")
{
    Console.WriteLine("Please type " + in2 + " to confirm the transaction: ");
}
else if (rw.config.lang == "id")
{
    Console.WriteLine("Ketik " + in2 + " untuk mengkonfirmasi transaksi: ");
}

int acc = Convert.ToInt32(Console.ReadLine());
rw.pilihM(acc);

if (rw.config.lang == "en" && acc > 4 || acc < 1)
{
    Console.WriteLine("Transfer is cancelled ");
}
else if (rw.config.lang == "id" && acc > 4 || acc < 1)
{
    Console.WriteLine("Transfer dibatalkan ");
}
else 
{
    if (rw.config.lang == "en")
    {
        Console.WriteLine("The transfer is completed ");
    }
    else if (rw.config.lang == "id")
    {
        Console.WriteLine("Proses transfer berhasil ");
    }
}

