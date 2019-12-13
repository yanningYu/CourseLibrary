// Copyright @Channel Central - All Rights Reserved
// Filename: AuthorsController.cs
// Last Edit:
//    Author:   FrankieYu
//    Date:     05/12/2019  16:56

using System;

using CourseLibrary.API.Services;

using Microsoft.AspNetCore.Mvc;

namespace CourseLibrary.API.Controllers
{
    using System.Collections.Generic;

    using AutoMapper;

    using CourseLibrary.API.Models;

    /// <summary>
    /// The authors controller.
    /// </summary>
    [ApiController]
    [Route("api/authors")]
    public class AuthorsController : ControllerBase
    {
        /// <summary>
        /// The course library repository.
        /// </summary>
        private readonly ICourseLibraryRepository courseLibraryRepository;

        /// <summary>
        /// The mapper.
        /// </summary>
        private readonly IMapper mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorsController"/> class.
        /// </summary>
        /// <param name="courseLibraryRepository">
        /// The course library repository.
        /// </param>
        /// <param name="mapper">
        /// The mapper.
        /// </param>
        public AuthorsController(
            ICourseLibraryRepository courseLibraryRepository, 
            IMapper mapper)
        {
            this.courseLibraryRepository = courseLibraryRepository ?? 
                throw new ArgumentException(nameof(courseLibraryRepository));
            this.mapper = mapper ?? throw new ArgumentException(nameof(mapper));
        }

        [HttpGet]
        public ActionResult<IEnumerable<AuthorDto>> GetAuthors()
        {
            var authorsFromRepo = this.courseLibraryRepository.GetAuthors();
            var authors = this.mapper.Map<IEnumerable<AuthorDto>>(authorsFromRepo);
            return this.Ok(authors);
        }

        [HttpGet("{authorId:guid}")]
        public IActionResult GetAuthor(Guid authorId)
        {
            var authorFromRepo = this.courseLibraryRepository.GetAuthor(authorId);

            if(authorFromRepo == null)
            {
                return this.NotFound();
            }

            return new JsonResult(authorFromRepo);
        }
    }
}