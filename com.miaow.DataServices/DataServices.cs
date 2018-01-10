/* 
	T4 模块自动生成的代码
	2018-01-10 23:18:03
*/

using System;
using com.miaow.Core.Domain.Repositories;
using com.miaow.Model;

namespace com.miaow.DataServices
{
	public partial class CustomerDataService : NorthwindRepository<String, CustomerModel>, ICustomerDataService
	{
		
	}

	public partial class OrderDetailDataService : NorthwindRepository<Int32, OrderDetailModel>, IOrderDetailDataService
	{
		
	}

	public partial class OrderDataService : NorthwindRepository<Int32, OrderModel>, IOrderDataService
	{
		
	}

	public partial class ProductDataService : NorthwindRepository<Int32, ProductModel>, IProductDataService
	{
		
	}


}