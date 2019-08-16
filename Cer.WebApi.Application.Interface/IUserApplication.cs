using Cer.WebApi.Application.Model;
using Cer.WebApi.Cross.Common;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cer.WebApi.Application.Interface
{
    public interface IUserApplication
    {
        Response<IEnumerable<UserModel>> GetAll(params string[] navigationProperties);
        Response<IEnumerable<UserModel>> GetAll();
        Response<IList<UserModel>> Find(Expression<Func<UserModel, bool>> predicate, params string[] navigationProperties);
        Response<UserModel> GetById(int id);
        Response<bool> Insert(UserModel user);
        Response<bool> Update(UserModel user);
        Response<bool> Delete(int id);
        Task<Response<IEnumerable<UserModel>>> GetAllAsync(params string[] navigationProperties);
        Task<Response<IEnumerable<UserModel>>> GetAllAsync();
        Task<Response<IList<UserModel>>> FindAsync(Expression<Func<UserModel, bool>> predicate, params string[] navigationProperties);
        Task<Response<UserModel>> GetByIdAsync(int id);
        Task<Response<UserModel>> InsertAsync(UserModel user);
        Task<Response<bool>> UpdateAsync(UserModel user);
        Task<Response<int>> DeleteAsync(int id);
    }
}
