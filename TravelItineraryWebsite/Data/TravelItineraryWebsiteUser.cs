﻿using Microsoft.AspNetCore.Identity;

namespace TravelItineraryWebsite.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class TravelItineraryWebsiteUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
