using AutoMapper;
using Cer.WebApi.Application.Interface;
using Cer.WebApi.Application.Model;
using Cer.WebApi.Cross.Common;
using Cer.WebApi.Domain.Entity;
using Cer.WebApi.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cer.WebApi.Application.Main
{
    public class UserModelApplication : IUserApplication
    {
        private readonly IUserDomain _userModelDomain;
        private readonly IMapper _mapper;
        private readonly IAppLogger<UserModelApplication> _logger;
        public UserModelApplication(IUserDomain userDomain, IMapper mapper, IAppLogger<UserModelApplication> logger)
        {
            _userModelDomain = userDomain;
            _mapper = mapper;
            _logger = logger;
        }

        public Response<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<int>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Response<IList<UserModel>> Find(Expression<Func<UserModel, bool>> predicate, params string[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public Task<Response<IList<UserModel>>> FindAsync(Expression<Func<UserModel, bool>> predicate, params string[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public Response<IEnumerable<UserModel>> GetAll(params string[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public Response<IEnumerable<UserModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Response<IEnumerable<UserModel>>> GetAllAsync(params string[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public Task<Response<IEnumerable<UserModel>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Response<UserModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<UserModel>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Response<bool> Insert(UserModel userModel)
        {
            var response = new Response<bool>();
            try
            {
                var user = _mapper.Map<User>(userModel);
                response.Data = _userModelDomain.Insert(user);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro Exitoso!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public async Task<Response<UserModel>> InsertAsync(UserModel userModel)
        {
            var response = new Response<UserModel>();
            try
            {
                var userToInst = _mapper.Map<User>(userModel);
                var user = await _userModelDomain.InsertAsync(userToInst);
                response.Data = _mapper.Map<UserModel>(user);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro Exitoso!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<bool> Update(UserModel UserModel)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> UpdateAsync(UserModel UserModel)
        {
            throw new NotImplementedException();
        }
    }
}
