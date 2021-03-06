﻿using Entities;
using System;
using System.Collections.Generic;

namespace Models
{
    public class UserModel : BaseModel
    {
        public Guid Token { get; set; }
        public bool IsAuthenticated { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public ICollection<Review> Reviews { get; set; } = new List<Review>();

        public override BaseEntity GetEntity()
        {
            return new Entities.User
            {
                Id = this.Id,
                Username = this.Username,
                Password = this.Password,
                Token = this.Token,
                Age = this.Age
            };
        }
    }
}
