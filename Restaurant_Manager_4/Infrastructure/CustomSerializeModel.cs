﻿using System.Collections.Generic;

namespace Restaurant_Manager_4.Infrastructure
{
    public class CustomSerializeModel
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public List<string> RoleName { get; set; }
    }
}