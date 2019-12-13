// Copyright @JJSoft - All Rights Reserved
// Filename: DateTimeOffsetExtension.cs
// Created By  :  FrankieYu
// Created Date:  11/12/2019  09:35
// Last Edit:
//    Author:   FrankieYu
//    Date:     11/12/2019  09:38

namespace CourseLibrary.API.Helps
{
    using System;

    /// <summary>
    /// The date time offset extension.
    /// </summary>
    public static class DateTimeOffsetExtension
    {
        /// <summary>
        /// The get current age.
        /// </summary>
        /// <param name="dateTimeOffset">
        /// The date time offset.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public static int GetCurrentAge(this DateTimeOffset dateTimeOffset)
        {
            var currentDate = DateTime.UtcNow;
            var age = currentDate.Year - dateTimeOffset.Year;

            if (currentDate < dateTimeOffset.AddYears(age))
            {
                age--;
            }

            return age;
        }
    }
}
