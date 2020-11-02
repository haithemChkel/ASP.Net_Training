﻿using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentACar.Models
{
    [TableName("AspNetUsers")]
    [PrimaryKey("Id")]
    public class UserModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
    }
}