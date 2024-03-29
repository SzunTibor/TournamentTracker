USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spPeople_GetAll]    Script Date: 2024. 03. 17. 13:16:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Tibor Szuntheimer
-- Create date: 2024.03.17
-- Description:	Returns all people.
-- =============================================
CREATE PROCEDURE [dbo].[spPeople_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM dbo.People;
END
