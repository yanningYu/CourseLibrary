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
        /// Initializes a new instance of the <see cref="AuthorsController"/> class.
        /// </summary>
        /// <param name="courseLibraryRepository">
        /// The course library repository.
        /// </param>
        public AuthorsController(ICourseLibraryRepository courseLibraryRepository)
        {
            this.courseLibraryRepository = courseLibraryRepository ?? 
                throw new ArgumentException(nameof(courseLibraryRepository));
        }

        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authorsFromRepo = this.courseLibraryRepository.GetAuthors();
            return this.Ok(authorsFromRepo);
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