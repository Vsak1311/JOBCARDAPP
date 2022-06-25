--Database Design for JOBCARD App
USE RIYALOJOBCARD

GO
--TblUser
CREATE TABLE [dbo].[TblUsers](
	[UserID] [int]  NOT NULL,
	[UserName] [varchar](100) NULL,
	[Password] [varchar](100) NULL,
	[UEmail] [varchar](100) NULL,
	[UserDep] [varchar](100) NULL,
	[Store] [varchar](100) NULL,
	[LocId] [int] NULL,
	[IsActive] [bit] NOT NULL,
	[CounterId] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--TblTechnician

CREATE TABLE [dbo].[TblTechnician](
	[Tid] [int]  NOT NULL,
	[T_Name] [varchar](300) NULL,
 CONSTRAINT [PK_TblTechnician] PRIMARY KEY CLUSTERED 
(
	[Tid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--TblLocation

CREATE TABLE [dbo].[TblLocation](
	[LocId] [int] NOT NULL,
	[LocName] [varchar](200) NULL,
 CONSTRAINT [PK_TblLocation] PRIMARY KEY CLUSTERED 
(
	[LocId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--TblCompaint

CREATE TABLE [dbo].[TblComplaint](
	[Cid] [int]  NOT NULL,
	[C_Desc] [varchar](500) NULL,
 CONSTRAINT [PK_TblComplaint] PRIMARY KEY CLUSTERED 
(
	[Cid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--TblCheckList

CREATE TABLE [dbo].[TblChecklist](
	[ChkId] [int]  NOT NULL,
	[JobId] [int] NULL,
	[Item] [varchar](200) NULL,
	[Condition] [varchar](250) NULL,
 CONSTRAINT [PK_TblChecklist] PRIMARY KEY CLUSTERED 
(
	[ChkId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--TblBrand

CREATE TABLE [dbo].[TblBrand](
	[Bid] [int]  NOT NULL,
	[Br_Name] [varchar](300) NULL,
 CONSTRAINT [PK_TblBrand] PRIMARY KEY CLUSTERED 
(
	[Bid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


--TblSettlement

CREATE TABLE [dbo].[TblSettlement](
	[Sid] [int]  NOT NULL,
	[JobId] [int] NOT NULL,
	[CPrice] [money] NULL,
	[SPrice] [money] NULL,
	[Disc] [money] NULL,
	[VAT] [money] NULL,
 CONSTRAINT [PK_TblSettlement] PRIMARY KEY CLUSTERED 
(
	[Sid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--TblJobMaster


CREATE TABLE [dbo].[TblJobMaster](
	[JobId] [int] IDENTITY(1,1) NOT NULL,
	[Jobcode] [int] NOT NULL,
	[CustId] [int] NOT NULL,
	[CustName] [varchar](200) NOT NULL,
	[PhNo] [varchar](50) NOT NULL,
	[TechID] [int] NOT NULL,
	[BrandID] [int] NOT NULL,
	[Prod_Name] [varchar](500) NULL,
	[SNo] [int] NULL,
	[Cid] [int] NULL,
	[Year] [int] NULL,
	[Exp_Del_date] [datetime] NULL,
	[JobDate] [datetime] NOT NULL,
	[LocId] [int] NOT NULL,
	[StatusID] [int] NOT NULL,
	[Notes] [varchar](1000) NULL,
 CONSTRAINT [PK_TblJobMaster] PRIMARY KEY CLUSTERED 
(
	[JobId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


--TblCustomer

CREATE TABLE [dbo].[TblCustomer](
	[CustId] [int] IDENTITY(1001,1) NOT NULL,
	[CustCode] [int] NOT NULL,
	[CustName] [varchar](500) NULL,
	[Mobile] [varchar](20) NULL,
	[Telephone] [varchar](50) NULL,
	[Address] [varchar](500) NULL,
	[LocId] [int] NULL,
	[State] [varchar](50) NULL,
	[Country] [varchar](50) NULL,
	[Email] [varchar](150) NULL,
	[IsWhatsapp] [bit] NULL,
	[IsEmail] [bit] NULL,
	[IsSms] [bit] NULL,
 CONSTRAINT [PK_TblCustomer] PRIMARY KEY CLUSTERED 
(
	[CustId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--TblIdCounter

CREATE TABLE [dbo].[TblIDCounter](
	[UserId] [int] NULL,
	[Tid] [int] NULL,
	[LocId] [int] NULL,
	[Cid] [int] NULL,
	[ChkId] [int] NULL,
	[Bid] [int] NULL,
	[Sid] [int] NULL,
	[JobId] [int] NULL,
	[CustId] [int] NULL
) ON [PRIMARY]

GO

--Initialization of tblIdCounter

insert into TblIDCounter values(1,1,1,1,1,1,1,1,1)

GO

-- Proc For Autoincrement

CREATE PROCEDURE [Get_Transaction_ID] 	
@ftype nvarchar(500) AS 

BEGIN 		
SET NOCOUNT ON;	BEGIN TRANSACTION 	
DECLARE @retval bigint; 
DECLARE @SQLQUERY nVARCHAR(4000)	;
DECLARE @ParmDefinition nvarchar(500);
SET @SQLQUERY =N'UPDATE TblIDCounter SET   @CurVal='+ @ftype+',' + @ftype + '=' +@ftype +'+1 '	;
SET @ParmDefinition = N'@CurVal bigint OUTPUT';
EXECUTE sys.sp_executesql @SQLQUERY,  @ParmDefinition,@CurVal=@retval output;
select @retval;
COMMIT  TRANSACTION ;   
END  


GO



--TblStatus



CREATE TABLE [dbo].[TblStatus](
	[ID] [int]  NOT NULL,
	[StatusName] [nvarchar](50) NULL,
	[Description] [nvarchar](150) NULL,
	[BCOLOR] [int] NULL,
 CONSTRAINT [PK_TblStatus] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


GO



--Dashboard display view

CREATE VIEW vw_JobMaster AS
SELECT        CAST(TblJobMaster.JobDate AS date) AS JobDate, TblJobMaster.Jobcode, TblJobMaster.CustName, TblJobMaster.PhNo, TblBrand.Br_Name, TblJobMaster.Prod_Name, TblJobMaster.SNo, TblComplaint.C_Desc, 
                         TblStatus.StatusName
FROM            TblJobMaster LEFT OUTER JOIN
                         TblStatus ON TblJobMaster.StatusID = TblStatus.ID LEFT OUTER JOIN
                         TblComplaint ON TblJobMaster.Cid = TblComplaint.Cid LEFT OUTER JOIN
                         TblBrand ON TblJobMaster.BrandID = TblBrand.Bid


GO


--JobCard Edit Fill

CREATE VIEW vw_JobMaster_Load AS
SELECT        TblJobMaster.Jobcode, TblJobMaster.CustName, TblJobMaster.PhNo, TblTechnician.T_Name, TblBrand.Br_Name, TblJobMaster.Prod_Name, TblJobMaster.SNo, TblComplaint.C_Desc, TblJobMaster.Year, 
                         TblJobMaster.Exp_Del_date, TblJobMaster.JobDate, TblLocation.LocName, TblStatus.StatusName, TblJobMaster.Notes
FROM            TblJobMaster LEFT OUTER JOIN
                         TblLocation ON TblJobMaster.LocId = TblLocation.LocId LEFT OUTER JOIN
                         TblTechnician ON TblJobMaster.TechID = TblTechnician.Tid LEFT OUTER JOIN
                         TblStatus ON TblJobMaster.StatusID = TblStatus.ID LEFT OUTER JOIN
                         TblComplaint ON TblJobMaster.Cid = TblComplaint.Cid LEFT OUTER JOIN
                         TblBrand ON TblJobMaster.BrandID = TblBrand.Bid


GO


--Customer History filling



CREATE VIEW [dbo].[vw_JobMaster_Cust] AS
SELECT        CAST(TblJobMaster.JobDate AS date) AS [JOB DATE], TblJobMaster.Jobcode AS [JOB NO], TblCustomer.CustCode AS [CUSTOMER CODE], 
				TblCustomer.CustName AS [CUSTOMER NAME], TblJobMaster.PhNo AS [PHONE NO], 
				TblBrand.Br_Name AS [BRAND], TblJobMaster.Prod_Name AS [PRODUCT NAME], TblJobMaster.SNo AS [SERIAL NO], TblComplaint.C_Desc AS [COMPLAINT], 
                         TblStatus.StatusName AS [CURRENT STATUS]
FROM            TblJobMaster LEFT OUTER JOIN
                         TblCustomer ON TblJobMaster.CustId = TblCustomer.CustCode LEFT OUTER JOIN
                         TblStatus ON TblJobMaster.StatusID = TblStatus.ID LEFT OUTER JOIN
                         TblComplaint ON TblJobMaster.Cid = TblComplaint.Cid LEFT OUTER JOIN
                         TblBrand ON TblJobMaster.BrandID = TblBrand.Bid

GO

-- Item Category 


CREATE TABLE [dbo].[TblItemCategory](
	[CatId] [int] IDENTITY(1,1) NOT NULL,
	[CatCode] [varchar](50) NULL,
	[CatName] [varchar](150) NULL,
	[GroupId] [int] NULL,
 CONSTRAINT [PK_TblItemCategory] PRIMARY KEY CLUSTERED 
(
	[CatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


--Item Group

CREATE TABLE [dbo].[TblItemGroup](
	[Gid] [int] IDENTITY(1,1) NOT NULL,
	[GName] [varchar](200) NULL,
 CONSTRAINT [PK_TblItemGroup] PRIMARY KEY CLUSTERED 
(
	[Gid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


--Item Master


CREATE TABLE [dbo].[TblItems](
	[ItemId] [int] IDENTITY(1,1) NOT NULL,
	[ItemCode] [varchar](50) NULL,
	[ItemName] [varchar](500) NULL,
	[ItemName_2] [varchar](500) NULL,
	[CatId] [int] NULL,
	[Gid] [int] NULL,
	[BarCode] [varchar](150) NULL,
	[LocId] [int] NULL,
	[Description] [varchar](500) NULL,
	[Origin] [varchar](150) NULL,
	[HSCode] [varchar](50) NULL,
	[IsBatch] [bit] NULL,
	[Store] [varchar](150) NULL,
	[BaseUnitId] [int] NULL,
	[InSampleUnitID] [int] NULL,
	[SubUnitId] [int] NULL,
	[AvlQty] [float] NULL,
	[Rate] [money] NULL,
	[WRP] [money] NULL,
	[DRP] [money] NULL,
	[isAdvance] [bit] NULL,
	[Expiry] [datetime] NULL,
	[BatchNo] [varchar](50) NULL,
 CONSTRAINT [PK_TblItems] PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



--Item Unit Master


CREATE TABLE [dbo].[TblUnit](
	[UnitId] [int] IDENTITY(1,1) NOT NULL,
	[UnitName] [varchar](150) NULL,
	[IsBaseUnit] [bit] NULL,
	[BaseUnitId] [int] NULL,
	[IsSubunit] [bit] NULL,
 CONSTRAINT [PK_TblUnit] PRIMARY KEY CLUSTERED 
(
	[UnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO













