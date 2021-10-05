/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [id_usuario]
      ,[id_perfil]
      ,[usuario]
      ,[password]
      ,[email]
      ,[estado]
  FROM [BTSPAVI3K22021].[dbo].[Usuarios]
