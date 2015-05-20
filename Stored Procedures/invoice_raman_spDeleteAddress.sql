SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =================================================================================
-- Author:		Raman Dhatt
-- Create date: 2015-05-15
-- Description:	Procedure that deletes an address.
-- Revisions:
--		Author                  Date       	Description                                       
--		------------------- 	---------- 	--------------------------------------
-- =================================================================================
IF EXISTS (SELECT * FROM SYSOBJECTS WHERE NAME = 'delete_address')
	DROP PROCEDURE delete_address
GO

CREATE PROCEDURE delete_address
	@address_id int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET XACT_ABORT ON;

    -- Insert statements for procedure here
	BEGIN TRANSACTION

		DELETE FROM addresses WITH (ROWLOCK)
		WHERE address_id = @address_id

	COMMIT TRANSACTION

	GRANT EXECUTE ON delete_address TO PUBLIC

END
GO
