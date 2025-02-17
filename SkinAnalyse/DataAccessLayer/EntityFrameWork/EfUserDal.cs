﻿using DataAccessLayer.Abstruct;
using DataAccessLayer.Context;
using DataAccessLayer.Repository;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFrameWork
{
	public class EfUserDal : GenericRepository<User>, IUserDal
	{
		public EfUserDal(SkinAnalyseContext context) : base(context)
		{
		}
	}
}
