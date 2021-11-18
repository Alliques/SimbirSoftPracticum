﻿
using Domain.Repositories;
using Persistence;
using Persistence.Repositories;
using System;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<IPersonRepository> _lazyPersonRepository;
        private readonly Lazy<IBookRepository> _lazyBookRepository;
        private readonly Lazy<IGenreRepository> _lazyGenreRepository;
        private readonly Lazy<IUnitOfWork> _lazyUnitOfWork;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _lazyPersonRepository = new Lazy<IPersonRepository>(() => new PersonRepository(repositoryContext));
            _lazyBookRepository = new Lazy<IBookRepository>(() => new BookRepository(repositoryContext));
            _lazyGenreRepository = new Lazy<IGenreRepository>(() => new GenreRepository(repositoryContext));
            _lazyUnitOfWork = new Lazy<IUnitOfWork>(() => new UnitOfWork(repositoryContext));
        }
        public IGenreRepository Genre
        {
            get
            {
                return _lazyGenreRepository.Value;
            }
        }
        public IPersonRepository Person
        {
            get
            {
                return _lazyPersonRepository.Value;
            }
        }
        public IBookRepository Book
        {
            get
            {
                return _lazyBookRepository.Value;
            }
        }
        public IUnitOfWork UnitOfWork 
        {
            get
            {
               return _lazyUnitOfWork.Value;
            }
        }
    }
}
