using System;
using System.Collections.Generic;
using System.Text;
using DrugStore.Application.ViewModels;
using DrugStore.Utilities.Dtos;


namespace DrugStore.Application.Interfaces
{
    public interface IPosition_Service
    {
        List<PositionViewModel> GetAll();

        PagedResult<PositionViewModel> GetAllPaging(string keyword, int page, int pageSize);

        PositionViewModel GetById(int id);

        void Add(PositionViewModel positionVM);

        void Update(PositionViewModel positionVM);

        void Delete(int id);

        void SaveChanges();
    }
}
