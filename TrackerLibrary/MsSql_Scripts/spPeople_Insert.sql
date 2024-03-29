USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spPeople_Insert]    Script Date: 2024. 03. 17. 13:18:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Tibor Szuntheimer
-- Create date: 2024.03.17
-- Description:	Insert a new person.
-- =============================================
CREATE PROCEDURE [dbo].[spPeople_Insert]
	@FirstName nvarchar(100),
	@LastName nvarchar(100),
	@EmailAddress nvarchar(100),
	@CellphoneNumber varchar(20),
	@id int = 0 output

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into dbo.People (FirstName, LastName, EmailAddress, CellphoneNumber)
	values (@FirstName, @LastName, @EmailAddress, @CellphoneNumber);

	select @id = SCOPE_IDENTITY();
END
