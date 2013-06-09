using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FingertzApp.Web.Mapping
{
    using AutoMapper;

    using FingertzApp.Model.Models;
    using FingertzApp.Web.Models;

    /// <summary>
    /// The domain to view model mapping profile.
    /// </summary>
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<User, UserRegisterModel>();
        }
    }
}