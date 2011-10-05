/****** Object:  Table [dbo].[rank_job_donate]    Script Date: 08/08/2011 17:04:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[rank_job_donate](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[job_type] [tinyint] NULL,
	[job_rank] [tinyint] NULL,
	[job_name] [varchar](50) NULL,
	[job_level] [tinyint] NULL,
	[job_donate] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF