﻿using Microsoft.EntityFrameworkCore;

namespace WebApp.Models.Entities
{
    [PrimaryKey("UserId", "AddressId")]
    public class UserAddressEntity
    {
     
        public string UserId { get; set; } = null!;
        public UserEntity User { get; set; } = null!;
        public int AddressId { get; set; }
        public AddressEntity Address { get; set; } = null!;
       


    }
}
