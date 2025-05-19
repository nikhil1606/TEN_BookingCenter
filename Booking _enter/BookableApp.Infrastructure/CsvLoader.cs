using Booking_Center.BookableApp.Domain;
using CsvHelper;
using System.Formats.Asn1;
using System.Globalization;

namespace Booking_Center.BookableApp.Infrastructure
{
    public static class CsvLoader
    {

        public static List<Member> LoadMembers(string path)
        {
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<Member>().ToList();
        }

        public static List<InventoryItem> LoadInventory(string path)
        {
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<InventoryItem>().ToList();
        }
    }
}
