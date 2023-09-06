create database DB_Api
USE [DB_Api]
GO

INSERT INTO [dbo].[Funcs]
           ([TipoFunc])
     VALUES
           ('Ca�ador de onis')
GO

INSERT INTO [dbo].[Funcs]
           ([TipoFunc])
     VALUES
           ('Hashira')
GO

INSERT INTO [dbo].[Funcs]
           ([TipoFunc])
     VALUES
           ('Oni')
GO

INSERT INTO [dbo].[Poders]
           ([Resp])
     VALUES
           ('Rel�mpago')
GO

INSERT INTO [dbo].[Poders]
           ([Resp])
     VALUES
           ('�gua')
GO

INSERT INTO [dbo].[Poders]
           ([Resp])
     VALUES
           ('Inserto')
GO

INSERT INTO [dbo].[Poders]
           ([Resp])
     VALUES
           ('Nenhuma')
GO

INSERT INTO [dbo].[Poders]
           ([Resp])
     VALUES
           ('Fogo')
GO

INSERT INTO [dbo].[Persos]
           ([Nome]
           ,[Origem]
           ,[Apelido]
           ,[Metas]
           ,[FuncId]
           ,[PoderId])
     VALUES
           ('Zenitsu Agatsuma',
           'Demon Slayer: Kimetsu no Yaiba',
           'Monitsu',
           'Ganhar o afeto da Nezuko',
           1,
           1)
GO

INSERT INTO [dbo].[Persos]
           ([Nome]
           ,[Origem]
           ,[Apelido]
           ,[Metas]
           ,[FuncId]
           ,[PoderId])
     VALUES
           ('Tanjiro Kamado',
           'Demon Slayer: Kimetsu no Yaiba',
           'Nenhum',
           'Transformar Nezuko de volta em um humano',
           1,
           2)
GO

INSERT INTO [dbo].[Persos]
           ([Nome]
           ,[Origem]
           ,[Apelido]
           ,[Metas]
           ,[FuncId]
           ,[PoderId])
     VALUES
           ('Shinobu Kocho',
           'Demon Slayer: Kimetsu no Yaiba',
           'Hashira do Inseto',
           'Vinguar sua irm� Kanae matando Doma ',
           2,
           3)
GO

INSERT INTO [dbo].[Persos]
           ([Nome]
           ,[Origem]
           ,[Apelido]
           ,[Metas]
           ,[FuncId]
           ,[PoderId])
     VALUES
           ('Giyu Tomioka',
           'Demon Slayer: Kimetsu no Yaiba',
           'Hashira da �gua',
           'Acabar com Muzan Kibutsuji e a ra�a Oni',
           2,
           2)
GO

INSERT INTO [dbo].[Persos]
           ([Nome]
           ,[Origem]
           ,[Apelido]
           ,[Metas]
           ,[FuncId]
           ,[PoderId])
     VALUES
           ('Nezuko Kamado',
           'Demon Slayer: Kimetsu no Yaiba',
           'Oni Escolhido',
           'Garota da Aldeia',
           3,
           4)
GO

INSERT INTO [dbo].[Persos]
           ([Nome]
           ,[Origem]
           ,[Apelido]
           ,[Metas]
           ,[FuncId]
           ,[PoderId])
     VALUES
           ('Kyojuro Rengoku',
           'Demon Slayer: Kimetsu no Yaiba',
           'Pilar da Chama',
           'Aniquilar a ra�a oni',
           2,
           5)
GO