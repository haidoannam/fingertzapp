// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AutoMapperConfiguration.cs" company="">
//   
// </copyright>
// <summary>
//   The auto mapper configuration.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FingertzApp.Web.Mapping
{
    using AutoMapper;

    /// <summary>
    /// The auto mapper configuration.
    /// </summary>
    public class AutoMapperConfiguration
    {
        /// <summary>
        /// The configure.
        /// </summary>
        public static void Configure()
        {
            Mapper.Initialize(x => x.AddProfile<DomainToViewModelMappingProfile>());
        }
    }
}