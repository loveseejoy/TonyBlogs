﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TonyBlogs.DTO;
using TonyBlogs.DTO.UserPurview;
using TonyBlogs.Entity;

namespace TonyBlogs.IService
{
    public interface IUserPurviewService : IBaseServices<PurviewEntity>
    {
        UserPurviewListDTO GetPurviewList(UserPurviewSearchDTO searchDTO);

        ExecuteResult AddOrEditPurview(UserPurviewEditDTO dto);

        UserPurviewEditDTO GetPurviewEditDTO(long purviewID);

        ExecuteResult DeletePurview(long purviewID);
    }
}
