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
    public class Position_Service: IPosition_Service
    {
        private IRepository<Position, int> _positionRepository;
        private IUnitOfWork _unitOfWork;

        public Position_Service(IRepository<Position, int> positionRepository,
            IUnitOfWork unitOfWork)
        {
            _positionRepository = positionRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(PositionViewModel PositionVM)
        {
            var model = Mapper.Map<PositionViewModel, Position>(PositionVM);
            _positionRepository.Add(model);
        }

        public void Delete(int id)
        {
            _positionRepository.Remove(id);
        }

        public List<PositionViewModel> GetAll()
        {
            return _positionRepository.FindAll().ProjectTo<PositionViewModel>().ToList();
        }

        public PagedResult<PositionViewModel> GetAllPaging(string keyword, int page, int pageSize)
        {
            var query = _positionRepository.FindAll();
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Position_Code.Contains(keyword) || x.Position_Name.Contains(keyword) ||
                         x.Position_Alias.Contains(keyword));

            int totalRow = query.Count();
            var data = query.OrderBy(x => x.Position_Code)
                .Skip((page) * pageSize)
                .Take(pageSize);
            int rowOnPage = data.Count();

            var paginationSet = new PagedResult<PositionViewModel>()
            {
                Results = data.ProjectTo<PositionViewModel>().ToList(),
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize,
                FirstRowOnPage = (page * pageSize) + 1,
                LastRowOnPage = (page * pageSize) + rowOnPage
            };

            return paginationSet;
        }

        public PositionViewModel GetById(int id)
        {
            return Mapper.Map<Position, PositionViewModel>(_positionRepository.FindById(id));
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(PositionViewModel PositionVM)
        {
            var page = Mapper.Map<PositionViewModel, Position>(PositionVM);
            _positionRepository.Update(page);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
