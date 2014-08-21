USE [ProjectAirline]
GO

INSERT INTO [dbo].[Flight_Booking]
           ([BookingId]
           ,[FlightNo]
           ,[CustomerId]
           ,[DateOfBooking]
           ,[DateOfDeparture]
           ,[NoOfAdults]
           ,[NoOfChildren])
     VALUES
           (1,500,100,'2014-08-21T10:34:06', '2014-08-22T10:34:06',2,2)
GO


