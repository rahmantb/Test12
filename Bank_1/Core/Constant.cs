using Bank_1.Entity;

namespace Bank_1.Core
{
    public static class Constant
    {
        public static List<Cardtype> cardtypes = new List<Cardtype>()
        {
            new Cardtype()
            {
                CardTypeId=1,
                Name="type1"

            },
            new Cardtype()
            {
                CardTypeId=2,
                Name="type2"
            }
        };
        public static List<CardtoupdateDTO> cards = new List<CardtoupdateDTO>();
        public static List<Customer> customers = new List<Customer>();
    }
  
}
