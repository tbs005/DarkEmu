/****** Object:  Table [dbo].[guild_war]    Script Date: 08/08/2011 17:04:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[guild_war](
	[id] [int] NULL,
	[guild_id] [int] NULL,
	[guild_id_2] [int] NULL,
	[status] [tinyint] NULL,
	[war_gold] [bigint] NULL
) ON [PRIMARY]
