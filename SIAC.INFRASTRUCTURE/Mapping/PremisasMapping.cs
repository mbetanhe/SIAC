using AutoMapper;
using SIAC.CORE.DTOs;
using SIAC.CORE.Entities.Premisas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAC.INFRASTRUCTURE.Mapping
{
    public class PremisasMapping : Profile
    {
        public PremisasMapping()
        {
            CreateMap<FacPremisasOffline, PremisasOffDTO>();
        }
    }
}
