using AutoMapper;
using B2B.Backend.Core.Dtos;
using B2B.Backend.Core.Entities;
using B2B.Backend.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.AccessControl;

namespace B2B.Backend.API.Controllers
{
    public class PriceListDetailsController : CustomBaseController
    {
        private readonly IPriceListDetailService _priceListDetailService;
        private readonly IMapper _mapper;

        public PriceListDetailsController(IPriceListDetailService priceListDetailService, IMapper mapper)
        {
            _priceListDetailService = priceListDetailService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            IEnumerable<PriceListDetail> priceListDetails = await _priceListDetailService.GetAllAsync();
            List<PriceListDetailDto> mappedPriceListDetailDto = _mapper.Map<List<PriceListDetailDto>>(priceListDetails.ToList());
            return CreateActionResult(CustomResponseDto<List<PriceListDetailDto>>.Success(200, mappedPriceListDetailDto));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            PriceListDetail priceListDetail = await _priceListDetailService.GetByIdAsync(id);
            PriceListDetailDto mappedPriceListDetailDto = _mapper.Map<PriceListDetailDto>(priceListDetail);
            return CreateActionResult(CustomResponseDto<PriceListDetailDto>.Success(200, mappedPriceListDetailDto));
        }

        [HttpPost]
        public async Task<IActionResult> Add(PriceListDetailDto priceListDetailDto)
        {
            PriceListDetail priceListDetail = await _priceListDetailService.AddAsync(_mapper.Map<PriceListDetail>(priceListDetailDto));
            PriceListDetailDto mappedPriceListDetailDto = _mapper.Map<PriceListDetailDto>(priceListDetail);
            return CreateActionResult(CustomResponseDto<PriceListDetailDto>.Success(201, mappedPriceListDetailDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(PriceListDetailUpdateDto priceListDetailUpdateDto)
        {
            await _priceListDetailService.UpdateAsync(_mapper.Map<PriceListDetail>(priceListDetailUpdateDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            PriceListDetail priceListDetail = await _priceListDetailService.GetByIdAsync(id);
            await _priceListDetailService.RemoveAsync(priceListDetail);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
    }
}
