for test this sample, create a login in sql server (user: retail & pass: 1177)

create db
---------------------------------------------------------------------
USE [RetailDb]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 04/14/2019 20:30:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](max) NULL,
	[RetailerId] [int] NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Retailers]    Script Date: 04/14/2019 20:30:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Retailers](
	[RetailerId] [int] IDENTITY(1,1) NOT NULL,
	[RetailerName] [nvarchar](max) NULL,
	[HypassRestriction] [bit] NOT NULL,
 CONSTRAINT [PK_Retailers] PRIMARY KEY CLUSTERED 
(
	[RetailerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 
GO
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [RetailerId]) VALUES (1, N'hassan hosseini', 1)
GO
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Retailers] ON 
GO
INSERT [dbo].[Retailers] ([RetailerId], [RetailerName], [HypassRestriction]) VALUES (1, N'admin', 1)
GO
SET IDENTITY_INSERT [dbo].[Retailers] OFF
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_Retailers_RetailerId] FOREIGN KEY([RetailerId])
REFERENCES [dbo].[Retailers] ([RetailerId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_Retailers_RetailerId]
GO

---------------------------------------------------------------------


Api Help
add customer url: https://localhost:44382/api/customer/add
add customer json: 
{
	"customerName":"hassan hosseini",
	"retailerId":1
}

update customer url: https://localhost:44382/api/customer/update
update customer json: 
{
	"customerName":"hassan hosseini fard",
	"retailerId":1
}

remove customer url: https://localhost:44382/api/customer/remove
remove customer json: 
{
	"customerId":1
}

Get Customer customer url: https://localhost:44382/api/customer/Get
Get Customer customer json: 
{
	"customerId":1
}

Get All Customer customer url: https://localhost:44382/api/customer/GetAll
Get All Customer customer json: 
{
	"retailerId":1
}


