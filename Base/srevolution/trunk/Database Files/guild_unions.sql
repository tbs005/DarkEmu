/****** Object:  Table [dbo].[guild_unions]    Script Date: 08/08/2011 17:04:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[guild_unions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[union_leader] [int] NULL,
	[union_guildid] [int] NULL,
	[union_unique_id] [int] NULL CONSTRAINT [DF_guild_unions_union_unique_id]  DEFAULT ((0))
) ON [PRIMARY]
