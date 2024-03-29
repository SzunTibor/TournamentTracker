USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTeamMembers_Insert]    Script Date: 2024. 03. 17. 13:21:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Tibor Szuntheimer
-- Create date: 2024.03.17.
-- Description:	Insert a new team member.
-- Return:		id of created new team member.
-- =============================================
CREATE PROCEDURE [dbo].[spTeamMembers_Insert]
	@TeamId int,
	@PersonId int,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.TeamMembers (TeamId, PersonId)
	values (@TeamId, @PersonId);

	select @id = SCOPE_IDENTITY();
END
