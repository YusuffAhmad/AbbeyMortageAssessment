﻿namespace AbbeyMortageAssessment.Services.Profile
{
    using System.Collections.Generic;
    using System.Linq;
    using AbbeyMortageAssessment.Services.User;
    using AbbeyMortageAssessment.Services.Friendship;
    using AbbeyMortageAssessment.Services.Post;

    public class ProfileServiceModel
    {
        public ProfileServiceModel()
        {
            _posts = new List<PostServiceModel>();
        }

        public UserServiceModel User { get; set; }

        public string CurrentUserId { get; set; }

        public string AvatarUrl { get; set; }

        private List<PostServiceModel> _posts;
        public ICollection<PostServiceModel> Posts
        {
            get => _posts;
            set
            {
                if (value.Count > 0)
                {
                    _posts = value
                        .OrderByDescending(d => d.DatePosted)
                        .ToList();
                }
            }
        }

        /// <summary>
        /// Depending of the enum value it will be generated different layout
        /// </summary>
        public ServiceModelFriendshipStatus FriendshipStatus { get; set; }
    }
}
