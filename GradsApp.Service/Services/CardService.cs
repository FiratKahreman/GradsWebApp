using AutoMapper;
using GradsApp.Core.DTOs;
using GradsApp.Core.Models;
using GradsApp.Repository.IRepositories;
using GradsApp.Repository.IUnitOfWorks;
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
        private readonly IUnitOfWork _unitOfWork;

        public CardService(ICardRepository cardRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _cardRepository = cardRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<CardDTO> GetCardById(int id)
        {
            var userResponse = await _cardRepository.GetByFilterAsync(x => x.CardProfileId == id);
            return userResponse != null ? _mapper.Map<CardDTO>(userResponse) : null;
        }

        public async Task<string> NewCard(NewCardDTO newCardDTO)
        {
            var response = _mapper.Map<Card>(newCardDTO);
            await _cardRepository.CreateAsync(response);
            await _unitOfWork.CommitAsync();
            return response.Id.ToString();
        }
    }
}
