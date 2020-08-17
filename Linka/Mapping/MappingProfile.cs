using AutoMapper;
using Linka.Models;
using Linka.Models.Account;
using LinkaRepository.Models;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Linka.Mapping
{
	public class MappingProfile : Profile 
	{
		public MappingProfile()
		{
			CreateMap<Basket, BasketViewModel>();
			CreateMap<Product, ProductViewModel>().ForMember(d => d.Photos, opt => opt.MapFrom(src => src.Photos.OrderBy(p => p.OrderBy).Select(p => p.Image)));
			CreateMap<RegisterViewModel, User>();
			CreateMap<ProductReview, ReviewViewModel>();
			CreateMap<ProductSpecs, ProductSpecViewModel>();



		}
	}
}
