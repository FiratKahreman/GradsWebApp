using GradsApp.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Service.IServices
{
    public interface ICardService
    {
        Task<CardDTO> GetCardById(int id);
        Task<string> NewCard(NewCardDTO newCardDTO);
    }
}
