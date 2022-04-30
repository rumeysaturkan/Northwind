using NorthWind.Entity.Dto;
using NorthWind.Entity.IBase;
using NorthWind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Interface
{
    public interface IUserService:IGenericService<User, DtoUser>
    {
        IResponse<DtoUserToken> Login(DtoLogin login);
    }
}
