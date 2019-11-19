SELECT [a].[name] ArticleName,
       [t].[Name] TagName
FROM [dbo].[Article] a
LEFT JOIN [dbo].[ArticleTag] at ON at.[ArticleID] = [a].[ID]
LEFT JOIN [dbo].[Tag] t ON [at].[TagID] = [t].[ID] 

/*
CREATE TABLE [dbo].[ArticleTag](
	[ArticleID] [int] NOT NULL,
	[TagID] [int] NOT NULL,
 CONSTRAINT [PK_ArticleTag] PRIMARY KEY CLUSTERED 
(
	[ArticleID] ASC,
	[TagID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Article](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_Article] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Tag](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_Tag] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE [dbo].[ArticleTag]  WITH CHECK ADD  CONSTRAINT [FK_ArticleTag_Article] FOREIGN KEY([ArticleID])
REFERENCES [dbo].[Article] ([ID])
GO
ALTER TABLE [dbo].[ArticleTag] CHECK CONSTRAINT [FK_ArticleTag_Article]
GO

ALTER TABLE [dbo].[ArticleTag]  WITH CHECK ADD  CONSTRAINT [FK_ArticleTag_Tag] FOREIGN KEY([TagID])
REFERENCES [dbo].[Tag] ([ID])
GO
ALTER TABLE [dbo].[ArticleTag] CHECK CONSTRAINT [FK_ArticleTag_Tag]
GO
*/