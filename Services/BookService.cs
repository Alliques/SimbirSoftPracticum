﻿using Domain.Repositories;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookService : IBookService
    {
        public BookService(IRepositoryManager repositoryManager)
        {

        }
    }
}
