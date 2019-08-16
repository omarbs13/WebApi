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
    public class UserApplication : IUserApplication
    {
        private readonly IUserDomain _userModelDomain;
        private readonly IMapper _mapper;
        private readonly IAppLogger<UserApplication> _logger;
        public UserApplication(IUserDomain userDomain, IMapper mapper, IAppLogger<UserApplication> logger)
        {
            _userModelDomain = userDomain;
            _mapper = mapper;
            _logger = logger;
        }

        public Response<bool> Delete(int id)
        {
            var response = new Response<bool>();
            try
            {
                var user = _userModelDomain.Delete(id);
               // var userList = _mapper.Map<UserModel>(user);
                response.Data = user;

                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminación Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message + "--> InnerException.Message-->" + (e.InnerException != null ? e.InnerException.Message : "");
                _logger.LogError(response.Message);
            }
            return response;
        }

        public async Task<Response<int>> DeleteAsync(int id)
        {
            var response = new Response<int>();
            try
            {
                var user =await _userModelDomain.DeleteAsync(id);
                // var userList = _mapper.Map<UserModel>(user);
                response.Data = user;

                if (response.Data>0)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminación Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message + "--> InnerException.Message-->" + (e.InnerException != null ? e.InnerException.Message : "");
                _logger.LogError(response.Message);
            }
            return response;
        }

        public Response<IList<UserModel>> Find(Expression<Func<UserModel, bool>> predicate)
        {
            var response = new Response<IList<UserModel>>();
            try
            {
                var user = _userModelDomain.Find(c=>c.UserName== "string");
                var userList = _mapper.Map<IList<UserModel>>(user);
                response.Data = userList;

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message + "--> InnerException.Message-->" + (e.InnerException != null ? e.InnerException.Message : "");
                _logger.LogError(response.Message);
            }
            return response;
        }

        public async Task<Response<IList<UserModel>>> FindAsync(Expression<Func<UserModel, bool>> predicate)
        {
            var response = new Response<IList<UserModel>>();
            try
            {
                var user = await _userModelDomain.FindAsync(c => c.UserName == "string");
                var userList = _mapper.Map<IList<UserModel>>(user);
                response.Data = userList;

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message + "--> InnerException.Message-->" + (e.InnerException != null ? e.InnerException.Message : "");
                _logger.LogError(response.Message);
            }
            return response;
        }

        public Response<IEnumerable<UserModel>> GetAll()
        {
            var response = new Response<IEnumerable<UserModel>>();
            try
            {
                var users = _userModelDomain.GetAll(IncludeClass.User);
                var userList = _mapper.Map<IEnumerable<UserModel>>(users);
                response.Data = userList;

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message + "--> InnerException.Message-->" + (e.InnerException != null ? e.InnerException.Message : "");
                _logger.LogError(response.Message);
            }
            return response;
        }

        public async Task<Response<IEnumerable<UserModel>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<UserModel>>();
            try
            {
                var users = await _userModelDomain.GetAllAsync(IncludeClass.User);
                var userList = _mapper.Map<IEnumerable<UserModel>>(users);
                response.Data = userList;

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message + "--> InnerException.Message-->" + (e.InnerException != null ? e.InnerException.Message : "");
                _logger.LogError(response.Message);
            }
            return response;
        }

        public Response<UserModel> GetById(int id)
        {
            var response = new Response<UserModel>();
            try
            {
                var user = _userModelDomain.GetById(id);
                var userList = _mapper.Map<UserModel>(user);
                response.Data = userList;

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message + "--> InnerException.Message-->" + (e.InnerException != null ? e.InnerException.Message : "");
                _logger.LogError(response.Message);
            }
            return response;
        }

        public async Task<Response<UserModel>> GetByIdAsync(int id)
        {
            var response = new Response<UserModel>();
            try
            {
                var user = await _userModelDomain.GetByIdAsync(id);
                var userList = _mapper.Map<UserModel>(user);
                response.Data = userList;

                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message + "--> InnerException.Message-->" + (e.InnerException != null ? e.InnerException.Message : "");
                _logger.LogError(response.Message);
            }
            return response;
        }

        public Response<bool> Insert(UserAddModel userModel)
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
                response.Message = e.Message + "--> InnerException.Message-->" + (e.InnerException != null ? e.InnerException.Message : "");
                _logger.LogError(response.Message);
            }
            return response;
        }

        public async Task<Response<UserModel>> InsertAsync(UserAddModel userModel)
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

        public Response<bool> Update(UserAddModel userModel)
        {
            var response = new Response<bool>();
            try
            {
                var user = _mapper.Map<User>(userModel);
                response.Data = _userModelDomain.Update(user);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualización Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message + "--> InnerException.Message-->" + (e.InnerException != null ? e.InnerException.Message : "");
                _logger.LogError(response.Message);
            }
            return response;
        }

        public async Task<Response<bool>> UpdateAsync(UserAddModel userModel)
        {
            var response = new Response<bool>();
            try
            {
                var userToInst = _mapper.Map<User>(userModel);
                var user = await _userModelDomain.UpdateAsync(userToInst);
                response.Data = user;
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
    }
}
