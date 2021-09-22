using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfeBlog.Entities.Concrete;
using EfeBlog.Entities.Dtos;
using EfeBlog.Shared.Utilities.Results.Abstract;

namespace EfeBlog.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<CategoryDto>> Get(int categoryId);
        Task<IDataResult<CategoryListDto>> GetAll();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeleted();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActive();
        Task<IDataResult<CategoryDto>> Add(CategoryAddDto categoryAddDto, string createdByName);
        Task<IDataResult<CategoryDto>> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName);
        Task<IResult> Delete(int categoryId, string modifiedByName);
        Task<IResult> HardDelete(int categoryId);
    }
}
