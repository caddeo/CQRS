﻿namespace BookARoom.Domain.WriteModel
{
    public interface IBookRooms
    {
        void BookARoom(BookingCommand command);
        void CancelBooking(CancelBookingCommand command);
    }
}