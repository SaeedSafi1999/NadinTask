using System;
using System.Collections.Generic;

namespace Core.Domain.Entities;

public class User
{
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    public DateTime Created { get; set; }


    public ICollection<Product> products { get; set; }
    

    public User()
    {
        products = new HashSet<Product>();
    }
}