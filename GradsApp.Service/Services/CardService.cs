using AutoMapper;
using GradsApp.Core.DTOs;
using GradsApp.Repository.IRepositories;
using GradsApp.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Service.Services
{
    public class CardService : ICardService
    {
        private readonly ICardRepository _cardRepository;
        private readonly IMapper _mapper;

        public CardService(ICardRepository cardRepository, IMapper mapper)
        {
            _cardRepository = cardRepository;
            _mapper = mapper;
        }

        public async Task<CardDTO> GetCardById(int id)
        {
            var userResponse = await _cardRepository.GetByFilterAsync(x => x.CardProfileId == id);
            return _mapper.Map<CardDTO>(userResponse);
        }
    }
}
