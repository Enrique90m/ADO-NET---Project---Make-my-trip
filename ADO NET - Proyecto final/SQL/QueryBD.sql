CREATE DATABASE ProjectAirline

use ProjectAirline

CREATE TABLE City(
	[CityCode] [varchar](3) NOT NULL,
	[CityName] [varchar](50) NOT NULL,
 CONSTRAINT [CityCode_PK] PRIMARY KEY CLUSTERED 
(
	[CityCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[CityName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[CityCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--********************************************************************
CREATE TABLE Customer(
	[CustomerId] [int] IDENTITY(100,1) NOT NULL,
	[FistName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Address] [varchar](50),
	)


--********************************************************************
CREATE TABLE Flight(
	[FlightNo] [int] IDENTITY(500,1) NOT NULL,
	[Source] [varchar](3) NOT NULL,
	[Destination] [varchar](3) NOT NULL,
	[DepartureDate] [datetime] NOT NULL,
	[ArrivalDate] [datetime] NOT NULL,
	[AdultFare] [int] NOT NULL,
	[ChildFare] [int] NOT NULL,
	[TotalPassenger] [int] NOT NULL,
 CONSTRAINT [FlightNo_PK] PRIMARY KEY CLUSTERED 
(
	[FlightNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE Flight  WITH CHECK ADD  CONSTRAINT [Destination_FK] FOREIGN KEY([Destination])
REFERENCES City ([CityCode])
GO

ALTER TABLE Flight  WITH CHECK ADD  CONSTRAINT [Source_FK] FOREIGN KEY([Source])
REFERENCES City ([CityCode])
GO
--********************************************************************
CREATE TABLE Flight_Booking(
	[BookingId] [varchar](4) NOT NULL,
	[FlightNo] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[DateOfBooking] [datetime] NOT NULL,
	[DateOfDeparture] [datetime] NOT NULL,
	[NoOfAdults] [int] NOT NULL,
	[NoOfChildren] [int] NOT NULL,
 CONSTRAINT [BookingId_PK] PRIMARY KEY CLUSTERED 
(
	[BookingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[BookingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE Flight_Booking  WITH CHECK ADD  CONSTRAINT [CustomerId_FK] FOREIGN KEY([CustomerId])
REFERENCES Customer ([CustomerId])
GO

ALTER TABLE Flight_Booking CHECK CONSTRAINT [CustomerId_FK]
GO

ALTER TABLE Flight_Booking  WITH CHECK ADD  CONSTRAINT [FlightNo_FK] FOREIGN KEY([FlightNo])
REFERENCES Flight ([FlightNo])
GO

ALTER TABLE Flight_Booking CHECK CONSTRAINT [FlightNo_FK]
GO

ALTER TABLE Flight_Booking  WITH CHECK ADD  CONSTRAINT [DateOfJourney_chk] CHECK  ((datediff(day,[DateOfBooking],[DateOfJourney])>=(0)))
GO

ALTER TABLE Flight_Booking CHECK CONSTRAINT [DateOfJourney_chk]
GO


--********************************************************************
CREATE TABLE PassengerDetails(
	[CustomerId] [int] NOT NULL PRIMARY KEY,
	[BookingId] [varchar](4) NOT NULL,
	[FlightNo] [int] NOT NULL,
	[Title] [varchar](4),
	[FistName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
 )


ALTER TABLE PassengerDetails  WITH CHECK ADD  CONSTRAINT [CustomerId_FK2] FOREIGN KEY([CustomerId])
REFERENCES Customer ([CustomerId])
GO

ALTER TABLE PassengerDetails  WITH CHECK ADD  CONSTRAINT [BookingId_FK2] FOREIGN KEY([BookingId])
REFERENCES Flight_Booking ([BookingId])
GO

ALTER TABLE PassengerDetails  WITH CHECK ADD  CONSTRAINT [FlightNo_FK2] FOREIGN KEY([FlightNo])
REFERENCES Flight ([FlightNo])
GO


