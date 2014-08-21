USE [ProjectAirline]
GO

INSERT INTO [dbo].[Flight]
           ([Source]
           ,[Destination]
           ,[DepartureDate]
           ,[ArrivalDate]
           ,[AdultFare]
           ,[ChildFare]
           ,[TotalPassenger])
     VALUES
           ('MTY',
           'NY',
           '2014-08-21T10:34:06',
           '2014-08-28T15:40:19',
           80,
           90,
           0)
GO

