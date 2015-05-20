SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-12
-- Description:	Procedure that updates an existing company
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================

IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'update_company')
	DROP PROCEDURE update_company
GO

CREATE PROCEDURE update_company 
	-- Add the parameters for the stored procedure here
	@name varchar(50),
	@company_id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

    -- Insert statements for procedure here
	BEGIN
		BEGIN TRANSACTION
			UPDATE companies WITH (ROWLOCK)
			SET name = @name
			WHERE company_id = @company_id
		COMMIT TRANSACTION
	END

	GRANT EXECUTE ON update_company TO PUBLIC

END
GO
