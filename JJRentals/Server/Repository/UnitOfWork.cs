using JJRentals.Server.Repository;
using JJRentals.Server.Data;
using JJRentals.Server.IRepository;
using JJRentals.Server.Models;
using JJRentals.Shared.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace JJRentals.Server.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ApplicationDbContext _context;
		private IGenericRepository<Manufacturer> _manus;
		private IGenericRepository<Model> _models;
		private IGenericRepository<Booking> _bookings;
		private IGenericRepository<Customer> _customers;
		private IGenericRepository<Car> _cars;
		private IGenericRepository<Payment> _payments;
        private IGenericRepository<Staff> _staffs;
        private IGenericRepository<Outlet> _outlets;
        private IGenericRepository<Maintenance> _maintenances;
        private IGenericRepository<Image> _images;

        private UserManager<ApplicationUser> _userManager;

		public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
		{
			_context = context;
			_userManager = userManager;
		}

		public IGenericRepository<Manufacturer> Manufacturers
			=> _manus ??= new GenericRepository<Manufacturer>(_context);
		public IGenericRepository<Model> Models
			=> _models ??= new GenericRepository<Model>(_context);
		public IGenericRepository<Car> Cars
			=> _cars ??= new GenericRepository<Car>(_context);
		public IGenericRepository<Booking> Bookings
			=> _bookings ??= new GenericRepository<Booking>(_context);
		public IGenericRepository<Customer> Customers
			=> _customers ??= new GenericRepository<Customer>(_context);
		public IGenericRepository<Payment> Payments
			=> _payments ??= new GenericRepository<Payment>(_context);
        public IGenericRepository<Staff> Staffs
            => _staffs ??= new GenericRepository<Staff>(_context);
        public IGenericRepository<Outlet> Outlets
            => _outlets ??= new GenericRepository<Outlet>(_context);
        public IGenericRepository<Maintenance> Maintenances
            => _maintenances ??= new GenericRepository<Maintenance>(_context);
        public IGenericRepository<Image> Images
            => _images ??= new GenericRepository<Image>(_context);

        public void Dispose()
		{
			_context.Dispose();
			GC.SuppressFinalize(this);
		}

		public async Task Save(HttpContext httpContext)
		{
			//To be implemented
			string user = "System";

			var entries = _context.ChangeTracker.Entries()
				.Where(q => q.State == EntityState.Modified ||
					q.State == EntityState.Added);

			foreach (var entry in entries)
			{
				((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
				((BaseDomainModel)entry.Entity).UpdatedBy = user;
				if (entry.State == EntityState.Added)
				{
					((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
					((BaseDomainModel)entry.Entity).CreatedBy = user;
				}
			}

			await _context.SaveChangesAsync();
		}
	}
}
