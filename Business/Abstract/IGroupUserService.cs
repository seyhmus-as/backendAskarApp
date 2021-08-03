using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGroupUserService
    {
        IResult Add(GroupUser GroupUser);
        IResult Update(GroupUser GroupUser);
        IResult Delete(int id);
        IDataResult<List<GroupUser>> GetAll();
        IDataResult<List<GroupUser>> GetById(int GroupUserId);
        IDataResult<List<GroupUserDto>> GetGroupUserDetails();
        
    }
}
