// Copyright @JJSoft - All Rights Reserved
// Filename: AuthorDto.cs
// Created By  :  FrankieYu
// Created Date:  10/12/2019  17:08
// Last Edit:
//    Author:   FrankieYu
//    Date:     10/12/2019  17:16

namespace CourseLibrary.API.Models
{
    using System;

    /// <summary>
    /// The author dto.
    /// </summary>
    public class AuthorDto
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        public DateTimeOffset DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the main category.
        /// </summary>
        public string MainCategory { get; set; }
    }
}
