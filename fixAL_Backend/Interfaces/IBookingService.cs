using fixAL_Backend.DTOs.Booking;
using fixAL_Backend.Models;

namespace fixAL_Backend.Interfaces;

public interface IBookingService
{
        Task<List<BookingsDto>> GetBookings();
        Task<BookingsDto> GetBookingById(int id);
        Task<List<BookingsDto>> GetBookingsByUser(int userId);
        Task<List<BookingsDto>> GetBookingsByWorker(int workerId);
        Task<BookingsDto> CreateBooking(CreateBookingDto bookingDto);
        Task<BookingsDto> UpdateBooking(int id, Status status);
        Task DeleteBooking(int id);
}