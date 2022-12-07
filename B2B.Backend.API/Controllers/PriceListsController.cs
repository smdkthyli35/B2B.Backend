using AutoMapper;
using B2B.Backend.Core.Dtos;
using B2B.Backend.Core.Entities;
using B2B.Backend.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace B2B.Backend.API.Controllers
{
    public class PriceListsController : CustomBaseController
    {
        private readonly IPriceListService _priceListService;
        private readonly IMapper _mapper;

        public PriceListsController(IPriceListService priceListService, IMapper mapper)
        {
            _priceListService = priceListService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            IEnumerable<PriceList> priceLists = await _priceListService.GetAllAsync();
            List<PriceListDto> priceListsDto = _mapper.Map<List<PriceListDto>>(priceLists.ToList());
            return CreateActionResult(CustomResponseDto<List<PriceListDto>>.Success(200, priceListsDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            PriceList priceList = await _priceListService.GetByIdAsync(id);
            PriceListDto mappedPriceList = _mapper.Map<PriceListDto>(priceList);
            return CreateActionResult(CustomResponseDto<PriceListDto>.Success(200, mappedPriceList));
        }

        [HttpPost]
        public async Task<IActionResult> Add(PriceListDto priceListDto)
        {
            PriceList priceList = await _priceListService.AddAsync(_mapper.Map<PriceList>(priceListDto));
            PriceListDto mappedPriceList = _mapper.Map<PriceListDto>(priceList);
            return CreateActionResult(CustomResponseDto<PriceListDto>.Success(201, mappedPriceList));
        }

        [HttpPut]
        public async Task<IActionResult> Update(PriceListUpdateDto priceListUpdateDto)
        {
            await _priceListService.UpdateAsync(_mapper.Map<PriceList>(priceListUpdateDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            PriceList priceList = await _priceListService.GetByIdAsync(id);
            await _priceListService.RemoveAsync(priceList);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
