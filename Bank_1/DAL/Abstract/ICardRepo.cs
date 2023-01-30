using Bank_1.Entity;

namespace Bank_1.DAL.Abstract
{
    public interface ICardRepo
    {
        List<CardtoupdateDTO> Get();
        void Add(CardtoupdateDTO card);
        void Delete(int CardId);
        CardtoupdateDTO Get(int CardId);   
        void Update(CardtoupdateDTO card);
    }
}
