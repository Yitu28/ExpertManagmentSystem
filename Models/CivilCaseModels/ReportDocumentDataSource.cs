using ExpertManagmentSystem.Enums;
using QuestPDF.Helpers;

namespace ExpertManagmentSystem.Models.CivilCaseModels
{
    public static class ReportDocumentDataSource
    {
        private static Random Random = new Random();

        //public static CCFreelServices GetInvoiceDetails()
        //{
        //    var items = Enumerable
        //        .Range(1, 8)
        //        .Select(i => GenerateRandomOrderItem())
        //        .ToList();

        //    return new CCPDecissionTypes
        //    {
        //        //items.Where(a => a.DecisionStatus.ToString() == CCPDecissionTypes.ክስ_የተመሰረተበት.ToString()),


        //    };
        //}

        private static CCFreeLegServiceFollowup GenerateRandomOrderItem()
        {
            return new CCFreeLegServiceFollowup
            {
                //Name = Placeholders.Label(),
                //Price = (decimal)Math.Round(Random.NextDouble() * 100, 2),
                //Quantity = Random.Next(1, 10)
            };
        }

        //private static Address GenerateRandomAddress()
        //{
        //    return new Address
        //    {
        //        CompanyName = Placeholders.Name(),
        //        Street = Placeholders.Label(),
        //        City = Placeholders.Label(),
        //        State = Placeholders.Label(),
        //        Email = Placeholders.Email(),
        //        Phone = Placeholders.PhoneNumber()
        //    };
        //}
    }
}
