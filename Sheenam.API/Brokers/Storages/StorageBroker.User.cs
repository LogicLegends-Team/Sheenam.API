﻿using Microsoft.EntityFrameworkCore;
using Sheenam.API.Models.Users;

namespace Sheenam.API.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<User> Users { get; set; }
    }
}