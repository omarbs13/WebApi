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
        Response<IEnumerable<UserModel>> GetAll();
        Response<IList<UserModel>> Find(Expression<Func<UserModel, bool>> predicate);
        Response<UserModel> GetById(int id);
        Response<bool> Insert(UserAddModel user);
        Response<bool> Update(UserAddModel user);
        Response<bool> Delete(int id);
        Task<Response<IEnumerable<UserModel>>> GetAllAsync();
        Task<Response<IList<UserModel>>> FindAsync(Expression<Func<UserModel, bool>> predicate);
        Task<Response<UserModel>> GetByIdAsync(int id);
        Task<Response<UserModel>> InsertAsync(UserAddModel user);
        Task<Response<bool>> UpdateAsync(UserAddModel user);
        Task<Response<int>> DeleteAsync(int id);
    }
}
