﻿using JJRentals.Shared.Domain;

namespace JJRentals.Server.IRepository
{
	public interface IUnitOfWork : IDisposable
	{
		Task Save(HttpContext httpContext);
		IGenericRepository<Manufacturer> Manufacturers { get; }
		IGenericRepository<Model> Models { get; }
		IGenericRepository<Car> Cars { get; }
		IGenericRepository<Booking> Bookings { get; }
		IGenericRepository<Customer> Customers { get; }
		IGenericRepository<Payment> Payments { get; }
        IGenericRepository<Staff> Staffs { get; }
        IGenericRepository<Maintenance> Maintenances { get; }
        IGenericRepository<Outlet> Outlets { get; }
        IGenericRepository<Image> Images { get; }
    }
}
