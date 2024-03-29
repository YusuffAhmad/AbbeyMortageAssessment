﻿namespace AbbeyMortageAssessment.Web.Models
{
    using AbbeyMortageAssessment.Services.User;
    using System;

    public class PostViewModel
    {
        public int PostId { get; set; }

        public string Content { get; set; }

        public DateTime? DatePosted { get; set; }

        public UserServiceModel Author { get; set; }

        public int? GroupId { get; set; }

        /// <summary>
        /// Tagged Friends in a JSON format
        /// </summary>
        public string TaggedFriends { get; set; }
    }
}
