// Copyright @JJSoft - All Rights Reserved
// Filename: AuthorsProfile.cs
// Created By  :  FrankieYu
// Created Date:  13/12/2019  09:14
// Last Edit:
//    Author:   FrankieYu
//    Date:     13/12/2019  09:29

namespace CourseLibrary.API.Profiles
{
    using AutoMapper;

    using CourseLibrary.API.Entities;
    using CourseLibrary.API.Helps;
    using CourseLibrary.API.Models;

    /// <summary>
    /// The authors profile.
    /// </summary>
    public class AuthorsProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorsProfile"/> class.
        /// </summary>
        public AuthorsProfile()
        {
            this.CreateMap<Author, AuthorDto>()
                .ForMember(des => des.Name, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(des => des.Age, opt => opt.MapFrom(src => src.DateOfBirth.GetCurrentAge()));
        }
    }
}
