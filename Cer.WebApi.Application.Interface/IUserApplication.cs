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
        Response<UserAddModel> Insert(UserAddModel user);
        Response<UserAddModel> Update(UserAddModel user);
        Response<bool> Delete(int id);
        Task<Response<IEnumerable<UserModel>>> GetAllAsync();
        Task<Response<IList<UserModel>>> FindAsync(Expression<Func<UserModel, bool>> predicate);
        Task<Response<UserModel>> GetByIdAsync(int id);
        Task<Response<UserAddModel>> InsertAsync(UserAddModel user);
        Task<Response<UserAddModel>> UpdateAsync(UserAddModel user);
        Task<Response<bool>> DeleteAsync(int id);
    }
}
