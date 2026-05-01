using ESFE.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE.BusinessLogic.DTOs;

public class UserResponse
{
    public int UserId { get; set; }

    public int RolId { get; set; }

    public string? UserName { get; set; }

    public string? UserNickname { get; set; }

    public bool? UserStatus { get; set; }

    public string? RolName { get; set; }
}



