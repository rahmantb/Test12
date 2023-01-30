using Bank_1.BLL.Abstract;
using Bank_1.DAL.Abstract;
using Bank_1.DTOs.UserDTOs;
using Bank_1.Entity;

namespace Bank_1.BLL.Concrete
{
   
    public class CardService : ICardService
    {
        private readonly ICardRepo _cardRepo;
        public CardService(ICardRepo cardRepo)
        {
            _cardRepo = cardRepo;   
        }
        public void Add(CardToAddDTO carddto)
        {

        }
        public void Delete(int CardId)
        {
            throw new NotImplementedException();
        }
        public List<CardtoupdateDTO> Get()
        {
            throw new NotImplementedException();
        }
        public CardtoupdateDTO Get(int CardId)
        {
            throw new NotImplementedException();
        }
        public void Update(CardtoupdateDTO card)
        {
            throw new NotImplementedException();
        }
    }
}

