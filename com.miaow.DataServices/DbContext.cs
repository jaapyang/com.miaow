/* 
	T4 模块自动生成的代码
	2018-01-10 23:31:29
*/

using System;
using com.miaow.Core.Domain.Repositories;
using com.miaow.Model;
using System.Data.Entity;

namespace com.miaow.DataServices
{
	public partial class MiaowDbContext
	{
		public DbSet<CustomerModel> CustomerModels { get; set; }	
		public DbSet<OrderDetailModel> OrderDetailModels { get; set; }	
		public DbSet<OrderModel> OrderModels { get; set; }	
		public DbSet<ProductModel> ProductModels { get; set; }	
	}
}