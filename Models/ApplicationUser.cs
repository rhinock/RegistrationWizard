﻿using Microsoft.AspNetCore.Identity;

namespace RegistrationWizard.Models;

public class ApplicationUser : IdentityUser
{
    public bool IsAgreed { get; set; }
}
