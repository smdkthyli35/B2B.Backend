using AutoMapper;
using B2B.Backend.Core.Dtos;
using B2B.Backend.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2B.Backend.Service.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<BasketDto, Basket>().ReverseMap();
            CreateMap<CustomerDto, Customer>().ReverseMap();
            CreateMap<CustomerRelationshipDto, CustomerRelationship>().ReverseMap();
            CreateMap<EmailParameterDto, EmailParameter>().ReverseMap();
            CreateMap<OperationClaimDto, OperationClaim>().ReverseMap();
            CreateMap<OrderDetailDto, OrderDetail>().ReverseMap();
            CreateMap<OrderDto, Order>().ReverseMap();
            CreateMap<PriceListDetailDto, PriceListDetail>().ReverseMap();
            CreateMap<PriceListDto, PriceList>().ReverseMap();
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<ProductImageDto, ProductImage>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<UserOperationClaimDto, UserOperationClaim>().ReverseMap();
        }
    }
}
