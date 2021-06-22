﻿using MIUBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MIUBlog.Business.Abstract
{
   public interface IDiscussionService
    {
        List<Discussion> GetAll();

        Discussion Get(int id);
        public List<Discussion> GetByUserId(string userId);

        void Add(Discussion discussion);
        void Update(Discussion discussion);
        void Delete(int id);
    }
}
