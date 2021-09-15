﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfeBlog.Data.Abstract;
using EfeBlog.Entities.Concrete;
using EfeBlog.Entities.Dtos;
using EfeBlog.Services.Abstract;
using EfeBlog.Shared.Utilities.Results.Abstract;
using EfeBlog.Shared.Utilities.Results.ComplexTypes;
using EfeBlog.Shared.Utilities.Results.Concrete;

namespace EfeBlog.Services.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        public async Task<IDataResult<Category>> Get(int categoryId)
        {
            var category = await _unitOfWork.Categories.GetAsync(c => c.Id == categoryId,c=>c.Articles);
            if (category != null)
            {
                return new DataResult<Category>(ResultStatus.Success,category);
            }

            return new DataResult<Category>(ResultStatus.Error, "Böyle bir kategori bulunamadı.", null);

        }

        public async Task<IDataResult<IList<Category>>> GetAll()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(null, c => c.Articles);
            if (categories.Count>-1)
            {
                return new DataResult<IList<Category>>(ResultStatus.Success,categories);
            }

            return new DataResult<IList<Category>>(ResultStatus.Error, "Kategoriler bulunamadı", null);
        }

        public async Task<IDataResult<IList<Category>>> GetAllByNonDeleted()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(c=>!c.IsDeleted,c=>c.Articles);
            if (categories.Count > -1)
            {
                return new DataResult<IList<Category>>(ResultStatus.Success, categories);
            }
            return new DataResult<IList<Category>>(ResultStatus.Error, "Kategoriler bulunamadı", null);
        }

        public Task<IResult> Add(CategoryAddDto categoryAddDto, string createdByName)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> HardDelete(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
