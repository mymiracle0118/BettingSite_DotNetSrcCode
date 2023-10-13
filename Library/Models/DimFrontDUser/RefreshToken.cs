﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.DimFrontDUser
{
    public class RefreshToken
    {
        [Required(ErrorMessage = "token is empty.")]
        public String token { get; set; }
        [Required(ErrorMessage = "refresh token is empty.")]
        public String rt { get; set; }
        public int id { get; set; }
    }
}
