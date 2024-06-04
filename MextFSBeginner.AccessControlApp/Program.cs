using System.Runtime.CompilerServices;
using MextFSBeginner.Domain;
using MextFSBeginner.Domain.Entities;

string filePath="/Users/hilalnurdurdac/Desktop/MextFSBeginner/AccessControlLogs.txt";
string fileContent=File.ReadAllText(filePath);
string[]lines=fileContent.Split("\n",StringSplitOptions.RemoveEmptyEntries);

var accessControlLogs=new List<AccessControlLog>();

foreach(var line in lines)
{
    string[]properties=line.Split("---",StringSplitOptions.RemoveEmptyEntries);
    var accessControlLog=new AccessControlLog()
    {
        Id=Guid.NewGuid(),
        UserId=Convert.ToInt32(properties[0]),
        DeviceSerialNumber=properties[1],
        AccessType=Enum.Parse<AccessType>(properties[2]),
        Date=Convert.ToDateTime(properties[3])
    };
    Console.WriteLine($"Log sistem ID'si: {accessControlLog.Id},Kullanıcı ID'si: {accessControlLog.UserId},Cihaz Seri Numarası:{accessControlLog.DeviceSerialNumber},Erişim Tipi: {accessControlLog.AccessType},Tarih:{accessControlLog.Date}");
}

var userValues="Alper Tunga 28 Öğretmen";