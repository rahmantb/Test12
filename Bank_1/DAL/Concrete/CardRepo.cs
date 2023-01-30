using Bank_1.Core;
using Bank_1.DAL.Abstract;
using Bank_1.Entity;

namespace Bank_1.DAL.Concrete
{
    public class CardRepo : ICardRepo
    {
        public void Add(CardtoupdateDTO card)
        {
            Constant.cards.Add(card);
        }

        public void Delete(int CardId)
        {
            var data = Constant.cards.FirstOrDefault(m => m.CardId == CardId);
            Constant.cards.Remove(data);
        }

        public List<CardtoupdateDTO> Get()
        {
            return Constant.cards;
        }

        public CardtoupdateDTO Get(int CardId)
        {
            var data = Constant.cards.FirstOrDefault(m => m.CardId == CardId); throw new NotImplementedException();
            return data;
        }

        public void Update(CardtoupdateDTO card)
        {
            CardtoupdateDTO card1 = new CardtoupdateDTO()
            {
                Name = card.Name,
                CardId = card.CardId,
            };
        }
    }
}
