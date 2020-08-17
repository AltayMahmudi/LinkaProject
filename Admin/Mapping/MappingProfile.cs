using Admin.Models.Shopping;
using AutoMapper;
using LinkaRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Mapping
{
	public class MappingProfile:Profile
	{
		public MappingProfile()
		{
			CreateMap<Product, ProductViewModel>();
			CreateMap<ProductPhoto,ProductPhotoViewModel >();

		}
	}
}
