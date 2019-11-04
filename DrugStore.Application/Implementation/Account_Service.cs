using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using DrugStore.Application.Interfaces;
using DrugStore.Application.ViewModels;
using DrugStore.Data.Entities;
using DrugStore.Infrastructure.Interfaces;
using DrugStore.Utilities.Dtos;
using DrugStore.Data.Enums;

namespace DrugStore.Application.Implementation
{
    public class Account_Service: IAccount_Service
    {
        private IRepository<Account, int> _accountRepository;
        private IUnitOfWork _unitOfWork;

        public Account_Service(IRepository<Account, int> accountRepository,
            IUnitOfWork unitOfWork)
        {
            _accountRepository = accountRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(AccountViewModel AccountVM)
        {
            var model = Mapper.Map<AccountViewModel, Account>(AccountVM);
            _accountRepository.Add(model);
        }

        public void Delete(int id)
        {
            _accountRepository.Remove(id);
        }

        public List<AccountViewModel> GetAll()
        {
            return _accountRepository.FindAll().ProjectTo<AccountViewModel>().ToList();
        }

        public PagedResult<AccountViewModel> GetAllPaging(string status, string keyword, int page, int pageSize)
        {
            var query = _accountRepository.FindAll();
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.FullName.Contains(keyword) ||
                x.UserName.Contains(keyword));

            if (!string.IsNullOrEmpty(status))
            {
                if (status == "Active")
                {
                    query = query.Where(x => x.Status == Status.Active);
                }
                else if (status == "InActive")
                {
                    query = query.Where(x => x.Status == Status.InActive);
                }
            }

            int totalRow = query.Count();
            var data = query.OrderBy(x => x.Date_Created)
                .Skip((page) * pageSize)
                .Take(pageSize);
            int rowOnPage = data.Count();

            var paginationSet = new PagedResult<AccountViewModel>()
            {
                Results = data.ProjectTo<AccountViewModel>().ToList(),
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize,
                FirstRowOnPage = (page * pageSize) + 1,
                LastRowOnPage = (page * pageSize) + rowOnPage
            };

            return paginationSet;
        }

        public AccountViewModel GetById(int id)
        {
            return Mapper.Map<Account, AccountViewModel>(_accountRepository.FindById(id));
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(AccountViewModel AccountVM)
        {
            var page = Mapper.Map<AccountViewModel, Account>(AccountVM);
            _accountRepository.Update(page);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
