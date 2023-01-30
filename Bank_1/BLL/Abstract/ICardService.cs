using Bank_1.DTOs.UserDTOs;
using Bank_1.Entity;

namespace Bank_1.BLL.Abstract
{
    public interface ICardService
    {
        List<CardtoupdateDTO> Get();
        void Add(CardToAddDTO carddto);
        void Delete(int CardId);
        CardtoupdateDTO Get(int CardId);
        void Update(CardtoupdateDTO card);
    }
}
