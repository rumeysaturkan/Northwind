﻿
using NorthWind.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Interface
{
    public interface IGenericService<T, TDto> where T : IEntityBase where TDto : IDtoBase
    {
        //IEnumerable ile IQueryable farkı IQueryable veri tabanında işlemi yapar, IEnumerable ram'de işlemi yapar.
        //Listeleme
        IResponse<List<TDto>> GetAll();
        //Filtreli Listeleme
        IResponse<List<TDto>> GetAll(Expression<Func<T, bool>> expression);
        //Getirme
        IResponse<TDto> Find(int id);
        //Kaydetme
        IResponse<TDto> Add(TDto item, bool saveChanges = true);
        //Async Kaydetme
        Task<IResponse<TDto>> AddAsync(TDto item, bool saveChanges = true);
        //Güncelleme
        IResponse<TDto> Update(TDto item, bool saveChanges = true);
        //Silme
        IResponse<bool> DeleteById(int id, bool saveChanges = true);
        //Queryable Listeleme
        IResponse<IQueryable<TDto>> GetQueryable();
        //Kaydet
        void Save();
    }
}
